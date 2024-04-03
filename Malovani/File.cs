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
    public partial class File : Form
    {
        public string saveFilePath;
        public string openFilePath;
        public File()
        {
            InitializeComponent();
        }

        private void b_save_as_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "document.png";
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "Picture files (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = saveFileDialog.FileName;
            }
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Picture files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.openFilePath = openFileDialog.FileName;
            }
        }
    }
}
