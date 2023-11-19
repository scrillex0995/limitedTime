using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitedTime
{
    public partial class Main : Form
    {
        public int mulltiplier = 1;
        public int time = 60;
        public string password = "passwrd";

        public Main()
        {
            InitializeComponent();
        }

        private void type_changed(object sender, EventArgs e)
        {
            if (type_dropdown.Text == "Hour")
            {
                mulltiplier = 60 * 60;

            }
            else if (type_dropdown.Text == "Minute")
            {
                mulltiplier = 60;
            }
            else if (type_dropdown.Text == "Second")
            {
                mulltiplier = 1;
            }
            Debug.Print(mulltiplier.ToString());
        }

        private void start_clicked(object sender, EventArgs e)
        {
            time = Convert.ToInt32(time_numeric.Value) * mulltiplier;
            Debug.Print(time.ToString());
            Debug.Print(mulltiplier.ToString());

            var process = new ProcessStartInfo("shutdown", "/s /t " + time.ToString());

            process.CreateNoWindow = true;
            process.UseShellExecute = false;
            
            Process.Start(process);

            countdown_timer.Enabled = true;
            countdown_timer.Start();
            
            startButton.Enabled = false;
            time_numeric.Enabled = false;
            type_dropdown.Enabled = false;

            StopButton.Enabled = true;

            if (password_textbox.Text == "")
            {
                MessageBox.Show("You left password text box blank, the password is: passwrd", "Null Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                password = password_textbox.Text;
            }

            password_textbox.Text = "";
            
        }
        private void stop_clicked(object sender, EventArgs e)
        {
            if (password_textbox.Text == password)
            {
                Process.Start("shutdown", "/a");

                startButton.Enabled = true;
                time_numeric.Enabled = true;
                type_dropdown.Enabled = true;

                StopButton.Enabled = false;

                countdown_timer.Enabled = false;
                countdown_timer.Stop();

                time_label.Text = "Timer Disabled";
            }
            else
            {
                MessageBox.Show("Invalid Password, make sure you do not use CAPSLOCK or Wrong Language", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timer_tick(object sender, EventArgs e)
        {
            time_label.Text = "Time Left: " + time--.ToString();

            if (time < 0) 
            {
                Thread.Sleep(3000);
                this.Close();
            }
        }

        private void info_clicked(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void MainClosing(object sender, FormClosingEventArgs e)
        {
            if(countdown_timer.Enabled == true)
            {
                MessageBox.Show("Stop the timer to close the app", "Unable to Close Windows", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
