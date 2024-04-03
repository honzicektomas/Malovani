namespace Malovani
{
    partial class Rename
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
            tb_rename_layer = new TextBox();
            b_ok = new Button();
            b_cancel = new Button();
            l_new_name = new Label();
            SuspendLayout();
            // 
            // tb_rename_layer
            // 
            tb_rename_layer.Location = new Point(88, 54);
            tb_rename_layer.Name = "tb_rename_layer";
            tb_rename_layer.Size = new Size(100, 23);
            tb_rename_layer.TabIndex = 0;
            // 
            // b_ok
            // 
            b_ok.Location = new Point(62, 100);
            b_ok.Name = "b_ok";
            b_ok.Size = new Size(75, 23);
            b_ok.TabIndex = 1;
            b_ok.Text = "OK";
            b_ok.UseVisualStyleBackColor = true;
            b_ok.Click += b_ok_Click;
            // 
            // b_cancel
            // 
            b_cancel.Location = new Point(143, 100);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(75, 23);
            b_cancel.TabIndex = 2;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // l_new_name
            // 
            l_new_name.AutoSize = true;
            l_new_name.Location = new Point(88, 27);
            l_new_name.Name = "l_new_name";
            l_new_name.Size = new Size(92, 15);
            l_new_name.TabIndex = 3;
            l_new_name.Text = "New layer name";
            // 
            // Rename
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 184);
            Controls.Add(l_new_name);
            Controls.Add(b_cancel);
            Controls.Add(b_ok);
            Controls.Add(tb_rename_layer);
            Name = "Rename";
            Text = "Rename";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_rename_layer;
        private Button b_ok;
        private Button b_cancel;
        private Label l_new_name;
    }
}