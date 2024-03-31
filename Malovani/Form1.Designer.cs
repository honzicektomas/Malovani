namespace Malovani
{
    partial class Form1
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
            this.pictureBox1 = new PictureBox();
            this.lb_layers = new ListBox();
            this.l_layers = new Label();
            this.b_color1 = new Button();
            this.b_ctverec = new Button();
            this.b_cara = new Button();
            this.pb_menu_bg = new PictureBox();
            this.b_add_layer = new Button();
            this.b_remove_layer = new Button();
            this.colorDialog1 = new ColorDialog();
            this.b_elipsa = new Button();
            this.b_body = new Button();
            this.b_clear = new Button();
            this.t_pen_width = new TextBox();
            this.l_pen_width = new Label();
            this.cb_fill = new CheckBox();
            this.b_color2 = new Button();
            this.cb_gradient = new CheckBox();
            this.b_eraser = new Button();
            this.b_layer_up = new Button();
            this.b_layer_down = new Button();
            this.b_file = new Button();
            this.b_swap_colors = new Button();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pb_menu_bg).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox1.Location = new Point(12, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(929, 481);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += pictureBox1_Paint;
            this.pictureBox1.MouseDown += pictureBox1_MouseDown;
            this.pictureBox1.MouseMove += pictureBox1_MouseMove;
            this.pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // lb_layers
            // 
            this.lb_layers.FormattingEnabled = true;
            this.lb_layers.ItemHeight = 15;
            this.lb_layers.Location = new Point(950, 129);
            this.lb_layers.Name = "lb_layers";
            this.lb_layers.Size = new Size(145, 424);
            this.lb_layers.TabIndex = 1;
            this.lb_layers.SelectedIndexChanged += lb_layers_SelectedIndexChanged;
            // 
            // l_layers
            // 
            this.l_layers.AutoSize = true;
            this.l_layers.Location = new Point(975, 115);
            this.l_layers.Name = "l_layers";
            this.l_layers.Size = new Size(40, 15);
            this.l_layers.TabIndex = 2;
            this.l_layers.Text = "Layers";
            // 
            // b_color1
            // 
            this.b_color1.Location = new Point(543, 21);
            this.b_color1.Name = "b_color1";
            this.b_color1.Size = new Size(75, 55);
            this.b_color1.TabIndex = 3;
            this.b_color1.Text = "Color1";
            this.b_color1.UseVisualStyleBackColor = true;
            this.b_color1.Click += b_color1_Click;
            // 
            // b_ctverec
            // 
            this.b_ctverec.Location = new Point(118, 21);
            this.b_ctverec.Name = "b_ctverec";
            this.b_ctverec.Size = new Size(75, 55);
            this.b_ctverec.TabIndex = 4;
            this.b_ctverec.Text = "Square";
            this.b_ctverec.UseVisualStyleBackColor = true;
            this.b_ctverec.Click += b_ctverec_Click;
            // 
            // b_cara
            // 
            this.b_cara.Location = new Point(37, 21);
            this.b_cara.Name = "b_cara";
            this.b_cara.Size = new Size(75, 55);
            this.b_cara.TabIndex = 5;
            this.b_cara.Text = "Line";
            this.b_cara.UseVisualStyleBackColor = true;
            this.b_cara.Click += b_cara_Click;
            // 
            // pb_menu_bg
            // 
            this.pb_menu_bg.BorderStyle = BorderStyle.FixedSingle;
            this.pb_menu_bg.Location = new Point(12, 12);
            this.pb_menu_bg.Name = "pb_menu_bg";
            this.pb_menu_bg.Size = new Size(929, 111);
            this.pb_menu_bg.TabIndex = 6;
            this.pb_menu_bg.TabStop = false;
            this.pb_menu_bg.Paint += pb_menu_bg_Paint;
            // 
            // b_add_layer
            // 
            this.b_add_layer.Location = new Point(950, 559);
            this.b_add_layer.Name = "b_add_layer";
            this.b_add_layer.Size = new Size(95, 23);
            this.b_add_layer.TabIndex = 7;
            this.b_add_layer.Text = "Add Layer";
            this.b_add_layer.UseVisualStyleBackColor = true;
            this.b_add_layer.Click += b_add_layer_Click;
            // 
            // b_remove_layer
            // 
            this.b_remove_layer.Location = new Point(950, 588);
            this.b_remove_layer.Name = "b_remove_layer";
            this.b_remove_layer.Size = new Size(95, 23);
            this.b_remove_layer.TabIndex = 8;
            this.b_remove_layer.Text = "Remove Layer";
            this.b_remove_layer.UseVisualStyleBackColor = true;
            this.b_remove_layer.Click += b_remove_layer_Click;
            // 
            // b_elipsa
            // 
            this.b_elipsa.Location = new Point(199, 21);
            this.b_elipsa.Name = "b_elipsa";
            this.b_elipsa.Size = new Size(63, 55);
            this.b_elipsa.TabIndex = 9;
            this.b_elipsa.Text = "Ellipse";
            this.b_elipsa.UseVisualStyleBackColor = true;
            this.b_elipsa.Click += b_elipsa_Click;
            // 
            // b_body
            // 
            this.b_body.Location = new Point(268, 21);
            this.b_body.Name = "b_body";
            this.b_body.Size = new Size(70, 55);
            this.b_body.TabIndex = 10;
            this.b_body.Text = "Points";
            this.b_body.UseVisualStyleBackColor = true;
            this.b_body.Click += b_body_Click;
            // 
            // b_clear
            // 
            this.b_clear.Location = new Point(839, 21);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new Size(73, 55);
            this.b_clear.TabIndex = 11;
            this.b_clear.Text = "Clear";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += b_clear_Click;
            // 
            // t_pen_width
            // 
            this.t_pen_width.Location = new Point(702, 38);
            this.t_pen_width.Name = "t_pen_width";
            this.t_pen_width.Size = new Size(50, 23);
            this.t_pen_width.TabIndex = 12;
            // 
            // l_pen_width
            // 
            this.l_pen_width.AutoSize = true;
            this.l_pen_width.BackColor = SystemColors.HighlightText;
            this.l_pen_width.Location = new Point(705, 21);
            this.l_pen_width.Name = "l_pen_width";
            this.l_pen_width.Size = new Size(26, 15);
            this.l_pen_width.TabIndex = 13;
            this.l_pen_width.Text = "size";
            this.l_pen_width.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_fill
            // 
            this.cb_fill.AutoSize = true;
            this.cb_fill.Location = new Point(37, 82);
            this.cb_fill.Name = "cb_fill";
            this.cb_fill.Size = new Size(41, 19);
            this.cb_fill.TabIndex = 14;
            this.cb_fill.Text = "Fill";
            this.cb_fill.UseVisualStyleBackColor = true;
            // 
            // b_color2
            // 
            this.b_color2.Location = new Point(624, 21);
            this.b_color2.Name = "b_color2";
            this.b_color2.Size = new Size(75, 55);
            this.b_color2.TabIndex = 15;
            this.b_color2.Text = "Color2";
            this.b_color2.UseVisualStyleBackColor = true;
            this.b_color2.Click += b_color2_Click;
            // 
            // cb_gradient
            // 
            this.cb_gradient.AutoSize = true;
            this.cb_gradient.Location = new Point(37, 99);
            this.cb_gradient.Name = "cb_gradient";
            this.cb_gradient.Size = new Size(51, 19);
            this.cb_gradient.TabIndex = 16;
            this.cb_gradient.Text = "Grad";
            this.cb_gradient.UseVisualStyleBackColor = true;
            this.cb_gradient.CheckedChanged += cb_gradient_CheckedChanged;
            // 
            // b_eraser
            // 
            this.b_eraser.Location = new Point(344, 21);
            this.b_eraser.Name = "b_eraser";
            this.b_eraser.Size = new Size(75, 55);
            this.b_eraser.TabIndex = 18;
            this.b_eraser.Text = "Eraser";
            this.b_eraser.UseVisualStyleBackColor = true;
            this.b_eraser.Click += b_eraser_Click;
            // 
            // b_layer_up
            // 
            this.b_layer_up.Location = new Point(1051, 559);
            this.b_layer_up.Name = "b_layer_up";
            this.b_layer_up.Size = new Size(22, 23);
            this.b_layer_up.TabIndex = 19;
            this.b_layer_up.Text = "↑";
            this.b_layer_up.UseVisualStyleBackColor = true;
            this.b_layer_up.Click += b_layer_up_Click;
            // 
            // b_layer_down
            // 
            this.b_layer_down.Location = new Point(1050, 589);
            this.b_layer_down.Name = "b_layer_down";
            this.b_layer_down.Size = new Size(23, 23);
            this.b_layer_down.TabIndex = 20;
            this.b_layer_down.Text = "↓";
            this.b_layer_down.UseVisualStyleBackColor = true;
            this.b_layer_down.Click += b_layer_down_Click;
            // 
            // b_file
            // 
            this.b_file.Location = new Point(972, 19);
            this.b_file.Name = "b_file";
            this.b_file.Size = new Size(75, 23);
            this.b_file.TabIndex = 21;
            this.b_file.Text = "File";
            this.b_file.UseVisualStyleBackColor = true;
            this.b_file.Click += b_file_Click;
            // 
            // b_swap_colors
            // 
            this.b_swap_colors.Location = new Point(607, 69);
            this.b_swap_colors.Name = "b_swap_colors";
            this.b_swap_colors.Size = new Size(25, 23);
            this.b_swap_colors.TabIndex = 22;
            this.b_swap_colors.Text = "↺";
            this.b_swap_colors.UseVisualStyleBackColor = true;
            this.b_swap_colors.Click += b_swap_colors_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 622);
            Controls.Add(this.b_swap_colors);
            Controls.Add(this.b_file);
            Controls.Add(this.b_layer_down);
            Controls.Add(this.b_layer_up);
            Controls.Add(this.b_eraser);
            Controls.Add(this.cb_gradient);
            Controls.Add(this.b_color2);
            Controls.Add(this.cb_fill);
            Controls.Add(this.l_pen_width);
            Controls.Add(this.t_pen_width);
            Controls.Add(this.b_clear);
            Controls.Add(this.b_body);
            Controls.Add(this.b_elipsa);
            Controls.Add(this.b_remove_layer);
            Controls.Add(this.b_add_layer);
            Controls.Add(this.b_cara);
            Controls.Add(this.b_ctverec);
            Controls.Add(this.b_color1);
            Controls.Add(this.l_layers);
            Controls.Add(this.lb_layers);
            Controls.Add(this.pictureBox1);
            Controls.Add(this.pb_menu_bg);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pb_menu_bg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox lb_layers;
        private Label l_layers;
        private Button b_color1;
        private Button b_ctverec;
        private Button b_cara;
        private PictureBox pb_menu_bg;
        private Button b_add_layer;
        private Button b_remove_layer;
        private ColorDialog colorDialog1;
        private Button b_elipsa;
        private Button b_body;
        private Button b_clear;
        private TextBox t_pen_width;
        private Label l_pen_width;
        private CheckBox cb_fill;
        private Button b_color2;
        private CheckBox cb_gradient;
        private Button b_eraser;
        private Button b_layer_up;
        private Button b_layer_down;
        private Button b_file;
        private Button b_swap_colors;
    }
}
