using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektDextop
{
    public partial class AddGameForm : Form
    {
        public string ImagePath { get; set; }
        public string GameTitle { get; set; }
        public AddGameForm()
        {
            InitializeComponent();
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    labelImagePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labelImagePath.Text) || string.IsNullOrWhiteSpace(textBoxGameTitle.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImagePath = labelImagePath.Text;
            GameTitle = textBoxGameTitle.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
