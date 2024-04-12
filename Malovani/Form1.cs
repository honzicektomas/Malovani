using Microsoft.VisualBasic.Devices;
using System.Runtime.CompilerServices;
using WinFormsApp6;

namespace Malovani
{
    public partial class Form1 : Form
    {
        private Picture picture = new Picture();
        private Color Color1 = Color.LightGreen;
        private Color Color2 = Color.Blue;
        private GradientType gt;
        private string openFilePath;
        private string saveFilePath;

        private bool mouse_down = false;
        private int button_index = 0;
        private int active_layer;
        private int layer_counter = 0;



        public Form1()
        {
            InitializeComponent();
            this.HandleButtonColors();
            this.InitLayer();
            this.InitCmbGradients();


            this.BackColor = Color.LightGray;
            this.pictureBox1.BackColor = Color.White;
            this.tb_transparency.BackColor = Color.LightGray;
            this.t_pen_width.Text = "3";
            this.tb_transparency.Value = 255;
        }

        private void InitCmbGradients()
        {
            this.cmb_gradients.Hide();
            this.cmb_gradients.Items.Add("Horizontal");
            this.cmb_gradients.Items.Add("Vertical");
            this.cmb_gradients.Items.Add("Diagonal");
        }

        private void InitLayer()
        {
            this.lb_layers.Items.Add("Layer " + this.layer_counter);
            this.lb_layers.SelectedIndex = 0;
            this.layer_counter++;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.picture.Draw(e.Graphics);
            this.picture.select.DrawRect(e.Graphics);
            this.Invalidate();
        }

        private void pb_MenuBgPaint(object sender, PaintEventArgs e)
        {
            this.pb_menu_bg.BackColor = Color.LightGray;
        }

        private int textBoxCheck()
        {
            string x = this.t_pen_width.Text;
            try
            {
                if (Convert.ToInt32(x) < 0)
                {
                    x += "a";
                }
                return Convert.ToInt32(x);
            }
            catch
            {
                return 3;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.lb_layers.Items.Count == 0)
            {
                MessageBox.Show("You can't draw without a layer!" +
                                "\n A new layer has been created.");
                this.InitLayer();
                return;
            }

            this.mouse_down = true;

            if (this.skd())
            {
                this.picture.select.Start = e.Location;
            }

            switch (this.button_index)
            {
                case (int)ShapeType.Line:
                    this.picture.CreateShape
                        (
                            e.Location,
                            this.Color1,
                            this.Color2,
                            ShapeType.Line,
                            this.textBoxCheck(),
                            this.cb_fill.Checked,
                            this.cb_gradient.Checked,
                            this.active_layer,
                            this.tb_transparency.Value,
                            gt
                        );
                    break;

                case (int)ShapeType.Rectangle:
                    this.picture.CreateShape
                        (
                            e.Location,
                            this.Color1,
                            this.Color2,
                            ShapeType.Rectangle,
                            this.textBoxCheck(),
                            this.cb_fill.Checked,
                            this.cb_gradient.Checked,
                            this.active_layer,
                            this.tb_transparency.Value,
                            gt
                        );
                    break;

                case (int)ShapeType.Ellipse:
                    this.picture.CreateShape
                        (
                            e.Location,
                            this.Color1,
                            this.Color2,
                            ShapeType.Ellipse,
                            this.textBoxCheck(),
                            this.cb_fill.Checked,
                            this.cb_gradient.Checked,
                            this.active_layer,
                            this.tb_transparency.Value,
                            gt
                        );
                    break;

                case (int)ShapeType.Points:
                    this.picture.CreateShape
                        (
                            e.Location,
                            this.Color1,
                            this.Color2,
                            ShapeType.Points,
                            this.textBoxCheck(),
                            this.cb_fill.Checked,
                            this.cb_gradient.Checked,
                            this.active_layer,
                            this.tb_transparency.Value,
                            gt
                        );
                    break;

                case (int)ShapeType.Eraser:
                    this.picture.CreateShape
                        (
                            e.Location,
                            this.pictureBox1.BackColor,
                            this.pictureBox1.BackColor,
                            ShapeType.Eraser,
                            this.textBoxCheck() * 5,
                            this.cb_fill.Checked,
                            this.cb_gradient.Checked,
                            this.active_layer,
                            this.tb_transparency.Value,
                            gt
                        );
                    break;
            }
        }

        private bool skd()
        {
            return new Keyboard().ShiftKeyDown;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouse_down = false;
            //this.picture.select.rect = Rectangle.Empty;
            this.UpdateRemovedShapes();
            
        }
        private void UpdateRemovedShapes()
        {
            this.picture.select.RemoveShapes(this.picture.shapes);
            this.picture.select.Start = Point.Empty; // Reset Start point
            this.picture.select.End = Point.Empty;
            this.pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouse_down && new Keyboard().ShiftKeyDown)
            {
                this.picture.select.End = e.Location;
                
            }
            else if  (this.mouse_down)
            {
                this.picture.AddPoint(e.Location);
                
            }
            this.pictureBox1.Refresh();
        }

        private void b_Color1Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();

            if (cld.ShowDialog() == DialogResult.OK)
            {
                this.Color1 = cld.Color;
            }
            this.HandleButtonColors();
        }

        private void b_color2_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();

            if (cld.ShowDialog() == DialogResult.OK)
            {
                this.Color2 = cld.Color;
            }
            this.HandleButtonColors();
        }

        private void b_ClearClick(object sender, EventArgs e)
        {
            this.picture.Clear();
            this.pictureBox1.Refresh();
        }

        private void b_EraserClick(object sender, EventArgs e)
        {
            this.button_index = (int)ShapeType.Eraser;
        }

        private void cb_GradientCheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_gradient.Checked)
            {
                this.cb_fill.Checked = true;
                this.cmb_gradients.Show();

            }
            else
            {
                this.cmb_gradients.Hide();
            }
        }

        private void b_AddLayerClick(object sender, EventArgs e)
        {
            this.lb_layers.Items.Add("Layer " + this.layer_counter);
            this.layer_counter++;
        }

        private void lb_LayersSelectedIndexChanged(object sender, EventArgs e)
        {
            this.active_layer = this.lb_layers.SelectedIndex;
            this.pictureBox1.Refresh();
        }

        private void b_RemoveLayerClick(object sender, EventArgs e)
        {

            if (active_layer >= 0)
            {
                this.lb_layers.Items.RemoveAt(active_layer);

                for (int i = 0; i < this.picture.shapes.Count; i++)
                {
                    if (this.picture.shapes[i].layer == active_layer)
                    {
                        this.picture.shapes.RemoveAt(i);
                        i--;
                    }
                }

                for (int i = 0; i < this.picture.shapes.Count; i++)
                {
                    if (this.picture.shapes[i].layer > active_layer)
                    {
                        this.picture.shapes[i].layer--;
                    }
                }
                this.pictureBox1.Refresh();
            }

        }

        private void AdjustLayer(bool up)
        {
            int selectedIndex = this.lb_layers.SelectedIndex;
            int target_index;

            if (selectedIndex >= 0 && selectedIndex < lb_layers.Items.Count)
            {
                if (up)
                {
                    target_index = selectedIndex - 1;
                }
                else
                {
                    target_index = selectedIndex + 1;
                }

                if (target_index >= 0 && target_index < lb_layers.Items.Count)
                {
                    object temp = lb_layers.Items[selectedIndex];
                    lb_layers.Items[selectedIndex] = lb_layers.Items[target_index];
                    lb_layers.Items[target_index] = temp;

                    lb_layers.SelectedIndex = target_index;

                    foreach (Shape shape in picture.shapes)
                    {
                        if (shape.layer == selectedIndex)
                        {
                            shape.layer = target_index;
                        }
                        else if (shape.layer == target_index)
                        {
                            shape.layer = selectedIndex;
                        }
                    }

                    pictureBox1.Refresh();
                }
            }
        }

        private void b_LayerUpClick(object sender, EventArgs e)
        {
            this.AdjustLayer(true);
        }

        private void b_LayerDownClick(object sender, EventArgs e)
        {
            this.AdjustLayer(false);
        }

        private void b_FileClick(object sender, EventArgs e)
        {
            File file = new File();

            file.Show();

            this.openFilePath = file.openFilePath;
            this.saveFilePath = file.saveFilePath;
        }
        private void HandleButtonColors()
        {
            this.b_color1.BackColor = this.Color1;
            this.b_color1.ForeColor = this.Color1;
            this.b_color2.BackColor = this.Color2;
            this.b_color2.ForeColor = this.Color2;
        }

        private void b_SwapColorsClick(object sender, EventArgs e)
        {
            Color temp = this.Color2;
            this.Color2 = this.Color1;
            this.Color1 = temp;

            this.HandleButtonColors();
        }

        private void b_LineClick(object sender, EventArgs e)
        {
            this.button_index = (int)ShapeType.Line;
        }

        private void b_RectangleClick(object sender, EventArgs e)
        {
            this.button_index = (int)ShapeType.Rectangle;
        }

        private void b_EllipseClick(object sender, EventArgs e)
        {
            this.button_index = (int)ShapeType.Ellipse;
        }

        private void b_PointsClick(object sender, EventArgs e)
        {
            this.button_index = (int)ShapeType.Points;
        }

        private void b_RenameLayerClick(object sender, EventArgs e)
        {
            Rename r = new Rename();

            if (r.ShowDialog() == DialogResult.OK)
            {
                this.lb_layers.Items[this.active_layer] = r.new_name;
            }
        }

        private void b_CanvasColorClick(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();

            if (cld.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.BackColor = cld.Color;

                foreach (Shape shape in this.picture.shapes)
                {
                    if (shape.ShapeType == ShapeType.Eraser)
                    {
                        shape.Color1 = cld.Color;
                    }
                }
            }

        }

        private void cmb_gradients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gt = (GradientType)this.cmb_gradients.SelectedIndex;

            
        }
    }
}