using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Input;
using static ReaLTaiizor.Controls.ParrotSwitch;
using NHotkey.WindowsForms;
using NHotkey;
using System.Diagnostics;

namespace DLTrainer
{
    public partial class Form1 : Form
    {

        public Mem m = new Mem();

        bool mouseDown;
        private Point offset;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        



        public Form1()
        {
            
            InitializeComponent();

            //Init Hotkeys
            HotkeyManager.Current.AddOrReplace("F1", Keys.F1, F1_HK);
            HotkeyManager.Current.AddOrReplace("F2", Keys.F2, F2_HK);
            HotkeyManager.Current.AddOrReplace("F3", Keys.F3, F3_HK);
            HotkeyManager.Current.AddOrReplace("F4", Keys.F4, F4_HK);
            HotkeyManager.Current.AddOrReplace("F5", Keys.F5, F5_HK);
            HotkeyManager.Current.AddOrReplace("F6", Keys.F6, F6_HK);
            HotkeyManager.Current.AddOrReplace("F7", Keys.F7, F7_HK);

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.VisibleChanged += (NHA, IsYourDaddykMrBFlat) => this.Update();

        }

        private void F1_HK(object sender, HotkeyEventArgs e)
        {
            if (infHealth_Switch.SwitchState == State.Off)
            {
                infHealth_Switch.SwitchState = State.On;
            }
            else
            {
                infHealth_Switch.SwitchState = State.Off;
            }
            e.Handled = true;
        }

        private void F2_HK(object sender, HotkeyEventArgs e)
        {
            if (infStamina_Switch.SwitchState == State.Off)
            {
                infStamina_Switch.SwitchState = State.On;
            }
            else
            {
                infStamina_Switch.SwitchState = State.Off;
            }
            e.Handled = true;
        }

        private void F3_HK(object sender, HotkeyEventArgs e)
        {
            if (OHK_Switch.SwitchState == State.Off)
            {
                OHK_Switch.SwitchState = State.On;
            }
            else
            {
                OHK_Switch.SwitchState = State.Off;
            }
            e.Handled = true;
        }

        private void F4_HK(object sender, HotkeyEventArgs e)
        {
            if (NoWB_Switch.SwitchState == State.Off)
            {
                NoWB_Switch.SwitchState = State.On;
            }
            else
            {
                NoWB_Switch.SwitchState = State.Off;
            }
            e.Handled = true;
        }

        private void F5_HK(object sender, HotkeyEventArgs e)
        {
            if (NoGrapC_Switch.SwitchState == State.Off)
            {
                NoGrapC_Switch.SwitchState = State.On;
            }
            else
            {
                NoGrapC_Switch.SwitchState = State.Off;
            }
            e.Handled = true;
        }

        private void F6_HK(object sender, HotkeyEventArgs e)
        {
            if (Speed_Switch.SwitchState == State.Off)
            {
                Speed_Switch.SwitchState = State.On;
            }
            else
            {
                Speed_Switch.SwitchState = State.Off;
            }
            e.Handled = true;
        }

        private void F7_HK(object sender, HotkeyEventArgs e)
        {
            Add_Click(sender, e);
        }
        private void W_HK(object sender, HotkeyEventArgs e)
        {
            
               SpeedKeyPressed = true;
        }

        bool SpeedKeyPressed = false;



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        bool ProcOpen = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!BGWorker.IsBusy)
            {
                BGWorker.RunWorkerAsync();
            }

        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            ProcOpen = m.OpenProcess("DyingLightGame");

            Thread.Sleep(300);
            BGWorker.ReportProgress(0);

        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.Text = "[Game is running]";
                ProcOpenLabel.ForeColor = Color.FromArgb(86, 219, 178);

                //Enable Switches if PRoc Open

                if (infHealth_Switch.Enabled != true)
                {
                    infHealth_Switch.Enabled = true;
                }
                if (infStamina_Switch.Enabled != true)
                {
                    infStamina_Switch.Enabled = true;
                }
                if (OHK_Switch.Enabled != true)
                {
                    OHK_Switch.Enabled = true;
                }
                if (NoWB_Switch.Enabled != true)
                {
                    NoWB_Switch.Enabled = true;
                }
                if (NoGrapC_Switch.Enabled != true)
                {
                    NoGrapC_Switch.Enabled = true;
                }
                if (Speed_Switch.Enabled != true)
                {
                    Speed_Switch.Enabled = true;
                }
                if (Add.Enabled != true)
                {
                    Add.Enabled = true;
                }
            }
            else
            {
                ProcOpenLabel.Text = "[Game not running]";
                ProcOpenLabel.ForeColor = Color.FromArgb(185, 63, 14);

                //Disable Switches if Process Not Open
                if (infHealth_Switch.Enabled == true)
                {
                    infHealth_Switch.SwitchState = State.Off;
                    infHealth_Switch.Enabled = false;
                }
                if (infStamina_Switch.Enabled == true)
                {
                    infStamina_Switch.SwitchState = State.Off;
                    infStamina_Switch.Enabled = false;
                }
                if (OHK_Switch.Enabled == true)
                {
                    OHK_Switch.SwitchState = State.Off;
                    OHK_Switch.Enabled = false;
                }
                if (NoWB_Switch.Enabled == true)
                {
                    NoWB_Switch.SwitchState = State.Off;
                    NoWB_Switch.Enabled = false;
                }
                if (NoGrapC_Switch.Enabled == true)
                {
                    NoGrapC_Switch.SwitchState = State.Off;
                    NoGrapC_Switch.Enabled = false;
                }
                if (Speed_Switch.Enabled == true)
                {
                    Speed_Switch.SwitchState = State.Off;
                    Speed_Switch.Enabled = false;
                }
                if (Add.Enabled == true)
                {
                    Add.Enabled = false;
                }
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!BGWorker.IsBusy)
            {
                BGWorker.RunWorkerAsync();
            }
            
        }

        private void infHealth_Switch_SwitchStateChanged(object sender, EventArgs e)
        {
            if (infHealth_Switch.SwitchState == State.On)
            {
                byte[] health1 =
                    {   0xC7,0x87,0x5C,0x12,0x00,0x00,0x00,0x00,0x48,0x43,
                        0x0F,0x2F,0x87,0x5C,0x12,0x00,0x00
                    };
                UIntPtr health1cc = m.CreateCodeCave("gamedll_x64_rwdi.dll+B089BD", health1, 7);

                //byte[] health2 =
                  //  {   0xE9,0xCA,0x25,0x3A,0x01
                  //  };
              //  UIntPtr health2cc = m.CreateCodeCave("gamedll_x64_rwdi.dll+B125C7", health2, 8);
            }
            else
            {
                if (ProcOpen == true)
                m.WriteMemory("gamedll_x64_rwdi.dll+B089BD", "bytes", "0x0F 0x2F 0x87 0x5C 0x12 0x00 0x00");
            }
        }

        private void NoWB_Switch_SwitchStateChanged(object sender, EventArgs e)
        {
            if (NoWB_Switch.SwitchState == State.On)
            {
                byte[] noWB =
                    {   0xC7,0x47,0x04,0x00,0x00,0x48,0x43,
                        0xF3,0x0F,0x10,0x77,0x04
                    };
                UIntPtr noWBcc = m.CreateCodeCave("gamedll_x64_rwdi.dll+672EEC", noWB, 5);


                //gamedll_x64_rwdi.dll+672EEC - F3 0F10 77 04        

                //7FFA52A50000 - C7 47 04 00004843    
                //7FFA52A50007 - F3 0F10 77 04        

            }
            else
            {
                if (ProcOpen == true)
                m.WriteMemory("gamedll_x64_rwdi.dll+672EEC", "bytes", "0xF3 0x0F 0x10 0x77 0x04");
            }
        }

       

        private void OHK_Switch_SwitchStateChanged(object sender, EventArgs e)
        {
            if (OHK_Switch.SwitchState == State.On)
            {
                byte[] ohk =
                    {   0xB8,0x00,0x00,0x00,0x00,
                        0x89,0x43,0x78,
                        0x48,0x8B,0x5C,0x24,0x30
                    };
                UIntPtr ohkcc = m.CreateCodeCave("gamedll_x64_rwdi.dll+464E3", ohk, 8);

                //gamedll_x64_rwdi.dll+464E3 - 89 43 78 48 8B 5C 24 30
                //7FFA4F4E0000 - B8 00000000
                //7FFA4F4E0005 - 89 43 78             
                //7FFA4F4E0008 - 48 8B 5C 24 30

            }
            else
            {
                if (ProcOpen == true)
                    m.WriteMemory("gamedll_x64_rwdi.dll+464E3", "bytes", "0x89 0x43 0x78 0x48 0x8B 0x5C 0x24 0x30");
            }
        }

        private void NoGrapC_Switch_SwitchStateChanged(object sender, EventArgs e)
        {
            if (NoGrapC_Switch.SwitchState == State.On)
            {
                byte[] NoGrapC =
                    {   0x90,0x90,0x90,0x90,0x90,
                    };
                UIntPtr NoGrapCcc = m.CreateCodeCave("gamedll_x64_rwdi.dll+CFF99A", NoGrapC, 5);

                //gamedll_x64_rwdi.dll+CFF99A - F3 0F 11 43 40

            }
            else
            {
                if (ProcOpen == true)
                    m.WriteMemory("gamedll_x64_rwdi.dll+CFF99A", "bytes", "0xF3 0x0F 0x11 0x43 0x40");
            }
        }

        private void infStamina_Switch_SwitchStateChanged(object sender, EventArgs e)
        {
            if (infStamina_Switch.SwitchState == State.On)
            {
                byte[] infStamina =
                    {   0x90,0x90,0x90,0x90,0x90,
                    };
                UIntPtr infStaminacc = m.CreateCodeCave("gamedll_x64_rwdi.dll+C66C17", infStamina, 5);

                //gamedll_x64_rwdi.dll+C66C17 - F3 0F 11 7B 10

            }
            else
            {
                if (ProcOpen == true)
                    m.WriteMemory("gamedll_x64_rwdi.dll+C66C17", "bytes", "0xF3 0x0F 0x11 0x7B 0x10");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ProcOpen)
            {
                string cash_address = "engine_x64_rwdi.dll+00A2F1D8,0x208,0x90,0x80,0x8E0,0x40,0x40";
                int current_cash = m.ReadInt(cash_address) +5000;
                m.WriteMemory(cash_address, "int", current_cash.ToString());
            }
        }

        private void Speed_Switch_SwitchStateChanged(object sender, EventArgs e)
        {
            if (Speed_Switch.SwitchState == State.On)
            {
                byte[] speedhack =
                {   0xC7,0x86,0x10,0x12,0x00,0x00,0x00,0x00,0x70,0x41,
                    };
                UIntPtr speedhackcc = m.CreateCodeCave("gamedll_x64_rwdi.dll+B07A26", speedhack, 9);
            }
            else
            {
                if (ProcOpen == true)
                    m.WriteMemory("gamedll_x64_rwdi.dll+B07A26", "bytes", "0xF3 0x44 0x0F 0x11 0x8E 0x10 0x12 0x00 0x00");
            }
        }
        //gamedll_x64_rwdi.dll+B07A26 - F3 44 0F11 8E 10120000 
        //7FFB61F70000 - C7 86 10120000 00007041



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("discord://https://discord.com/users/181250891683332096");
        }

        
    }
}      

