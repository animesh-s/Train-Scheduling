namespace Signals
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SignalConsole = new System.Windows.Forms.TextBox();
            this.InfoConsole = new System.Windows.Forms.TextBox();
            this.TrainTextBox = new System.Windows.Forms.TextBox();
            this.SignalTextBox = new System.Windows.Forms.TextBox();
            this.GapTextBox1 = new System.Windows.Forms.TextBox();
            this.TrainLabel = new System.Windows.Forms.Label();
            this.SignalLabel = new System.Windows.Forms.Label();
            this.GapLabel = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.TimeElapsedLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Clear1 = new System.Windows.Forms.Button();
            this.Clear2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Personalise = new System.Windows.Forms.Button();
            this.ChangeFont = new System.Windows.Forms.RadioButton();
            this.ChangeColour = new System.Windows.Forms.RadioButton();
            this.Change = new System.Windows.Forms.Button();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.TimerComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpectedTimeLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MaxSpeedLabel = new System.Windows.Forms.Label();
            this.RestrictedSpeedLabel = new System.Windows.Forms.Label();
            this.GapSignalsLabel = new System.Windows.Forms.Label();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.ResSpeedTextBox = new System.Windows.Forms.TextBox();
            this.GapSignalsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GapTextBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GapTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(784, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(402, 36);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "SIGNALLING SIMULATOR";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // SignalConsole
            // 
            this.SignalConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignalConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SignalConsole.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignalConsole.Location = new System.Drawing.Point(456, 67);
            this.SignalConsole.Multiline = true;
            this.SignalConsole.Name = "SignalConsole";
            this.SignalConsole.ReadOnly = true;
            this.SignalConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SignalConsole.Size = new System.Drawing.Size(1045, 534);
            this.SignalConsole.TabIndex = 10;
            this.SignalConsole.TextChanged += new System.EventHandler(this.SignalConsole_TextChanged);
            // 
            // InfoConsole
            // 
            this.InfoConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InfoConsole.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.InfoConsole.Location = new System.Drawing.Point(456, 735);
            this.InfoConsole.Multiline = true;
            this.InfoConsole.Name = "InfoConsole";
            this.InfoConsole.ReadOnly = true;
            this.InfoConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoConsole.Size = new System.Drawing.Size(1045, 255);
            this.InfoConsole.TabIndex = 11;
            // 
            // TrainTextBox
            // 
            this.TrainTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TrainTextBox.Location = new System.Drawing.Point(236, 69);
            this.TrainTextBox.Name = "TrainTextBox";
            this.TrainTextBox.Size = new System.Drawing.Size(126, 26);
            this.TrainTextBox.TabIndex = 0;
            this.TrainTextBox.TextChanged += new System.EventHandler(this.TrainTextBox_TextChanged);
            // 
            // SignalTextBox
            // 
            this.SignalTextBox.Location = new System.Drawing.Point(236, 115);
            this.SignalTextBox.Name = "SignalTextBox";
            this.SignalTextBox.Size = new System.Drawing.Size(126, 26);
            this.SignalTextBox.TabIndex = 1;
            // 
            // GapTextBox1
            // 
            this.GapTextBox1.Location = new System.Drawing.Point(236, 253);
            this.GapTextBox1.Name = "GapTextBox1";
            this.GapTextBox1.Size = new System.Drawing.Size(32, 26);
            this.GapTextBox1.TabIndex = 5;
            this.GapTextBox1.Text = "0";
            this.GapTextBox1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TrainLabel
            // 
            this.TrainLabel.AutoSize = true;
            this.TrainLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainLabel.Location = new System.Drawing.Point(39, 67);
            this.TrainLabel.Name = "TrainLabel";
            this.TrainLabel.Size = new System.Drawing.Size(146, 23);
            this.TrainLabel.TabIndex = 24;
            this.TrainLabel.Text = "No. of Trains :";
            // 
            // SignalLabel
            // 
            this.SignalLabel.AutoSize = true;
            this.SignalLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.SignalLabel.Location = new System.Drawing.Point(39, 113);
            this.SignalLabel.Name = "SignalLabel";
            this.SignalLabel.Size = new System.Drawing.Size(156, 23);
            this.SignalLabel.TabIndex = 6;
            this.SignalLabel.Text = "No. of Signals :";
            this.SignalLabel.Click += new System.EventHandler(this.SignalLabel_Click);
            // 
            // GapLabel
            // 
            this.GapLabel.AutoSize = true;
            this.GapLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.GapLabel.Location = new System.Drawing.Point(39, 251);
            this.GapLabel.Name = "GapLabel";
            this.GapLabel.Size = new System.Drawing.Size(171, 23);
            this.GapLabel.TabIndex = 7;
            this.GapLabel.Text = "Gap b/w Trains :";
            // 
            // Done
            // 
            this.Done.AutoSize = true;
            this.Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Done.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(42, 408);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(136, 39);
            this.Done.TabIndex = 12;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Help.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Help.Location = new System.Drawing.Point(226, 408);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(136, 39);
            this.Help.TabIndex = 13;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time Elapsed :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.CurrentTimeLabel.Location = new System.Drawing.Point(207, 489);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(0, 23);
            this.CurrentTimeLabel.TabIndex = 12;
            // 
            // TimeElapsedLabel
            // 
            this.TimeElapsedLabel.AutoSize = true;
            this.TimeElapsedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.TimeElapsedLabel.Location = new System.Drawing.Point(207, 539);
            this.TimeElapsedLabel.Name = "TimeElapsedLabel";
            this.TimeElapsedLabel.Size = new System.Drawing.Size(0, 23);
            this.TimeElapsedLabel.TabIndex = 13;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Start.Enabled = false;
            this.Start.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Start.Location = new System.Drawing.Point(138, 735);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(136, 39);
            this.Start.TabIndex = 14;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Stop.Enabled = false;
            this.Stop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Stop.Location = new System.Drawing.Point(138, 827);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(136, 39);
            this.Stop.TabIndex = 15;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Clear1
            // 
            this.Clear1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear1.AutoSize = true;
            this.Clear1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Clear1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clear1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Clear1.Location = new System.Drawing.Point(1540, 562);
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(136, 39);
            this.Clear1.TabIndex = 16;
            this.Clear1.Text = "Clear";
            this.Clear1.UseVisualStyleBackColor = false;
            this.Clear1.Click += new System.EventHandler(this.Clear1_Click);
            // 
            // Clear2
            // 
            this.Clear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Clear2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Clear2.Location = new System.Drawing.Point(1540, 951);
            this.Clear2.Name = "Clear2";
            this.Clear2.Size = new System.Drawing.Size(136, 39);
            this.Clear2.TabIndex = 17;
            this.Clear2.Text = "Clear";
            this.Clear2.UseVisualStyleBackColor = false;
            this.Clear2.Click += new System.EventHandler(this.Clear2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(39, 967);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Best Viewed in 1920 x 1080";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Personalise
            // 
            this.Personalise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Personalise.AutoSize = true;
            this.Personalise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Personalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Personalise.Location = new System.Drawing.Point(1611, 67);
            this.Personalise.Name = "Personalise";
            this.Personalise.Size = new System.Drawing.Size(136, 39);
            this.Personalise.TabIndex = 19;
            this.Personalise.Text = "Personalise";
            this.Personalise.UseVisualStyleBackColor = false;
            this.Personalise.Click += new System.EventHandler(this.Personalise_Click);
            // 
            // ChangeFont
            // 
            this.ChangeFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeFont.AutoSize = true;
            this.ChangeFont.Location = new System.Drawing.Point(1611, 135);
            this.ChangeFont.Name = "ChangeFont";
            this.ChangeFont.Size = new System.Drawing.Size(125, 22);
            this.ChangeFont.TabIndex = 20;
            this.ChangeFont.TabStop = true;
            this.ChangeFont.Text = "Console Font";
            this.ChangeFont.UseVisualStyleBackColor = true;
            this.ChangeFont.Visible = false;
            // 
            // ChangeColour
            // 
            this.ChangeColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeColour.AutoSize = true;
            this.ChangeColour.Location = new System.Drawing.Point(1611, 181);
            this.ChangeColour.Name = "ChangeColour";
            this.ChangeColour.Size = new System.Drawing.Size(170, 22);
            this.ChangeColour.TabIndex = 21;
            this.ChangeColour.TabStop = true;
            this.ChangeColour.Text = "Background Colour";
            this.ChangeColour.UseVisualStyleBackColor = true;
            this.ChangeColour.Visible = false;
            // 
            // Change
            // 
            this.Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Change.AutoSize = true;
            this.Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Change.Location = new System.Drawing.Point(1653, 222);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(76, 28);
            this.Change.TabIndex = 22;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Visible = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // FontDialog
            // 
            this.FontDialog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontDialog.ShowColor = true;
            // 
            // ColorDialog
            // 
            this.ColorDialog.FullOpen = true;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.TimerLabel.Location = new System.Drawing.Point(39, 343);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(78, 23);
            this.TimerLabel.TabIndex = 23;
            this.TimerLabel.Text = "Timer :";
            // 
            // TimerComboBox
            // 
            this.TimerComboBox.DisplayMember = "(none)";
            this.TimerComboBox.FormattingEnabled = true;
            this.TimerComboBox.Items.AddRange(new object[] {
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec",
            "1 min"});
            this.TimerComboBox.Location = new System.Drawing.Point(236, 345);
            this.TimerComboBox.Name = "TimerComboBox";
            this.TimerComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimerComboBox.Size = new System.Drawing.Size(126, 26);
            this.TimerComboBox.TabIndex = 9;
            this.TimerComboBox.Text = "1 sec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label4.Location = new System.Drawing.Point(246, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Preferably 1 sec";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(39, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Expected Time :";
            // 
            // ExpectedTimeLabel
            // 
            this.ExpectedTimeLabel.AutoSize = true;
            this.ExpectedTimeLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.ExpectedTimeLabel.Location = new System.Drawing.Point(207, 589);
            this.ExpectedTimeLabel.Name = "ExpectedTimeLabel";
            this.ExpectedTimeLabel.Size = new System.Drawing.Size(0, 23);
            this.ExpectedTimeLabel.TabIndex = 27;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(43, 639);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(142, 23);
            this.ProgressBar.TabIndex = 28;
            // 
            // MaxSpeedLabel
            // 
            this.MaxSpeedLabel.AutoSize = true;
            this.MaxSpeedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.MaxSpeedLabel.Location = new System.Drawing.Point(39, 159);
            this.MaxSpeedLabel.Name = "MaxSpeedLabel";
            this.MaxSpeedLabel.Size = new System.Drawing.Size(180, 23);
            this.MaxSpeedLabel.TabIndex = 30;
            this.MaxSpeedLabel.Text = "Maximum Speed :";
            // 
            // RestrictedSpeedLabel
            // 
            this.RestrictedSpeedLabel.AutoSize = true;
            this.RestrictedSpeedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.RestrictedSpeedLabel.Location = new System.Drawing.Point(39, 205);
            this.RestrictedSpeedLabel.Name = "RestrictedSpeedLabel";
            this.RestrictedSpeedLabel.Size = new System.Drawing.Size(185, 23);
            this.RestrictedSpeedLabel.TabIndex = 31;
            this.RestrictedSpeedLabel.Text = "Restricted Speed :";
            // 
            // GapSignalsLabel
            // 
            this.GapSignalsLabel.AutoSize = true;
            this.GapSignalsLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.GapSignalsLabel.Location = new System.Drawing.Point(39, 297);
            this.GapSignalsLabel.Name = "GapSignalsLabel";
            this.GapSignalsLabel.Size = new System.Drawing.Size(181, 23);
            this.GapSignalsLabel.TabIndex = 32;
            this.GapSignalsLabel.Text = "Gap b/w Signals :";
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(236, 161);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(126, 26);
            this.MaxSpeedTextBox.TabIndex = 3;
            // 
            // ResSpeedTextBox
            // 
            this.ResSpeedTextBox.Location = new System.Drawing.Point(236, 207);
            this.ResSpeedTextBox.Name = "ResSpeedTextBox";
            this.ResSpeedTextBox.Size = new System.Drawing.Size(126, 26);
            this.ResSpeedTextBox.TabIndex = 4;
            // 
            // GapSignalsTextBox
            // 
            this.GapSignalsTextBox.Location = new System.Drawing.Point(236, 299);
            this.GapSignalsTextBox.Name = "GapSignalsTextBox";
            this.GapSignalsTextBox.Size = new System.Drawing.Size(126, 26);
            this.GapSignalsTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label3.Location = new System.Drawing.Point(316, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label7.Location = new System.Drawing.Point(368, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "km/hr";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label8.Location = new System.Drawing.Point(368, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "km/hr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label9.Location = new System.Drawing.Point(368, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "km";
            // 
            // GapTextBox3
            // 
            this.GapTextBox3.Location = new System.Drawing.Point(330, 253);
            this.GapTextBox3.Name = "GapTextBox3";
            this.GapTextBox3.Size = new System.Drawing.Size(32, 26);
            this.GapTextBox3.TabIndex = 7;
            this.GapTextBox3.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label10.Location = new System.Drawing.Point(269, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = ":";
            // 
            // GapTextBox2
            // 
            this.GapTextBox2.Location = new System.Drawing.Point(283, 253);
            this.GapTextBox2.Name = "GapTextBox2";
            this.GapTextBox2.Size = new System.Drawing.Size(32, 26);
            this.GapTextBox2.TabIndex = 6;
            this.GapTextBox2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1843, 841);
            this.Controls.Add(this.GapTextBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GapTextBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GapSignalsTextBox);
            this.Controls.Add(this.ResSpeedTextBox);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.GapSignalsLabel);
            this.Controls.Add(this.RestrictedSpeedLabel);
            this.Controls.Add(this.MaxSpeedLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ExpectedTimeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimerComboBox);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.ChangeColour);
            this.Controls.Add(this.ChangeFont);
            this.Controls.Add(this.Personalise);
            this.Controls.Add(this.Clear2);
            this.Controls.Add(this.Clear1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.TimeElapsedLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.GapLabel);
            this.Controls.Add(this.SignalLabel);
            this.Controls.Add(this.TrainLabel);
            this.Controls.Add(this.GapTextBox1);
            this.Controls.Add(this.SignalTextBox);
            this.Controls.Add(this.TrainTextBox);
            this.Controls.Add(this.InfoConsole);
            this.Controls.Add(this.SignalConsole);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Signalling Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox SignalConsole;
        private System.Windows.Forms.TextBox InfoConsole;
        private System.Windows.Forms.TextBox TrainTextBox;
        private System.Windows.Forms.TextBox SignalTextBox;
        private System.Windows.Forms.TextBox GapTextBox1;
        private System.Windows.Forms.Label TrainLabel;
        private System.Windows.Forms.Label SignalLabel;
        private System.Windows.Forms.Label GapLabel;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label TimeElapsedLabel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Clear1;
        private System.Windows.Forms.Button Clear2;
        private System.Windows.Forms.Button Personalise;
        private System.Windows.Forms.RadioButton ChangeFont;
        private System.Windows.Forms.RadioButton ChangeColour;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.ComboBox TimerComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ExpectedTimeLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label MaxSpeedLabel;
        private System.Windows.Forms.Label RestrictedSpeedLabel;
        private System.Windows.Forms.Label GapSignalsLabel;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.TextBox ResSpeedTextBox;
        private System.Windows.Forms.TextBox GapSignalsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GapTextBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GapTextBox2;

    }
}

