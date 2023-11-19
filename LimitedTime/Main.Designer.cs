namespace LimitedTime
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.time_numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.type_dropdown = new System.Windows.Forms.ComboBox();
            this.start_button = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.countdown_timer = new System.Windows.Forms.Timer(this.components);
            this.info_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.time_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // time_numeric
            // 
            this.time_numeric.Location = new System.Drawing.Point(17, 55);
            this.time_numeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.time_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.time_numeric.Name = "time_numeric";
            this.time_numeric.Size = new System.Drawing.Size(73, 20);
            this.time_numeric.TabIndex = 1;
            this.time_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set your time";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(13, 158);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(114, 20);
            this.time_label.TabIndex = 4;
            this.time_label.Text = "Timer Disabled";
            // 
            // type_dropdown
            // 
            this.type_dropdown.FormattingEnabled = true;
            this.type_dropdown.Items.AddRange(new object[] {
            "Hour",
            "Minute",
            "Second"});
            this.type_dropdown.Location = new System.Drawing.Point(17, 102);
            this.type_dropdown.Name = "type_dropdown";
            this.type_dropdown.Size = new System.Drawing.Size(121, 21);
            this.type_dropdown.TabIndex = 5;
            this.type_dropdown.TabStop = false;
            this.type_dropdown.Text = "Second";
            this.type_dropdown.SelectedIndexChanged += new System.EventHandler(this.type_changed);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(-180, 806);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 6;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(154, 141);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.stop_clicked);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(157, 176);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(72, 20);
            this.password_textbox.TabIndex = 9;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(154, 102);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_clicked);
            // 
            // countdown_timer
            // 
            this.countdown_timer.Interval = 1000;
            this.countdown_timer.Tick += new System.EventHandler(this.timer_tick);
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_button.Location = new System.Drawing.Point(157, 55);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(75, 23);
            this.info_button.TabIndex = 11;
            this.info_button.Text = "Info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_clicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 216);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.type_dropdown);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_numeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Main";
            this.Text = "Limit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainClosing);
            ((System.ComponentModel.ISupportInitialize)(this.time_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown time_numeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.ComboBox type_dropdown;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer countdown_timer;
        private System.Windows.Forms.Button info_button;
    }
}

