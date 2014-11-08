namespace Notaris1
{
    partial class FormInsertBilangan
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
            this.insertBilanganTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mataUangComboBox = new System.Windows.Forms.ComboBox();
            this.insertBilanganButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // insertBilanganTextBox
            // 
            this.insertBilanganTextBox.Location = new System.Drawing.Point(72, 17);
            this.insertBilanganTextBox.Name = "insertBilanganTextBox";
            this.insertBilanganTextBox.Size = new System.Drawing.Size(185, 20);
            this.insertBilanganTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mataUangComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.insertBilanganTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 55);
            this.panel1.TabIndex = 2;
            // 
            // mataUangComboBox
            // 
            this.mataUangComboBox.FormattingEnabled = true;
            this.mataUangComboBox.Items.AddRange(new object[] {
            "Rp",
            "US$",
            "€"});
            this.mataUangComboBox.Location = new System.Drawing.Point(6, 16);
            this.mataUangComboBox.Name = "mataUangComboBox";
            this.mataUangComboBox.Size = new System.Drawing.Size(60, 21);
            this.mataUangComboBox.TabIndex = 2;
            // 
            // insertBilanganButton
            // 
            this.insertBilanganButton.Location = new System.Drawing.Point(84, 73);
            this.insertBilanganButton.Name = "insertBilanganButton";
            this.insertBilanganButton.Size = new System.Drawing.Size(185, 23);
            this.insertBilanganButton.TabIndex = 3;
            this.insertBilanganButton.Text = "Insert Bilangan";
            this.insertBilanganButton.UseVisualStyleBackColor = true;
            this.insertBilanganButton.Click += new System.EventHandler(this.insertBilanganButton_Click);
            // 
            // FormInsertBilangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.insertBilanganButton);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "FormInsertBilangan";
            this.Text = "Insert Bilangan";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insertBilanganTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox mataUangComboBox;
        private System.Windows.Forms.Button insertBilanganButton;
    }
}