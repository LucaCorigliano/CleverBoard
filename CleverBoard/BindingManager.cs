using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;

namespace CleverBoard
{
    class BindingManager
    {
        public BindingList<Binding> Bindings;

     
        private bool _loaded = false;

        public int Add(Binding binding)
        {
            if (!_loaded)
                throw new NullReferenceException("Bindings not loaded");
            Bindings.Add(binding);
           
            Save();
            return Bindings.IndexOf(binding);
        }
        public void Remove(int index)
        {
            if (!_loaded)
                throw new NullReferenceException("Bindings not loaded");
            Bindings.RemoveAt(index);
            Save();
        }
        public void Remove(Binding binding)
        {
            if (!_loaded)
                throw new NullReferenceException("Bindings not loaded");
            Bindings.Remove(binding);
            Save();
        }

        public IEnumerable<Binding> GetAll()
        {
            if (!_loaded)
                throw new NullReferenceException("Bindings not loaded");
            return Bindings;
        }

        public Binding Get(int index)
        {
            if (!_loaded)
                throw new NullReferenceException("Bindings not loaded");
            return Bindings[index];
        }

        public void UpdateAt(int index, Binding binding)
        {
            if (!_loaded)
                throw new NullReferenceException("Bindings not loaded");

            Bindings[index] = binding;
            Save();

        }

        public void Save(string filePath = "")


        {
            if (!_loaded)
                throw new NullReferenceException("Bindings not loaded");
            if(string.IsNullOrEmpty(filePath))
                filePath = Config.BindingsFilePath;
            
            XmlSerializer xml = new XmlSerializer(typeof(BindingList<Binding>));
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write)) {
                xml.Serialize(fs, Bindings);
            }
        }

      

        public void Load(string filePath = "", bool replace = true)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Config.BindingsFilePath;
            } else if (!File.Exists(Config.BindingsFilePath))
            {
                _loaded = true;
                Bindings = new BindingList<Binding>();
                return;

            }

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(BindingList<Binding>));
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    if (replace)
                    {
                        Bindings = (BindingList<Binding>)xml.Deserialize(fs);
                    } else
                    {
                        BindingList<Binding> newBindings = (BindingList<Binding>)xml.Deserialize(fs);
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
