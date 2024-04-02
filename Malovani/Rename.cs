using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malovani
{
    public partial class Rename : Form
    {
        public string new_name { get; set; }

        public Rename()
        {
            InitializeComponent();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            this.new_name = tb_rename_layer.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
