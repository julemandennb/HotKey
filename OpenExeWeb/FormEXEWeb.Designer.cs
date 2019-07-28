namespace OpenExeWeb
{
    partial class FormEXEWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEXEWeb));
            this.textBoxUrlOrPaht = new System.Windows.Forms.TextBox();
            this.buttonPaht = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUrlOrPaht
            // 
            this.textBoxUrlOrPaht.Location = new System.Drawing.Point(12, 25);
            this.textBoxUrlOrPaht.Name = "textBoxUrlOrPaht";
            this.textBoxUrlOrPaht.Size = new System.Drawing.Size(555, 20);
            this.textBoxUrlOrPaht.TabIndex = 0;
            this.textBoxUrlOrPaht.TextChanged += new System.EventHandler(this.textBoxUrlOrPaht_TextChanged);
            // 
            // buttonPaht
            // 
            this.buttonPaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaht.Location = new System.Drawing.Point(573, 25);
            this.buttonPaht.Name = "buttonPaht";
            this.buttonPaht.Size = new System.Drawing.Size(55, 20);
            this.buttonPaht.TabIndex = 1;
            this.buttonPaht.Text = "file";
            this.buttonPaht.UseVisualStyleBackColor = true;
            this.buttonPaht.Click += new System.EventHandler(this.buttonPaht_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "type a url or a path to a exe file";
            // 
            // FormEXEWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 68);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPaht);
            this.Controls.Add(this.textBoxUrlOrPaht);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEXEWeb";
            this.Text = "Set a path or url";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrlOrPaht;
        private System.Windows.Forms.Button buttonPaht;
        private System.Windows.Forms.Label label1;
    }
}