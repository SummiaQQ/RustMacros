//https://github.com/SummiaQQ

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SummiaQQ_MacrosRust
{
    public partial class Form1 : Form
    {
        System.Random rnd;
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {

                if (m.WParam.ToInt32() == 1)
                {
                    Aka_47.Enabled = !Aka_47.Enabled;
                    LR_300.Enabled = false;
                    Tommy_Gun.Enabled = false;
                    MP5K.Enabled = false;
                }
                else
                {
                    Aka_47.Enabled = false;
                }

                if (m.WParam.ToInt32() == 2)
                {

                    LR_300.Enabled = !LR_300.Enabled;
                    Aka_47.Enabled = false;
                    Tommy_Gun.Enabled = false;
                    MP5K.Enabled = false;
                }
                else
                {
                    LR_300.Enabled = false;
                }

                if (m.WParam.ToInt32() == 3)
                {

                    Tommy_Gun.Enabled = !Tommy_Gun.Enabled;
                    Aka_47.Enabled = false;
                    LR_300.Enabled = false;
                    MP5K.Enabled = false;
                }
                else
                {
                    Tommy_Gun.Enabled = false;
                }

                if (m.WParam.ToInt32() == 4)
                {

                    MP5K.Enabled = !MP5K.Enabled;
                    Aka_47.Enabled = false;
                    LR_300.Enabled = false;
                    Tommy_Gun.Enabled = false;
                }
                else
                {
                    MP5K.Enabled = false;
                }

            }
            base.WndProc(ref m);
        }
        public Form1()
        {
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            rnd = new System.Random();
            InitializeComponent();
            RegisterHotKey(Handle, 1, 0, (int)Keys.NumPad0);
            RegisterHotKey(Handle, 2, 0, (int)Keys.NumPad1);
            RegisterHotKey(Handle, 3, 0, (int)Keys.NumPad2);
            RegisterHotKey(Handle, 4, 0, (int)Keys.NumPad3);
            
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, IntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int keys);

        [Flags]
        public enum MOUSEEVENTF
        {
            MOVE = 0x01,
            LEFTDOWN = 0x02,
            LEFTUP = 0x04,
            RIGHTDOWN = 0x08,
            RIGHTUP = 0x10
        }

        private void Aka_47_Tick(object sender, EventArgs e)
        {

            if (GetAsyncKeyState(1) >= 0)
                return;

            mouse_event((uint)MOUSEEVENTF.MOVE, 0, 0, 0, IntPtr.Zero);

            Thread.Sleep(50);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value = rnd.Next(-27, -25);
            mouse_event((uint)MOUSEEVENTF.MOVE, value, 38, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_2 = rnd.Next(34, 36);
            mouse_event((uint)MOUSEEVENTF.MOVE, 4, value_2, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_3 = rnd.Next(-43, -41);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_3, 32, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_4 = rnd.Next(-34, -32);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_4, 29, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_5 = rnd.Next(25, 27);
            mouse_event((uint)MOUSEEVENTF.MOVE, -1, value_5, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_6 = rnd.Next(21, 23);
            mouse_event((uint)MOUSEEVENTF.MOVE, 13, value_6, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_7 = rnd.Next(22, 24);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_7, 19, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_8 = rnd.Next(14, 16);
            mouse_event((uint)MOUSEEVENTF.MOVE, 28, value_8, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_9 = rnd.Next(32, 34);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_9, 11, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_10 = rnd.Next(7, 9);
            mouse_event((uint)MOUSEEVENTF.MOVE, 33, value_10, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_11 = rnd.Next(28, 30);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_11, 9, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_12 = rnd.Next(13, 15);
            mouse_event((uint)MOUSEEVENTF.MOVE, 23, value_12, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_13 = rnd.Next(13, 15);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_13, 20, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_14 = rnd.Next(24, 26);
            mouse_event((uint)MOUSEEVENTF.MOVE, 2, value_14, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_15 = rnd.Next(-13, -11);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_15, 26, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_16 = rnd.Next(26, 28);
            mouse_event((uint)MOUSEEVENTF.MOVE, -21, value_16, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_17 = rnd.Next(-30, -28);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_17, 28, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_18 = rnd.Next(24, 26);
            mouse_event((uint)MOUSEEVENTF.MOVE, -35, value_18, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_19 = rnd.Next(21, 23);
            mouse_event((uint)MOUSEEVENTF.MOVE, -37, value_19, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_20 = rnd.Next(-35, -33);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_20, 0, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_21 = rnd.Next(-32, -30);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_21, 6, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_22 = rnd.Next(2, 4);
            mouse_event((uint)MOUSEEVENTF.MOVE, -27, value_22, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_23 = rnd.Next(-20, -18);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_23, 12, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_24 = rnd.Next(15, 17);
            mouse_event((uint)MOUSEEVENTF.MOVE, -9, value_24, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_25 = rnd.Next(19, 21);
            mouse_event((uint)MOUSEEVENTF.MOVE, 10, value_25, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_26 = rnd.Next(27, 29);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_26, 20, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_27 = rnd.Next(22, 24);
            mouse_event((uint)MOUSEEVENTF.MOVE, 37, value_27, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_28 = rnd.Next(19, 21);
            mouse_event((uint)MOUSEEVENTF.MOVE, 37, value_28, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_29 = rnd.Next(28, 30);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_29, 16, 0, IntPtr.Zero);

            Thread.Sleep(131);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_30 = rnd.Next(12, 13);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_30, 10, 0, IntPtr.Zero);

            Thread.Sleep(131);
        }

        //------------------------------------------------------------


        private void LR_300_Tick(object sender, EventArgs e)
        {

            if (GetAsyncKeyState(1) >= 0)
                return;

            mouse_event((uint)MOUSEEVENTF.MOVE, 0, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x32);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value = rnd.Next(17, 19);
            mouse_event((uint)MOUSEEVENTF.MOVE, -3, value, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_2 = rnd.Next(-6, -4);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_2, 23, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_3 = rnd.Next(24, 26);
            mouse_event((uint)MOUSEEVENTF.MOVE, -7, value_3, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_4 = rnd.Next(-12, -10);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_4, 24, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_5 = rnd.Next(19, 21);
            mouse_event((uint)MOUSEEVENTF.MOVE, -13, value_5, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_6 = rnd.Next(-12, -10);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_6, 16, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_7 = rnd.Next(13, 15);
            mouse_event((uint)MOUSEEVENTF.MOVE, -7, value_7, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_8 = rnd.Next(10, 12);
            mouse_event((uint)MOUSEEVENTF.MOVE, -2, value_8, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_9 = rnd.Next(6, 8);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_9, 10, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_10 = rnd.Next(8, 10);
            mouse_event((uint)MOUSEEVENTF.MOVE, 13, value_10, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_11 = rnd.Next(14, 16);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_11, 6, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_12 = rnd.Next(5, 7);
            mouse_event((uint)MOUSEEVENTF.MOVE, 14, value_12, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_13 = rnd.Next(7, 9);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_13, 4, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_14 = rnd.Next(3, 5);
            mouse_event((uint)MOUSEEVENTF.MOVE, -1, value_14, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_15 = rnd.Next(-5, -3);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_15, 4, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_16 = rnd.Next(2, 4);
            mouse_event((uint)MOUSEEVENTF.MOVE, -7, value_16, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_17 = rnd.Next(-11, -9);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_17, 2, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_18 = rnd.Next(2, 4);
            mouse_event((uint)MOUSEEVENTF.MOVE, -11, value_18, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_19 = rnd.Next(-12, -10);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_19, 2, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_20 = rnd.Next(1, 3);
            mouse_event((uint)MOUSEEVENTF.MOVE, -12, value_20, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_21 = rnd.Next(-13, -11);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_21, 2, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_22 = rnd.Next(2, 4);
            mouse_event((uint)MOUSEEVENTF.MOVE, -11, value_22, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_23 = rnd.Next(-9, -7);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_23, 1, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_24 = rnd.Next(2, 4);
            mouse_event((uint)MOUSEEVENTF.MOVE, -6, value_24, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_25 = rnd.Next(-3, -1);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_25, 2, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_26 = rnd.Next(1, 3);
            mouse_event((uint)MOUSEEVENTF.MOVE, 10, value_26, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_27 = rnd.Next(23, 25);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_27, 2, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_28 = rnd.Next(2, 4);
            mouse_event((uint)MOUSEEVENTF.MOVE, 28, value_28, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_29 = rnd.Next(22, 24);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_29, 2, 0, IntPtr.Zero);


            Thread.Sleep(0x7E);
        }

        private void Tommy_Gun_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(1) >= 0)
                return;

            mouse_event((uint)MOUSEEVENTF.MOVE, 0, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x32);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_1 = rnd.Next(-13, -11);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_1, 22, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_2 = rnd.Next(22, 24);
            mouse_event((uint)MOUSEEVENTF.MOVE, -5, value_2, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_3 = rnd.Next(1, 3);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_3, 22, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_4 = rnd.Next(20, 22);
            mouse_event((uint)MOUSEEVENTF.MOVE, 8, value_4, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_5 = rnd.Next(8, 10);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_5, 19, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_6 = rnd.Next(15, 17);
            mouse_event((uint)MOUSEEVENTF.MOVE, 8, value_6, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_7 = rnd.Next(1, 3);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_7, 14, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_8 = rnd.Next(11, 13);
            mouse_event((uint)MOUSEEVENTF.MOVE, -6, value_8, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_9 = rnd.Next(-10, -8);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_9, 10, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_10 = rnd.Next(9, 11);
            mouse_event((uint)MOUSEEVENTF.MOVE, -10, value_10, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_11 = rnd.Next(-6, -4);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_11, 9, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_12 = rnd.Next(7, 9);
            mouse_event((uint)MOUSEEVENTF.MOVE, 2, value_12, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_13 = rnd.Next(6, 8);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_13, 7, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_14 = rnd.Next(5, 7);
            mouse_event((uint)MOUSEEVENTF.MOVE, 9, value_14, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_15 = rnd.Next(7, 9);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_15, 6, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_16 = rnd.Next(4, 6);
            mouse_event((uint)MOUSEEVENTF.MOVE, 4, value_16, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_17 = rnd.Next(-3, -1);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_17, 5, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_18 = rnd.Next(4, 6);
            mouse_event((uint)MOUSEEVENTF.MOVE, -5, value_18, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_19 = rnd.Next(-7, -5);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_19, 5, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_20 = rnd.Next(3, 5);
            mouse_event((uint)MOUSEEVENTF.MOVE, -2, value_20, 0, IntPtr.Zero);

            Thread.Sleep(0x7E);
        }



        private void MP5K_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(1) >= 0)
                return;

            mouse_event((uint)MOUSEEVENTF.MOVE, 0, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x32);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_1 = rnd.Next(20, 22);
            mouse_event((uint)MOUSEEVENTF.MOVE, -1, value_1, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_2 = rnd.Next(22, 24);
            mouse_event((uint)MOUSEEVENTF.MOVE, 0, value_2, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_3 = rnd.Next(23, 25);
            mouse_event((uint)MOUSEEVENTF.MOVE, 0, value_3, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_4 = rnd.Next(8, 10);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_4, 26, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_5 = rnd.Next(22, 24);
            mouse_event((uint)MOUSEEVENTF.MOVE, 22, value_5, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_6 = rnd.Next(24, 26);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_6, 17, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_7 = rnd.Next(9, 11);
            mouse_event((uint)MOUSEEVENTF.MOVE, 18, value_7, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_8 = rnd.Next(8, 10);
            mouse_event((uint)MOUSEEVENTF.MOVE, 0, value_8, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_9 = rnd.Next(-14, -12);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_9, 7, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_10 = rnd.Next(5, 7);
            mouse_event((uint)MOUSEEVENTF.MOVE, -20, value_10, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_11 = rnd.Next(-16, -14);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_11, 6, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_12 = rnd.Next(4, 6);
            mouse_event((uint)MOUSEEVENTF.MOVE, -3, value_12, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_13 = rnd.Next(6, 8);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_13, 5, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_14 = rnd.Next(3, 5);
            mouse_event((uint)MOUSEEVENTF.MOVE, 10, value_14, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_15 = rnd.Next(12, 14);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_15, 3, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_16 = rnd.Next(2, 4);
            mouse_event((uint)MOUSEEVENTF.MOVE, 13, value_16, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_17 = rnd.Next(9, 11);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_17, 2, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_18 = rnd.Next(0, 2);
            mouse_event((uint)MOUSEEVENTF.MOVE, 4, value_18, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_19 = rnd.Next(1, 3);
            mouse_event((uint)MOUSEEVENTF.MOVE, -1, value_19, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_20 = rnd.Next(-5, -3);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_20, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_21 = rnd.Next(0, 2);
            mouse_event((uint)MOUSEEVENTF.MOVE, -7, value_21, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_22 = rnd.Next(-9, -7);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_22, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_23 = rnd.Next(-11, -9);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_23, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_24 = rnd.Next(-11, -9);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_24, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_25 = rnd.Next(-11, -9);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_25, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_26 = rnd.Next(-11, -9);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_26, -1, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_27 = rnd.Next(-9, -7);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_27, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_28 = rnd.Next(-8, -6);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_28, 0, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
            if (GetAsyncKeyState(1) >= 0)
                return;

            int value_29 = rnd.Next(-7, -5);
            mouse_event((uint)MOUSEEVENTF.MOVE, value_29, -1, 0, IntPtr.Zero);

            Thread.Sleep(0x64);
        }


    }
}
