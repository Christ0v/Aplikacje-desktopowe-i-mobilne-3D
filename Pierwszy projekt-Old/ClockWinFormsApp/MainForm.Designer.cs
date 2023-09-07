
namespace ClockWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelClock = new System.Windows.Forms.Label();
            this.buttonReadTime = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.buttonStopWatchStart = new System.Windows.Forms.Button();
            this.buttonStopWatchStop = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.buttonStopWatchDeltaStop = new System.Windows.Forms.Button();
            this.stopWatchDeltaStart = new System.Windows.Forms.Button();
            this.labelStopWatchDelta = new System.Windows.Forms.Label();
            this.timerStopWatchDelta = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(12, 52);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(120, 15);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "Tu pojawi sie godzina";
            // 
            // buttonReadTime
            // 
            this.buttonReadTime.Location = new System.Drawing.Point(12, 111);
            this.buttonReadTime.Name = "buttonReadTime";
            this.buttonReadTime.Size = new System.Drawing.Size(203, 106);
            this.buttonReadTime.TabIndex = 1;
            this.buttonReadTime.Text = "Odczytaj czas";
            this.buttonReadTime.UseVisualStyleBackColor = true;
            this.buttonReadTime.Click += new System.EventHandler(this.buttonReadTime_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Location = new System.Drawing.Point(483, 52);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(90, 15);
            this.labelStopWatch.TabIndex = 2;
            this.labelStopWatch.Text = "labelStopWatch";
            // 
            // buttonStopWatchStart
            // 
            this.buttonStopWatchStart.Location = new System.Drawing.Point(404, 111);
            this.buttonStopWatchStart.Name = "buttonStopWatchStart";
            this.buttonStopWatchStart.Size = new System.Drawing.Size(109, 58);
            this.buttonStopWatchStart.TabIndex = 3;
            this.buttonStopWatchStart.Text = "Start";
            this.buttonStopWatchStart.UseVisualStyleBackColor = true;
            this.buttonStopWatchStart.Click += new System.EventHandler(this.buttonStopWatchStart_Click);
            // 
            // buttonStopWatchStop
            // 
            this.buttonStopWatchStop.Location = new System.Drawing.Point(535, 111);
            this.buttonStopWatchStop.Name = "buttonStopWatchStop";
            this.buttonStopWatchStop.Size = new System.Drawing.Size(111, 58);
            this.buttonStopWatchStop.TabIndex = 4;
            this.buttonStopWatchStop.Text = "Stop";
            this.buttonStopWatchStop.UseVisualStyleBackColor = true;
            this.buttonStopWatchStop.Click += new System.EventHandler(this.buttonStopWatchStop_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1000;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // buttonStopWatchDeltaStop
            // 
            this.buttonStopWatchDeltaStop.Location = new System.Drawing.Point(535, 261);
            this.buttonStopWatchDeltaStop.Name = "buttonStopWatchDeltaStop";
            this.buttonStopWatchDeltaStop.Size = new System.Drawing.Size(111, 58);
            this.buttonStopWatchDeltaStop.TabIndex = 7;
            this.buttonStopWatchDeltaStop.Text = "Stop";
            this.buttonStopWatchDeltaStop.UseVisualStyleBackColor = true;
            this.buttonStopWatchDeltaStop.Click += new System.EventHandler(this.buttonStopWatchDeltaStop_Click);
            // 
            // stopWatchDeltaStart
            // 
            this.stopWatchDeltaStart.Location = new System.Drawing.Point(404, 261);
            this.stopWatchDeltaStart.Name = "stopWatchDeltaStart";
            this.stopWatchDeltaStart.Size = new System.Drawing.Size(109, 58);
            this.stopWatchDeltaStart.TabIndex = 6;
            this.stopWatchDeltaStart.Text = "Start";
            this.stopWatchDeltaStart.UseVisualStyleBackColor = true;
            this.stopWatchDeltaStart.Click += new System.EventHandler(this.stopWatchDeltaStart_Click);
            // 
            // labelStopWatchDelta
            // 
            this.labelStopWatchDelta.AutoSize = true;
            this.labelStopWatchDelta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStopWatchDelta.Location = new System.Drawing.Point(420, 201);
            this.labelStopWatchDelta.Name = "labelStopWatchDelta";
            this.labelStopWatchDelta.Size = new System.Drawing.Size(213, 30);
            this.labelStopWatchDelta.TabIndex = 5;
            this.labelStopWatchDelta.Text = "labelStopWatchDelta";
            // 
            // timerStopWatchDelta
            // 
            this.timerStopWatchDelta.Interval = 1;
            this.timerStopWatchDelta.Tick += new System.EventHandler(this.timerStopWatchDelta_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(751, 439);
            this.Controls.Add(this.buttonStopWatchDeltaStop);
            this.Controls.Add(this.stopWatchDeltaStart);
            this.Controls.Add(this.labelStopWatchDelta);
            this.Controls.Add(this.buttonStopWatchStop);
            this.Controls.Add(this.buttonStopWatchStart);
            this.Controls.Add(this.labelStopWatch);
            this.Controls.Add(this.buttonReadTime);
            this.Controls.Add(this.labelClock);
            this.Name = "MainForm";
            this.Text = "Zegar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button buttonReadTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelStopWatch;
        private System.Windows.Forms.Button buttonStopWatchStart;
        private System.Windows.Forms.Button buttonStopWatchStop;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Button buttonStopWatchDeltaStop;
        private System.Windows.Forms.Button stopWatchDeltaStart;
        private System.Windows.Forms.Label labelStopWatchDelta;
        private System.Windows.Forms.Timer timerStopWatchDelta;
    }
}

