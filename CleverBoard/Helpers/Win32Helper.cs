using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CleverBoard.Helpers
{
    public static class Win32Helper
    {

        public const int WM_HOTKEY = 0x312;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_SYSKEYDOWN = 0x104;

        public const ushort VK_SHIFT = 0x10;
        public const ushort VK_CONTROL = 0x11;
        public const ushort VK_MENU = 0x12;


        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern uint SendInput(uint inputsCount, Input[] inputs, int inputSize);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern uint SendInput(uint inputsCount, Input inputs, int inputSize);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();



        private static Input CreateCharInput(char ch, bool down, bool unicode = true)
        {
            Input input = new Input();
            input.Type = 1;
            input.ki = new KeyboardInput()
            {
                Vk = (ushort)0,
                Scan = (ushort)ch,
                Time = 0u,
                Flags = unicode ? (down ? 4u : 6u) : (down ? 0u : 2u),
                ExtraInfo = IntPtr.Zero
            };
            return input;
        }

        /*
        private static Input CreateVirtualKeyInput(ushort vk, bool down, bool unicode = false)
        {
            Input input = new Input();
            input.Type = 1;
            input.ki = new KeyboardInput()
            {
                Vk = vk,
                Time = 0u,
                Flags = unicode ? (down ? 4u : 6u) : (down ? 0u : 2u),
                ExtraInfo = IntPtr.Zero
            };
            return input;
        }
        internal static void SendWithModifiers(Keys key, bool ctrl, bool alt, bool shift)
        {
            List<Input> inputList = new List<Input>();
            if (ctrl)
                inputList.Add(CreateVirtualKeyInput(VK_CONTROL, true, false));
            if (alt)
                inputList.Add(CreateVirtualKeyInput(VK_MENU, true, false));
            if (shift)
                inputList.Add(CreateVirtualKeyInput(VK_SHIFT, true, false));


            inputList.Add(CreateVirtualKeyInput((ushort)(key & Keys.KeyCode), true, false));
            inputList.Add(CreateVirtualKeyInput((ushort)(key & Keys.KeyCode), false, false));


            if (ctrl)
                inputList.Add(CreateVirtualKeyInput(VK_CONTROL, false, false));
            if (alt)
                inputList.Add(CreateVirtualKeyInput(VK_MENU, false, false));
            if (shift)
                inputList.Add(CreateVirtualKeyInput(VK_SHIFT, false, false));


            Input[] array = inputList.ToArray();
            SendInput((uint)array.Length, array, Marshal.SizeOf(typeof(Input)));


        }
        */

        internal static void Send(string phrase)
        {
            List<Input> inputList = new List<Input>();
            Input inputDown;
            Input inputUp;
            foreach (char ch in phrase)
            {
                inputDown = CreateCharInput(ch, true);
                inputUp = CreateCharInput(ch, false);
                inputList.Add(inputDown);
                inputList.Add(inputUp);
            }
            Input[] array = inputList.ToArray();
            SendInput((uint)array.Length, array, Marshal.SizeOf(typeof(Input)));
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr handle, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr handle, int id);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        public static extern int GetKeyNameText(uint lParam, [Out] StringBuilder lpString, int nSize);



        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [StructLayout(LayoutKind.Sequential, Size = 24)]
        public struct KeyboardInput
        {
            public ushort Vk;
            public ushort Scan;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Input
        {
            [FieldOffset(0)]
            public int Type;
            [FieldOffset(4)]
            public KeyboardInput ki;
        }


    }
}
