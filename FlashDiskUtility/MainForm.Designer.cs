namespace FlashDiskUtility
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourcePath_Box = new System.Windows.Forms.TextBox();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.AvailableDrives_Combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Output_Box = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flash Disk Yolu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Yolu:";
            // 
            // SourcePath_Box
            // 
            this.SourcePath_Box.Location = new System.Drawing.Point(121, 47);
            this.SourcePath_Box.Name = "SourcePath_Box";
            this.SourcePath_Box.Size = new System.Drawing.Size(334, 20);
            this.SourcePath_Box.TabIndex = 4;
            // 
            // Browse_Button
            // 
            this.Browse_Button.Location = new System.Drawing.Point(461, 45);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(75, 23);
            this.Browse_Button.TabIndex = 5;
            this.Browse_Button.Text = "Gözat";
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(461, 102);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 6;
            this.Start_Button.Text = "Başlat";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // AvailableDrives_Combo
            // 
            this.AvailableDrives_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableDrives_Combo.FormattingEnabled = true;
            this.AvailableDrives_Combo.Location = new System.Drawing.Point(121, 18);
            this.AvailableDrives_Combo.Name = "AvailableDrives_Combo";
            this.AvailableDrives_Combo.Size = new System.Drawing.Size(132, 21);
            this.AvailableDrives_Combo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output_Box
            // 
            this.Output_Box.Location = new System.Drawing.Point(12, 131);
            this.Output_Box.Multiline = true;
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.Size = new System.Drawing.Size(524, 187);
            this.Output_Box.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 330);
            this.Controls.Add(this.Output_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvailableDrives_Combo);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.SourcePath_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Disk Hazırlayıcı - v0.0.3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourcePath_Box;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.ComboBox AvailableDrives_Combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Output_Box;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}

