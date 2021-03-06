﻿namespace Wale.WinForm
{
    partial class Config
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
        public override void InitializeComponent()
        {
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.originalMinPeak = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.averageEnabled = new System.Windows.Forms.CheckBox();
            this.originalAvTime = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.originalFunction = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.originalKurtosis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.originalGCInterval = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.originalACInterval = new System.Windows.Forms.Label();
            this.originalUpRate = new System.Windows.Forms.Label();
            this.originalUIInterval = new System.Windows.Forms.Label();
            this.originalBaseLevel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.detailedView = new System.Windows.Forms.CheckBox();
            this.runAtWindowsStartup = new System.Windows.Forms.CheckBox();
            this.resetToDafault = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit.Location = new System.Drawing.Point(342, 408);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(129, 23);
            this.Submit.TabIndex = 1001;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(9, 408);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(128, 23);
            this.Cancel.TabIndex = 1000;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.originalMinPeak);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.averageEnabled);
            this.groupBox1.Controls.Add(this.originalAvTime);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.originalFunction);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.originalKurtosis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.originalGCInterval);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.originalACInterval);
            this.groupBox1.Controls.Add(this.originalUpRate);
            this.groupBox1.Controls.Add(this.originalUIInterval);
            this.groupBox1.Controls.Add(this.originalBaseLevel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GraphPanel);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(9, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 284);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::Wale.WinForm.Properties.Settings.Default.AutoControl;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Wale.WinForm.Properties.Settings.Default, "AutoControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(224, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 16);
            this.checkBox1.TabIndex = 106;
            this.checkBox1.Text = "Auto Control Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // originalMinPeak
            // 
            this.originalMinPeak.AutoSize = true;
            this.originalMinPeak.Location = new System.Drawing.Point(123, 251);
            this.originalMinPeak.Name = "originalMinPeak";
            this.originalMinPeak.Size = new System.Drawing.Size(8, 12);
            this.originalMinPeak.TabIndex = 105;
            this.originalMinPeak.Text = "l";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(167, 248);
            this.textBox8.MaxLength = 7;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(49, 21);
            this.textBox8.TabIndex = 103;
            this.textBox8.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox8.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 12);
            this.label10.TabIndex = 104;
            this.label10.Text = "Min Peak Level";
            // 
            // averageEnabled
            // 
            this.averageEnabled.AutoSize = true;
            this.averageEnabled.Checked = global::Wale.WinForm.Properties.Settings.Default.Averaging;
            this.averageEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.averageEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Wale.WinForm.Properties.Settings.Default, "Averaging", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.averageEnabled.Location = new System.Drawing.Point(224, 223);
            this.averageEnabled.Name = "averageEnabled";
            this.averageEnabled.Size = new System.Drawing.Size(120, 16);
            this.averageEnabled.TabIndex = 102;
            this.averageEnabled.Text = "Average Enabled";
            this.averageEnabled.UseVisualStyleBackColor = true;
            // 
            // originalAvTime
            // 
            this.originalAvTime.AutoSize = true;
            this.originalAvTime.Location = new System.Drawing.Point(123, 224);
            this.originalAvTime.Name = "originalAvTime";
            this.originalAvTime.Size = new System.Drawing.Size(8, 12);
            this.originalAvTime.TabIndex = 24;
            this.originalAvTime.Text = "l";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(167, 221);
            this.textBox7.MaxLength = 7;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(49, 21);
            this.textBox7.TabIndex = 22;
            this.textBox7.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox7.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "Average Time [s]";
            // 
            // originalFunction
            // 
            this.originalFunction.AutoSize = true;
            this.originalFunction.Location = new System.Drawing.Point(65, 200);
            this.originalFunction.Name = "originalFunction";
            this.originalFunction.Size = new System.Drawing.Size(8, 12);
            this.originalFunction.TabIndex = 21;
            this.originalFunction.Text = "l";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 122);
            this.textBox5.MaxLength = 7;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 21);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.UpRate_Changed);
            this.textBox5.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox5.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // originalKurtosis
            // 
            this.originalKurtosis.AutoSize = true;
            this.originalKurtosis.Location = new System.Drawing.Point(123, 152);
            this.originalKurtosis.Name = "originalKurtosis";
            this.originalKurtosis.Size = new System.Drawing.Size(8, 12);
            this.originalKurtosis.TabIndex = 20;
            this.originalKurtosis.Text = "l";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Level";
            // 
            // originalGCInterval
            // 
            this.originalGCInterval.AutoSize = true;
            this.originalGCInterval.Location = new System.Drawing.Point(123, 71);
            this.originalGCInterval.Name = "originalGCInterval";
            this.originalGCInterval.Size = new System.Drawing.Size(8, 12);
            this.originalGCInterval.TabIndex = 19;
            this.originalGCInterval.Text = "l";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(167, 95);
            this.textBox4.MaxLength = 7;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 21);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.BaseLevel_Changed);
            this.textBox4.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Up Rate";
            // 
            // originalACInterval
            // 
            this.originalACInterval.AutoSize = true;
            this.originalACInterval.Location = new System.Drawing.Point(123, 44);
            this.originalACInterval.Name = "originalACInterval";
            this.originalACInterval.Size = new System.Drawing.Size(8, 12);
            this.originalACInterval.TabIndex = 18;
            this.originalACInterval.Text = "l";
            // 
            // originalUpRate
            // 
            this.originalUpRate.AutoSize = true;
            this.originalUpRate.Location = new System.Drawing.Point(123, 125);
            this.originalUpRate.Name = "originalUpRate";
            this.originalUpRate.Size = new System.Drawing.Size(8, 12);
            this.originalUpRate.TabIndex = 16;
            this.originalUpRate.Text = "l";
            // 
            // originalUIInterval
            // 
            this.originalUIInterval.AutoSize = true;
            this.originalUIInterval.Location = new System.Drawing.Point(123, 17);
            this.originalUIInterval.Name = "originalUIInterval";
            this.originalUIInterval.Size = new System.Drawing.Size(8, 12);
            this.originalUIInterval.TabIndex = 17;
            this.originalUIInterval.Text = "l";
            // 
            // originalBaseLevel
            // 
            this.originalBaseLevel.AutoSize = true;
            this.originalBaseLevel.Location = new System.Drawing.Point(123, 98);
            this.originalBaseLevel.Name = "originalBaseLevel";
            this.originalBaseLevel.Size = new System.Drawing.Size(8, 12);
            this.originalBaseLevel.TabIndex = 15;
            this.originalBaseLevel.Text = "l";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Function_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Function";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(167, 149);
            this.textBox6.MaxLength = 7;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 21);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextChanged += new System.EventHandler(this.Kurtosis_Changed);
            this.textBox6.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox6.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kurtosis";
            // 
            // GraphPanel
            // 
            this.GraphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphPanel.Location = new System.Drawing.Point(224, 14);
            this.GraphPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(230, 198);
            this.GraphPanel.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 68);
            this.textBox3.MaxLength = 7;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 21);
            this.textBox3.TabIndex = 3;
            this.textBox3.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "GC Interval [ms]";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 41);
            this.textBox2.MaxLength = 7;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Auto Control [ms]";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 14);
            this.textBox1.MaxLength = 7;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.textBoxesFocus_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForDigits_KeyPress);
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textboxes_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "UI Update [ms]";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.detailedView);
            this.groupBox2.Controls.Add(this.runAtWindowsStartup);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(9, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 70);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 16);
            this.checkBox2.TabIndex = 102;
            this.checkBox2.Text = "Detailed Log";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // detailedView
            // 
            this.detailedView.AutoSize = true;
            this.detailedView.Checked = global::Wale.WinForm.Properties.Settings.Default.DetailedView;
            this.detailedView.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Wale.WinForm.Properties.Settings.Default, "DetailedView", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.detailedView.Location = new System.Drawing.Point(224, 20);
            this.detailedView.Name = "detailedView";
            this.detailedView.Size = new System.Drawing.Size(101, 16);
            this.detailedView.TabIndex = 101;
            this.detailedView.Text = "Detailed View";
            this.detailedView.UseVisualStyleBackColor = true;
            // 
            // runAtWindowsStartup
            // 
            this.runAtWindowsStartup.AutoSize = true;
            this.runAtWindowsStartup.Location = new System.Drawing.Point(6, 20);
            this.runAtWindowsStartup.Name = "runAtWindowsStartup";
            this.runAtWindowsStartup.Size = new System.Drawing.Size(158, 16);
            this.runAtWindowsStartup.TabIndex = 100;
            this.runAtWindowsStartup.Text = "Run at Windows Startup";
            this.runAtWindowsStartup.UseVisualStyleBackColor = true;
            // 
            // resetToDafault
            // 
            this.resetToDafault.Location = new System.Drawing.Point(170, 408);
            this.resetToDafault.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.resetToDafault.Name = "resetToDafault";
            this.resetToDafault.Size = new System.Drawing.Size(139, 23);
            this.resetToDafault.TabIndex = 1002;
            this.resetToDafault.Text = "Reset To Default";
            this.resetToDafault.UseVisualStyleBackColor = true;
            this.resetToDafault.Click += new System.EventHandler(this.resetToDafault_Click);
            // 
            // Config
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(480, 443);
            this.ControlBox = false;
            this.Controls.Add(this.resetToDafault);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::Wale.WinForm.Properties.Settings.Default, "AlwaysTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Config";
            this.TopMost = global::Wale.WinForm.Properties.Settings.Default.AlwaysTop;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox runAtWindowsStartup;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label originalKurtosis;
        private System.Windows.Forms.Label originalGCInterval;
        private System.Windows.Forms.Label originalACInterval;
        private System.Windows.Forms.Label originalUIInterval;
        private System.Windows.Forms.Label originalUpRate;
        private System.Windows.Forms.Label originalBaseLevel;
        private System.Windows.Forms.Label originalFunction;
        private System.Windows.Forms.CheckBox detailedView;
        private System.Windows.Forms.Label originalAvTime;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox averageEnabled;
        private System.Windows.Forms.Label originalMinPeak;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button resetToDafault;
    }
}