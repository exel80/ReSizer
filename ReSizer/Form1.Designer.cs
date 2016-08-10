namespace ReSizer
{
    partial class ReSizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReSizer));
            this.button1 = new System.Windows.Forms.Button();
            this.program = new System.Windows.Forms.ComboBox();
            this.size = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ReSize ME!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // program
            // 
            this.program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.program.FormattingEnabled = true;
            this.program.Location = new System.Drawing.Point(12, 12);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(229, 21);
            this.program.TabIndex = 1;
            // 
            // size
            // 
            this.size.AccessibleDescription = "";
            this.size.AccessibleName = "";
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.Items.AddRange(new object[] {
            "640x360",
            "720x405",
            "848x480",
            "960x540",
            "1024x576",
            "1280x720",
            "1366x768",
            "1600x900",
            "1920x1080",
            "2048x1152",
            "2560x1152",
            "2560x1440",
            "2880x1620",
            "3200x1800",
            "3840x2160"});
            this.size.Location = new System.Drawing.Point(12, 41);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(148, 21);
            this.size.TabIndex = 2;
            // 
            // ReSizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 78);
            this.Controls.Add(this.size);
            this.Controls.Add(this.program);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReSizer";
            this.Text = "ReSizer 2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.ComboBox size;
    }
}

