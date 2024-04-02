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
            this.tb_rename_layer = new TextBox();
            this.b_ok = new Button();
            this.b_cancel = new Button();
            this.l_new_name = new Label();
            SuspendLayout();
            // 
            // tb_rename_layer
            // 
            this.tb_rename_layer.Location = new Point(88, 54);
            this.tb_rename_layer.Name = "tb_rename_layer";
            this.tb_rename_layer.Size = new Size(100, 23);
            this.tb_rename_layer.TabIndex = 0;
            // 
            // b_ok
            // 
            this.b_ok.Location = new Point(62, 100);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new Size(75, 23);
            this.b_ok.TabIndex = 1;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += b_ok_Click;
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new Point(143, 100);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new Size(75, 23);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += b_cancel_Click;
            // 
            // l_new_name
            // 
            this.l_new_name.AutoSize = true;
            this.l_new_name.Location = new Point(88, 27);
            this.l_new_name.Name = "l_new_name";
            this.l_new_name.Size = new Size(92, 15);
            this.l_new_name.TabIndex = 3;
            this.l_new_name.Text = "New layer name";
            // 
            // Rename
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 218);
            Controls.Add(this.l_new_name);
            Controls.Add(this.b_cancel);
            Controls.Add(this.b_ok);
            Controls.Add(this.tb_rename_layer);
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