using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;

namespace CleverBoard.Hotkey
{
    class HotkeyBindingManager
    {
        public BindingList<HotkeyBinding> Bindings;

     
        private bool _loaded = false;

        public int Add(HotkeyBinding binding)
        {
            if (!_loaded)
                throw new NullReferenceException(Properties.strings.Bindings_not_loaded);
            Bindings.Add(binding);
           
            Save();
            return Bindings.IndexOf(binding);
        }
        public void Remove(int index)
        {
            if (!_loaded)
                throw new NullReferenceException(Properties.strings.Bindings_not_loaded);
            Bindings.RemoveAt(index);
            Save();
        }
        public void Remove(HotkeyBinding binding)
        {
            if (!_loaded)
                throw new NullReferenceException(Properties.strings.Bindings_not_loaded);
            Bindings.Remove(binding);
            Save();
        }

        public IEnumerable<HotkeyBinding> GetAll()
        {
            if (!_loaded)
                throw new NullReferenceException(Properties.strings.Bindings_not_loaded);
            return Bindings;
        }

        public HotkeyBinding Get(int index)
        {
            if (!_loaded)
                throw new NullReferenceException(Properties.strings.Bindings_not_loaded);
            return Bindings[index];
        }

        public void UpdateAt(int index, HotkeyBinding binding)
        {
            if (!_loaded)
                throw new NullReferenceException(Properties.strings.Bindings_not_loaded);

            Bindings[index] = binding;
            Save();

        }

        public void Save(string filePath = "")


        {
            if (!_loaded)
                throw new NullReferenceException(Properties.strings.Bindings_not_loaded);
            if (string.IsNullOrEmpty(filePath))
                filePath = Config.BindingsFilePath;
            
            XmlSerializer xml = new XmlSerializer(typeof(BindingList<HotkeyBinding>));
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write)) {
                xml.Serialize(fs, Bindings);
            }
        }

      

        public void Load(string filePath = "", bool replace = true)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Config.BindingsFilePath;
            }
            if (filePath == Config.BindingsFilePath && !File.Exists(Config.BindingsFilePath))
            {
                _loaded = true;
                Bindings = new BindingList<HotkeyBinding>();
                return;

            }


           
            if (!File.Exists(filePath))
                throw new FileNotFoundException(Properties.strings.File_not_found, filePath);

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(BindingList<HotkeyBinding>));
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    if (replace)
                    {
                        Bindings = (BindingList<HotkeyBinding>)xml.Deserialize(fs);
                    } else
                    {
                        BindingList<HotkeyBinding> newBindings = (BindingList<HotkeyBinding>)xml.Deserialize(fs);
                        foreach(var b in newBindings)
                        {
                            Bindings.Add(b);
                        }

                    }
                    
                    // Cleanup
                    for(int i = Bindings.Count -1; i >= 0; i--)
                    {
                        if (Bindings[i] == null)
                            Bindings.RemoveAt(i);
                    }
                }
            } catch(Exception ex)
            {
                throw;
            } finally
            {
                _loaded = true;
            }

        }

    }
}
