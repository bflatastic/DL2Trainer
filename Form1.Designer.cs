namespace DLTrainer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.infHealth_Switch = new ReaLTaiizor.Controls.ParrotSwitch();
            this.infStamina_Switch = new ReaLTaiizor.Controls.ParrotSwitch();
            this.NoWB_Switch = new ReaLTaiizor.Controls.ParrotSwitch();
            this.OHK_Switch = new ReaLTaiizor.Controls.ParrotSwitch();
            this.NoGrapC_Switch = new ReaLTaiizor.Controls.ParrotSwitch();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            this.Add = new ReaLTaiizor.Controls.MetroButton();
            this.Speed_Switch = new ReaLTaiizor.Controls.ParrotSwitch();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(63)))), ((int)(((byte)(14)))));
            this.ProcOpenLabel.Location = new System.Drawing.Point(25, 91);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Padding = new System.Windows.Forms.Padding(4);
            this.ProcOpenLabel.Size = new System.Drawing.Size(165, 27);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "[Game not running]";
            // 
            // infHealth_Switch
            // 
            this.infHealth_Switch.BackColor = System.Drawing.Color.Transparent;
            this.infHealth_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infHealth_Switch.Enabled = false;
            this.infHealth_Switch.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infHealth_Switch.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infHealth_Switch.Location = new System.Drawing.Point(330, 141);
            this.infHealth_Switch.Name = "infHealth_Switch";
            this.infHealth_Switch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.infHealth_Switch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.infHealth_Switch.Size = new System.Drawing.Size(60, 30);
            this.infHealth_Switch.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
            this.infHealth_Switch.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.Horizontal;
            this.infHealth_Switch.TabIndex = 6;
            this.infHealth_Switch.SwitchStateChanged += new System.EventHandler(this.infHealth_Switch_SwitchStateChanged);
            // 
            // infStamina_Switch
            // 
            this.infStamina_Switch.BackColor = System.Drawing.Color.Transparent;
            this.infStamina_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infStamina_Switch.Enabled = false;
            this.infStamina_Switch.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infStamina_Switch.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infStamina_Switch.Location = new System.Drawing.Point(330, 179);
            this.infStamina_Switch.Name = "infStamina_Switch";
            this.infStamina_Switch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.infStamina_Switch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.infStamina_Switch.Size = new System.Drawing.Size(60, 30);
            this.infStamina_Switch.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
            this.infStamina_Switch.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.Horizontal;
            this.infStamina_Switch.TabIndex = 7;
            this.infStamina_Switch.SwitchStateChanged += new System.EventHandler(this.infStamina_Switch_SwitchStateChanged);
            // 
            // NoWB_Switch
            // 
            this.NoWB_Switch.BackColor = System.Drawing.Color.Transparent;
            this.NoWB_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoWB_Switch.Enabled = false;
            this.NoWB_Switch.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NoWB_Switch.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NoWB_Switch.Location = new System.Drawing.Point(330, 255);
            this.NoWB_Switch.Name = "NoWB_Switch";
            this.NoWB_Switch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.NoWB_Switch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.NoWB_Switch.Size = new System.Drawing.Size(60, 30);
            this.NoWB_Switch.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
            this.NoWB_Switch.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.Horizontal;
            this.NoWB_Switch.TabIndex = 9;
            this.NoWB_Switch.SwitchStateChanged += new System.EventHandler(this.NoWB_Switch_SwitchStateChanged);
            // 
            // OHK_Switch
            // 
            this.OHK_Switch.BackColor = System.Drawing.Color.Transparent;
            this.OHK_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OHK_Switch.Enabled = false;
            this.OHK_Switch.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OHK_Switch.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OHK_Switch.Location = new System.Drawing.Point(330, 217);
            this.OHK_Switch.Name = "OHK_Switch";
            this.OHK_Switch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.OHK_Switch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.OHK_Switch.Size = new System.Drawing.Size(60, 30);
            this.OHK_Switch.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
            this.OHK_Switch.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.Horizontal;
            this.OHK_Switch.TabIndex = 8;
            this.OHK_Switch.SwitchStateChanged += new System.EventHandler(this.OHK_Switch_SwitchStateChanged);
            // 
            // NoGrapC_Switch
            // 
            this.NoGrapC_Switch.BackColor = System.Drawing.Color.Transparent;
            this.NoGrapC_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoGrapC_Switch.Enabled = false;
            this.NoGrapC_Switch.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NoGrapC_Switch.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NoGrapC_Switch.Location = new System.Drawing.Point(330, 293);
            this.NoGrapC_Switch.Name = "NoGrapC_Switch";
            this.NoGrapC_Switch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.NoGrapC_Switch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.NoGrapC_Switch.Size = new System.Drawing.Size(60, 30);
            this.NoGrapC_Switch.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
            this.NoGrapC_Switch.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.Horizontal;
            this.NoGrapC_Switch.TabIndex = 10;
            this.NoGrapC_Switch.SwitchStateChanged += new System.EventHandler(this.NoGrapC_Switch_SwitchStateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.foreverMinimize1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.foreverClose1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.EdgeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(422, 86);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 11;
            this.panel1.Text = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // foreverMinimize1
            // 
            this.foreverMinimize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverMinimize1.BackColor = System.Drawing.Color.White;
            this.foreverMinimize1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.foreverMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverMinimize1.DefaultLocation = false;
            this.foreverMinimize1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverMinimize1.Font = new System.Drawing.Font("Marlett", 12F);
            this.foreverMinimize1.Location = new System.Drawing.Point(348, 26);
            this.foreverMinimize1.Name = "foreverMinimize1";
            this.foreverMinimize1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverMinimize1.Size = new System.Drawing.Size(18, 18);
            this.foreverMinimize1.TabIndex = 2;
            this.foreverMinimize1.Text = "foreverMinimize1";
            this.foreverMinimize1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(117)))), ((int)(((byte)(122)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(117)))), ((int)(((byte)(122)))));
            this.linkLabel1.Location = new System.Drawing.Point(30, 66);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by BFlat";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // foreverClose1
            // 
            this.foreverClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverClose1.BackColor = System.Drawing.Color.White;
            this.foreverClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.foreverClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverClose1.DefaultLocation = false;
            this.foreverClose1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.foreverClose1.Location = new System.Drawing.Point(372, 26);
            this.foreverClose1.Margin = new System.Windows.Forms.Padding(10);
            this.foreverClose1.Name = "foreverClose1";
            this.foreverClose1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverClose1.Size = new System.Drawing.Size(18, 18);
            this.foreverClose1.TabIndex = 0;
            this.foreverClose1.Text = "foreverClose1";
            this.foreverClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Add
            // 
            this.Add.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.Add.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.Add.DisabledForeColor = System.Drawing.Color.Gray;
            this.Add.Enabled = false;
            this.Add.Font = new System.Drawing.Font("Rubik", 8F, System.Drawing.FontStyle.Bold);
            this.Add.HoverBorderColor = System.Drawing.Color.Transparent;
            this.Add.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.Add.HoverTextColor = System.Drawing.Color.White;
            this.Add.IsDerivedStyle = true;
            this.Add.Location = new System.Drawing.Point(331, 374);
            this.Add.Name = "Add";
            this.Add.NormalBorderColor = System.Drawing.Color.Transparent;
            this.Add.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.Add.NormalTextColor = System.Drawing.Color.White;
            this.Add.PressBorderColor = System.Drawing.Color.Transparent;
            this.Add.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.Add.PressTextColor = System.Drawing.Color.White;
            this.Add.Size = new System.Drawing.Size(60, 21);
            this.Add.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.Add.StyleManager = null;
            this.Add.TabIndex = 12;
            this.Add.Text = "ADD";
            this.Add.ThemeAuthor = "Taiizor";
            this.Add.ThemeName = "MetroLight";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Speed_Switch
            // 
            this.Speed_Switch.BackColor = System.Drawing.Color.Transparent;
            this.Speed_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Speed_Switch.Enabled = false;
            this.Speed_Switch.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Speed_Switch.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Speed_Switch.Location = new System.Drawing.Point(330, 329);
            this.Speed_Switch.Name = "Speed_Switch";
            this.Speed_Switch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.Speed_Switch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.Speed_Switch.Size = new System.Drawing.Size(60, 30);
            this.Speed_Switch.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
            this.Speed_Switch.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.Horizontal;
            this.Speed_Switch.TabIndex = 13;
            this.Speed_Switch.SwitchStateChanged += new System.EventHandler(this.Speed_Switch_SwitchStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DLTrainer.Properties.Resources.DLbg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(422, 427);
            this.Controls.Add(this.Speed_Switch);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoGrapC_Switch);
            this.Controls.Add(this.NoWB_Switch);
            this.Controls.Add(this.OHK_Switch);
            this.Controls.Add(this.infStamina_Switch);
            this.Controls.Add(this.infHealth_Switch);
            this.Controls.Add(this.ProcOpenLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Inter", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Dying Light Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label ProcOpenLabel;
        private ReaLTaiizor.Controls.ParrotSwitch infHealth_Switch;
        private ReaLTaiizor.Controls.ParrotSwitch infStamina_Switch;
        private ReaLTaiizor.Controls.ParrotSwitch NoWB_Switch;
        private ReaLTaiizor.Controls.ParrotSwitch OHK_Switch;
        private ReaLTaiizor.Controls.ParrotSwitch NoGrapC_Switch;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.MetroButton Add;
        private ReaLTaiizor.Controls.ParrotSwitch Speed_Switch;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
    }
}

