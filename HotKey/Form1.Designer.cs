namespace WindowsFormsApp1
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
            this.buttonPauseOrStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPauseOrStart
            // 
            this.buttonPauseOrStart.Location = new System.Drawing.Point(30, 25);
            this.buttonPauseOrStart.Name = "buttonPauseOrStart";
            this.buttonPauseOrStart.Size = new System.Drawing.Size(131, 102);
            this.buttonPauseOrStart.TabIndex = 0;
            this.buttonPauseOrStart.Text = "Pause";
            this.buttonPauseOrStart.UseVisualStyleBackColor = true;
            this.buttonPauseOrStart.Click += new System.EventHandler(this.buttonPauseOrStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 152);
            this.Controls.Add(this.buttonPauseOrStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPauseOrStart;
    }
}

