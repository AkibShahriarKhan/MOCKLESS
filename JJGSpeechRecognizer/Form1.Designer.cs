namespace JJGSpeechRecognizer
{
    partial class SpeechGUI
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
            this.LBLSpeechTextOut = new System.Windows.Forms.Label();
            this.LBLListening = new System.Windows.Forms.Label();
            this.LBL3CurrentTask = new System.Windows.Forms.Label();
            this.LBL4CurrentTaskOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNStart = new System.Windows.Forms.PictureBox();
            this.BTNStop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNStop)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLSpeechTextOut
            // 
            this.LBLSpeechTextOut.AutoSize = true;
            this.LBLSpeechTextOut.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LBLSpeechTextOut.Location = new System.Drawing.Point(9, 32);
            this.LBLSpeechTextOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLSpeechTextOut.Name = "LBLSpeechTextOut";
            this.LBLSpeechTextOut.Size = new System.Drawing.Size(54, 13);
            this.LBLSpeechTextOut.TabIndex = 2;
            this.LBLSpeechTextOut.Text = "Command";
            // 
            // LBLListening
            // 
            this.LBLListening.AutoSize = true;
            this.LBLListening.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LBLListening.Location = new System.Drawing.Point(9, 7);
            this.LBLListening.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLListening.Name = "LBLListening";
            this.LBLListening.Size = new System.Drawing.Size(49, 13);
            this.LBLListening.TabIndex = 3;
            this.LBLListening.Text = "Listening";
            // 
            // LBL3CurrentTask
            // 
            this.LBL3CurrentTask.AutoSize = true;
            this.LBL3CurrentTask.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LBL3CurrentTask.Location = new System.Drawing.Point(118, 7);
            this.LBL3CurrentTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL3CurrentTask.Name = "LBL3CurrentTask";
            this.LBL3CurrentTask.Size = new System.Drawing.Size(68, 13);
            this.LBL3CurrentTask.TabIndex = 5;
            this.LBL3CurrentTask.Text = "Current Task";
            // 
            // LBL4CurrentTaskOut
            // 
            this.LBL4CurrentTaskOut.AutoSize = true;
            this.LBL4CurrentTaskOut.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LBL4CurrentTaskOut.Location = new System.Drawing.Point(118, 32);
            this.LBL4CurrentTaskOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL4CurrentTaskOut.Name = "LBL4CurrentTaskOut";
            this.LBL4CurrentTaskOut.Size = new System.Drawing.Size(68, 13);
            this.LBL4CurrentTaskOut.TabIndex = 4;
            this.LBL4CurrentTaskOut.Text = "Current Task";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JJGSpeechRecognizer.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(263, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTNStart
            // 
            this.BTNStart.Image = global::JJGSpeechRecognizer.Properties.Resources.play;
            this.BTNStart.Location = new System.Drawing.Point(220, 10);
            this.BTNStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(38, 41);
            this.BTNStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNStart.TabIndex = 0;
            this.BTNStart.TabStop = false;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            // 
            // BTNStop
            // 
            this.BTNStop.Image = global::JJGSpeechRecognizer.Properties.Resources.Pause;
            this.BTNStop.Location = new System.Drawing.Point(220, 10);
            this.BTNStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNStop.Name = "BTNStop";
            this.BTNStop.Size = new System.Drawing.Size(38, 41);
            this.BTNStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNStop.TabIndex = 1;
            this.BTNStop.TabStop = false;
            this.BTNStop.Click += new System.EventHandler(this.BTNStop_Click);
            // 
            // SpeechGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(304, 59);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL3CurrentTask);
            this.Controls.Add(this.LBL4CurrentTaskOut);
            this.Controls.Add(this.LBLListening);
            this.Controls.Add(this.BTNStart);
            this.Controls.Add(this.LBLSpeechTextOut);
            this.Controls.Add(this.BTNStop);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 300);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SpeechGUI";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "JJGSpeechRecognizer";
            this.Load += new System.EventHandler(this.SpeechGUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeechGUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SpeechGUI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpeechGUI_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BTNStart;
        private System.Windows.Forms.PictureBox BTNStop;
        public System.Windows.Forms.Label LBLSpeechTextOut;
        public System.Windows.Forms.Label LBLListening;
        public System.Windows.Forms.Label LBL3CurrentTask;
        public System.Windows.Forms.Label LBL4CurrentTaskOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

