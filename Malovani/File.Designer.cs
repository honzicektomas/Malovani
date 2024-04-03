namespace Malovani
{
    partial class File
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
            b_save_as = new Button();
            b_open = new Button();
            SuspendLayout();
            // 
            // b_save_as
            // 
            b_save_as.Location = new Point(47, 23);
            b_save_as.Name = "b_save_as";
            b_save_as.Size = new Size(75, 23);
            b_save_as.TabIndex = 0;
            b_save_as.Text = "Save As";
            b_save_as.UseVisualStyleBackColor = true;
            b_save_as.Click += b_save_as_Click;
            // 
            // b_open
            // 
            b_open.Location = new Point(128, 23);
            b_open.Name = "b_open";
            b_open.Size = new Size(75, 23);
            b_open.TabIndex = 1;
            b_open.Text = "Open";
            b_open.UseVisualStyleBackColor = true;
            b_open.Click += b_open_Click;
            // 
            // File
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 105);
            Controls.Add(b_open);
            Controls.Add(b_save_as);
            Name = "File";
            Text = "File";
            ResumeLayout(false);
        }

        #endregion

        private Button b_save_as;
        private Button b_open;
    }
}