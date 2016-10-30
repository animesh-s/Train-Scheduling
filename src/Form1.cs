using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Signals
{
    public partial class Form1 : Form
    {
        private static int counter = 0, totalTime = 0;
        public static int m, n, gap, intTimer, speedTimer = 1;
        public static bool finished, crashed, input = true, stop = false;
        public static double vM, vR, sD;
        public static string currentTime;
        public float x_ratio, y_ratio;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        /* Takes inputs from the user */
        public void GetInputs()
        {
            input = true;
           
            try
            {
                m = Int32.Parse(TrainTextBox.Text);
            }
            catch (Exception e)
            {
                SignalConsole.AppendText("\r\nError! : " + e.Message);
                SignalConsole.AppendText("\r\nPlease enter the number of trains in the correct format.");
                input = false;
            }

            try
            {
                n = Int32.Parse(SignalTextBox.Text);
            }
            catch (Exception e)
            {
                SignalConsole.AppendText("\r\n\r\nError! : " + e.Message);
                SignalConsole.AppendText("\r\nPlease enter the number of signals in the correct format.");
                input = false;
            }

            try
            {
                if (Int32.Parse(GapTextBox1.Text) < 0 || Int32.Parse(GapTextBox2.Text) < 0 || Int32.Parse(GapTextBox3.Text) < 0)
                {
                    input = false;
                    SignalConsole.AppendText("\r\n\r\n Error! : Please enter possible values in Gap between Trains.");
                }
                else
                {
                    gap = (Int32.Parse(GapTextBox1.Text) * 3600) + (Int32.Parse(GapTextBox2.Text) * 60) + (Int32.Parse(GapTextBox3.Text));
                }
            }
            catch (Exception e)
            {
                SignalConsole.AppendText("\r\n\r\nError! : " + e.Message);
                SignalConsole.AppendText("\r\nPlease enter the gap between trains in the correct format.");
                input = false;
            }

            try
            {
                vM = Double.Parse(MaxSpeedTextBox.Text);
            }
            catch (Exception e)
            {
                SignalConsole.AppendText("\r\n\r\nError! : " + e.Message);
                SignalConsole.AppendText("\r\nPlease enter the maximum speed in the correct format.");
                input = false;
            }

            try
            {
                vR = Double.Parse(ResSpeedTextBox.Text);
            }
            catch (Exception e)
            {
                SignalConsole.AppendText("\r\n\r\nError! : " + e.Message);
                SignalConsole.AppendText("\r\nPlease enter the restricted speed in the correct format.");
                input = false;
            }

            try
            {
                sD = Double.Parse(GapSignalsTextBox.Text);
            }
            catch (Exception e)
            {
                SignalConsole.AppendText("\r\n\r\nError! : " + e.Message);
                SignalConsole.AppendText("\r\nPlease enter the gap between signals in the correct format.");
                input = false;
            }

            try
            {
                if (TimerComboBox.Text == "1 sec")
                {
                    intTimer = 1000;
                    speedTimer = 1;
                }

                if (TimerComboBox.Text == "2 sec")
                {
                    intTimer = 500;
                    speedTimer = 2;
                }

                if (TimerComboBox.Text == "5 sec")
                {
                    intTimer = 200;
                    speedTimer = 5;
                }

                if (TimerComboBox.Text == "10 sec")
                {
                    intTimer = 100;
                    speedTimer = 10;
                }

                if (TimerComboBox.Text == "1 min")
                {
                    intTimer = 17;
                    speedTimer = 60;
                }
            }
            catch (Exception e)
            {
                SignalConsole.AppendText("\r\n\r\nError! : " + e.Message);
                SignalConsole.AppendText("\r\nPlease enter the timer in the correct format.");
                input = false;
            }
        }

        /* Handler for Done Button click */
        private void Done_Click(object sender, EventArgs e)
        {
            SignalConsole.Text = "";
            GetInputs();

            TimeElapsedLabel.Text = "";
            ExpectedTimeLabel.Text = "";
            ProgressBar.Value = 0;

            if (input == true)
            {
                if (m < 1 || n < 1 || gap < 1 || vM <= 0 || vR <= 0 || sD <= 0)
                {
                    Console.Beep();
                    SignalConsole.AppendText("\r\nError! : Please enter possible values in input.");
                    Start.Enabled = false;
                }

                if (vM < vR)
                {
                    Console.Beep();
                    SignalConsole.AppendText("\r\nError! : Maximum Speed should be bigger than Restricted Speed.");
                    Start.Enabled = false;
                }

                else
                {
                    Start.Enabled = true;
                    SignalConsole.AppendText("\r\nPress Start to start the Simulation.");
                }
            }

            else
            {
                Console.Beep();
                Start.Enabled = false;
            }
        }

        /* Handler for Stop Button click */
        private void Stop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Simulation once stopped cannot be resumed.\r\nStop Anyway?", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                UpdateControls(true);
                Stop.Enabled = false;

                stop = true;
            }

            if (result == DialogResult.No)
            {
                
            }
        }

        /* Handler for Start Button click */
        private void Start_Click(object sender, EventArgs e)
        {
            SignalConsole.Text = "";
            UpdateControls(false);
            Stop.Enabled = true;
            Start.Enabled = false;

            counter = 0;
            stop = false;
            
            CalculateTime();
        }

        /*To Update Enable Property of Controls */
        private void UpdateControls(bool value)
        {
            Done.Enabled = value;
            TrainTextBox.Enabled = value;
            SignalTextBox.Enabled = value;
            GapTextBox1.Enabled = value;
            GapTextBox2.Enabled = value;
            GapTextBox3.Enabled = value;
            MaxSpeedTextBox.Enabled = value;
            ResSpeedTextBox.Enabled = value;
            GapSignalsTextBox.Enabled = value;
            TimerComboBox.Enabled = value;
        }

        /* To Calculate Expected Running Time of the Simulator */
        private void CalculateTime()
        {
            Calculate cal = new Calculate(m, n, vM);
            SignalConsole.Text = "\r\nPlease Wait while the Simulator gets things started.";

            System.Timers.Timer timer1 = new System.Timers.Timer(1);
            timer1.Elapsed += (sender, e) => TickEvent1(cal, sender, e);
            timer1.Enabled = true;
        }

        /* Constructs a Trains object and triggers simulation */
        private void StartSimulation()
        {
            /* Constructing a Train object for simulating */
            Trains train = new Trains(m, n, vM);

            SignalConsole.Text = "";
            InfoConsole.AppendText("\r\nSignalling Simulation Started!\r\n");
            ExpectedTimeLabel.Text = (totalTime / 3600).ToString("00") + ":" + ((totalTime / 60) % 60).ToString("00") + ":" + (totalTime % 60).ToString("00");

            /* Constructing a Timer to run the simulator every second */
            System.Timers.Timer timer2 = new System.Timers.Timer(intTimer);
            timer2.Elapsed += (sender, e) => TickEvent2(train, sender, e);
            timer2.Enabled = true;
        }

        /* Handler for Timer tick event */
        private void TickEvent1(Calculate cal, object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer timer = (System.Timers.Timer)sender;
            counter++;

            cal.Simulate(m, n, counter, gap, currentTime, speedTimer, this, vM, vR, sD);
            finished = cal.Finished(m, n, sD);
            crashed = cal.Crashed(m, n, this, sD);

            if (finished)
            {
                timer.Stop();
                totalTime = counter;
                counter = 0;

                StartSimulation();
            }

            if (crashed)
            {
                timer.Stop();
                Stop.Enabled = false;

                DialogResult result = MessageBox.Show("Run Anyway?", "Crash", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    totalTime = counter;
                    counter = 0;

                    StartSimulation();
                }

                if (result == DialogResult.No)
                {
                    Stop.Enabled = false;
                    UpdateControls(true);
                }
            }
        }

        /* Handler for Timer tick event */
        private void TickEvent2(Trains train, object sender, ElapsedEventArgs e)
        {
            currentTime = e.SignalTime.ToString("HH:mm:ss");

            System.Timers.Timer timer = (System.Timers.Timer)sender;
            counter++;
            UpdateProgressBar();

            if (stop == true)
            {
                timer.Stop();
                InfoConsole.AppendText("\r\n\r\nSignalling Simulation Stopped!");
                train.PrintOnStop(m, this);
                Stop.Enabled = false;
                UpdateControls(true);
            }

            if (stop == false)
            {
                train.Simulate(m, n, counter, gap, currentTime, train, speedTimer, this, vM, vR, sD);
                finished = train.Finished(m, n, sD);
                crashed = train.Crashed(m, n, this, sD);

                /* If the simulation finishes */
                if (finished)
                {
                    timer.Stop();
                    train.PrintTime(m, this);
                    Stop.Enabled = false;
                    UpdateControls(true);
                }

                /* If the simulation fails due to a crash between trains */
                if (crashed)
                {
                    timer.Stop();
                    Console.Beep();
                    train.PrintOnStop(m, this);
                    Stop.Enabled = false;
                    UpdateControls(true);
                }
            }
        }

        /*To update the progress bar */
        private void UpdateProgressBar()
        {
            int value = (int)(100 * ((double)counter / totalTime));

            ProgressBar.Value = value;
        }

        /* To use the Form Controls */
        public string CTime
        {
            get
            {
                return CurrentTimeLabel.Text;
            }

            set
            {
                try
                {
                    CurrentTimeLabel.Text = value;
                }
                catch (Exception e)
                {

                }
            }
        }

        public string ETime
        {
            get
            { 
                return TimeElapsedLabel.Text;
            }

            set 
            {
                try
                {
                    TimeElapsedLabel.Text = value;
                }
                catch (Exception e)
                {

                }
            }
        }

        public string SConsole
        {
            get 
            {
                return SignalConsole.Text;
            }

            set
            {
                try
                {
                    SignalConsole.AppendText(value);
                }
                catch (Exception e)
                {

                }
            }
        }

        public string IConsole
        {
            get 
            { 
                return InfoConsole.Text;
            }

            set 
            {
                try
                {
                    InfoConsole.AppendText(value);
                }
                catch (Exception e)
                {

                }
            }
        }

        /* Handler for Help Button click */
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.  No. of Trains : Number of trains (integer) you want to simulate.\r\n\r\n2.  No. of Signals : Number of signals (integer) you want to simulate.\r\n\r\n3.  Maximum Speed : The maximum speed with which the train can run.\r\n\r\n4.  Restricted Speed : The speed to which the train has to slow down or speed up under certain circumstances.\r\n\r\n5.  Gap b/w Trains : The gap (time) between trains at the starting point in the format HH : MM : SS.\r\n\r\n6.  Gap b/w Signals : The uniform gap (kms) between signals.\r\n\r\n7.  Timer : The speed relative to the system timer at which you want to simulate.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Handler for Clear Button click */
        private void Clear1_Click(object sender, EventArgs e)
        {
            SignalConsole.Text = "";
        }

        /* Handler for Clear Button click */
        private void Clear2_Click(object sender, EventArgs e)
        {
            InfoConsole.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer of more than 1 sec may cause problem in printing in the Text Boxes.", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Handler for Personalise Button click */
        private void Personalise_Click(object sender, EventArgs e)
        {
            ChangeFont.Visible = true;
            ChangeColour.Visible = true;
            Change.Visible = true;
            ChangeFont.Checked = false;
            ChangeColour.Checked = false;
        }

        /* Handler for Change Button click */
        private void Change_Click(object sender, EventArgs e)
        {
            if (ChangeColour.Checked == false && ChangeFont.Checked == false)
            {
                MessageBox.Show("Please select either of the two options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ChangeFont.Checked == true)
            {
                DialogResult result = FontDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Font font = FontDialog.Font;

                    SignalConsole.Font = font;
                    InfoConsole.Font = font;
                    SignalConsole.ForeColor = FontDialog.Color;
                    InfoConsole.ForeColor = FontDialog.Color;

                    ChangeFont.Visible = false;
                    ChangeColour.Visible = false;
                    Change.Visible = false;
                }
            }

            if (ChangeColour.Checked == true)
            {
                DialogResult result = ColorDialog.ShowDialog();
          
                if (result == DialogResult.OK)
                {
                    this.BackColor = ColorDialog.Color;

                    ChangeFont.Visible = false;
                    ChangeColour.Visible = false;
                    Change.Visible = false;
                }
            }
        }

        /* To print the current time */
        private void PrintTime()
        {
            System.Timers.Timer timer3 = new System.Timers.Timer(1000);
            timer3.Elapsed += (sender, e) => TickEvent3(sender, e);
            timer3.Enabled = true;
        }

        /* Handler for Timer tick event */
        private void TickEvent3(object sender, ElapsedEventArgs e)
        {
            currentTime = e.SignalTime.ToString("HH:mm:ss");
            System.Timers.Timer timer = (System.Timers.Timer)sender;

            this.CTime = currentTime;
        }

        /* To perform when the Form is loaded */
        private void Form1_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Size = new System.Drawing.Size(width, height);

            x_ratio = ((float)width / 1920);
            y_ratio = ((float)height / 1032);

            SizeF scale = new SizeF(x_ratio, y_ratio);
            this.Scale(scale);

            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.Name, control.Font.Size * x_ratio);
            }

            ResizeControls();
            PrintTime();
        }

        /* To resize the controls on change in resolution of the system */
        private void ResizeControls()
        {
            TitleLabel.Location = new System.Drawing.Point((int)(784 * x_ratio), (int)(9 * y_ratio));
            TitleLabel.Size = new System.Drawing.Size((int)(402 * x_ratio), (int)(36 * y_ratio));
      
            SignalConsole.Location = new System.Drawing.Point((int)(456 * x_ratio), (int)(67 * y_ratio));
            SignalConsole.Size = new System.Drawing.Size((int)(1045 * x_ratio), (int)(534 * y_ratio));

            InfoConsole.Location = new System.Drawing.Point((int)(456 * x_ratio), (int)(735 * y_ratio));
            InfoConsole.Size = new System.Drawing.Size((int)(1045 * x_ratio), (int)(255 * y_ratio));

            TrainTextBox.Location = new System.Drawing.Point((int)(236 * x_ratio), (int)(69 * y_ratio));
            TrainTextBox.Size = new System.Drawing.Size((int)(126 * x_ratio), (int)(26 * y_ratio));

            SignalTextBox.Location = new System.Drawing.Point((int)(236 * x_ratio), (int)(115 * y_ratio));
            SignalTextBox.Size = new System.Drawing.Size((int)(126 * x_ratio), (int)(26 * y_ratio));

            GapTextBox1.Location = new System.Drawing.Point((int)(236 * x_ratio), (int)(253 * y_ratio));
            GapTextBox1.Size = new System.Drawing.Size((int)(32 * x_ratio), (int)(26 * y_ratio));

            GapTextBox2.Location = new System.Drawing.Point((int)(283 * x_ratio), (int)(253 * y_ratio));
            GapTextBox2.Size = new System.Drawing.Size((int)(32 * x_ratio), (int)(26 * y_ratio));

            GapTextBox3.Location = new System.Drawing.Point((int)(330 * x_ratio), (int)(253 * y_ratio));
            GapTextBox3.Size = new System.Drawing.Size((int)(32 * x_ratio), (int)(26 * y_ratio));

            MaxSpeedTextBox.Location = new System.Drawing.Point((int)(236 * x_ratio), (int)(161 * y_ratio));
            MaxSpeedTextBox.Size = new System.Drawing.Size((int)(126 * x_ratio), (int)(26 * y_ratio));

            ResSpeedTextBox.Location = new System.Drawing.Point((int)(236 * x_ratio), (int)(207 * y_ratio));
            ResSpeedTextBox.Size = new System.Drawing.Size((int)(126 * x_ratio), (int)(26 * y_ratio));

            GapSignalsTextBox.Location = new System.Drawing.Point((int)(236 * x_ratio), (int)(299 * y_ratio));
            GapSignalsTextBox.Size = new System.Drawing.Size((int)(126 * x_ratio), (int)(26 * y_ratio));

            TrainLabel.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(67 * y_ratio));
            TrainLabel.Size = new System.Drawing.Size((int)(146 * x_ratio), (int)(23 * y_ratio));

            SignalLabel.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(113 * y_ratio));
            SignalLabel.Size = new System.Drawing.Size((int)(156 * x_ratio), (int)(23 * y_ratio));

            GapLabel.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(251 * y_ratio));
            GapLabel.Size = new System.Drawing.Size((int)(139 * x_ratio), (int)(23 * y_ratio));

            MaxSpeedLabel.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(159 * y_ratio));
            MaxSpeedLabel.Size = new System.Drawing.Size((int)(180 * x_ratio), (int)(23 * y_ratio));

            RestrictedSpeedLabel.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(205 * y_ratio));
            RestrictedSpeedLabel.Size = new System.Drawing.Size((int)(185 * x_ratio), (int)(23 * y_ratio));

            GapSignalsLabel.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(297 * y_ratio));
            GapSignalsLabel.Size = new System.Drawing.Size((int)(181 * x_ratio), (int)(23 * y_ratio));

            Done.Location = new System.Drawing.Point((int)(42 * x_ratio), (int)(408 * y_ratio));
            Done.Size = new System.Drawing.Size((int)(136 * x_ratio), (int)(39 * y_ratio));

            Help.Location = new System.Drawing.Point((int)(226 * x_ratio), (int)(408 * y_ratio));
            Help.Size = new System.Drawing.Size((int)(136 * x_ratio), (int)(39 * y_ratio));

            label1.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(489 * y_ratio));
            label1.Size = new System.Drawing.Size((int)(148 * x_ratio), (int)(23 * y_ratio));

            label2.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(539 * y_ratio));
            label2.Size = new System.Drawing.Size((int)(150 * x_ratio), (int)(23 * y_ratio));

            CurrentTimeLabel.Location = new System.Drawing.Point((int)(207 * x_ratio), (int)(489 * y_ratio));
            CurrentTimeLabel.Size = new System.Drawing.Size((int)(22 * x_ratio), (int)(23 * y_ratio));

            TimeElapsedLabel.Location = new System.Drawing.Point((int)(207 * x_ratio), (int)(539 * y_ratio));
            TimeElapsedLabel.Size = new System.Drawing.Size((int)(22 * x_ratio), (int)(23 * y_ratio));

            Start.Location = new System.Drawing.Point((int)(138 * x_ratio), (int)(735 * y_ratio));
            Start.Size = new System.Drawing.Size((int)(136 * x_ratio), (int)(39 * y_ratio));

            Stop.Location = new System.Drawing.Point((int)(138 * x_ratio), (int)(827 * y_ratio));
            Stop.Size = new System.Drawing.Size((int)(136 * x_ratio), (int)(39 * y_ratio));

            Clear1.Location = new System.Drawing.Point((int)(1540 * x_ratio), (int)(562 * y_ratio));
            Clear1.Size = new System.Drawing.Size((int)(136 * x_ratio), (int)(39 * y_ratio));

            Clear2.Location = new System.Drawing.Point((int)(1540 * x_ratio), (int)(951 * y_ratio));
            Clear2.Size = new System.Drawing.Size((int)(136 * x_ratio), (int)(39 * y_ratio));
           
            Personalise.Location = new System.Drawing.Point((int)(1640 * x_ratio), (int)(67 * y_ratio));
            Personalise.Size = new System.Drawing.Size((int)(136 * x_ratio), (int)(39 * y_ratio));

            ChangeFont.Location = new System.Drawing.Point((int)(1611 * x_ratio), (int)(135 * y_ratio));
            ChangeFont.Size = new System.Drawing.Size((int)(125 * x_ratio), (int)(22 * y_ratio));

            ChangeColour.Location = new System.Drawing.Point((int)(1611 * x_ratio), (int)(181 * y_ratio));
            ChangeColour.Size = new System.Drawing.Size((int)(170 * x_ratio), (int)(22 * y_ratio));
        
            Change.Location = new System.Drawing.Point((int)(1653 * x_ratio), (int)(222 * y_ratio));
            Change.Size = new System.Drawing.Size((int)(76 * x_ratio), (int)(28 * y_ratio));

            TimerLabel.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(343 * y_ratio));
            TimerLabel.Size = new System.Drawing.Size((int)(78 * x_ratio), (int)(23 * y_ratio));
        
            TimerComboBox.Location = new System.Drawing.Point((int)(236 * x_ratio), (int)(345 * y_ratio));
            TimerComboBox.Size = new System.Drawing.Size((int)(126 * x_ratio), (int)(23 * y_ratio));
        
            label4.Location = new System.Drawing.Point((int)(246 * x_ratio), (int)(376 * y_ratio));
            label4.Size = new System.Drawing.Size((int)(105 * x_ratio), (int)(17 * y_ratio));

            label5.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(589 * y_ratio));
            label5.Size = new System.Drawing.Size((int)(163 * x_ratio), (int)(23 * y_ratio));

            label6.Location = new System.Drawing.Point((int)(39 * x_ratio), (int)(967 * y_ratio));
            label6.Size = new System.Drawing.Size((int)(170 * x_ratio), (int)(23 * y_ratio));

            label7.Location = new System.Drawing.Point((int)(368 * x_ratio), (int)(212 * y_ratio));
            label7.Size = new System.Drawing.Size((int)(45 * x_ratio), (int)(17 * y_ratio));

            label8.Location = new System.Drawing.Point((int)(368 * x_ratio), (int)(166 * y_ratio));
            label8.Size = new System.Drawing.Size((int)(45 * x_ratio), (int)(17 * y_ratio));

            label9.Location = new System.Drawing.Point((int)(368 * x_ratio), (int)(304 * y_ratio));
            label9.Size = new System.Drawing.Size((int)(27 * x_ratio), (int)(17 * y_ratio));

            label10.Location = new System.Drawing.Point((int)(269 * x_ratio), (int)(256 * y_ratio));
            label10.Size = new System.Drawing.Size((int)(13 * x_ratio), (int)(17 * y_ratio));

            label3.Location = new System.Drawing.Point((int)(316 * x_ratio), (int)(256 * y_ratio));
            label3.Size = new System.Drawing.Size((int)(13 * x_ratio), (int)(17 * y_ratio));

            ExpectedTimeLabel.Location = new System.Drawing.Point((int)(207 * x_ratio), (int)(589 * y_ratio));
            ExpectedTimeLabel.Size = new System.Drawing.Size((int)(22 * x_ratio), (int)(23 * y_ratio));

            ProgressBar.Location = new System.Drawing.Point((int)(43 * x_ratio), (int)(639 * y_ratio));
            ProgressBar.Size = new System.Drawing.Size((int)(142 * x_ratio), (int)(23 * y_ratio));
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lower Resolutions may cause the font to be printed inappropriably in the console.", "Resolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
           
        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignalConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
