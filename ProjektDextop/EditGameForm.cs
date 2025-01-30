using ProjectLibrary;
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
    public partial class EditGameForm : Form
    {
        List<GameQuizQuestion> list;
        public string oldName { get; set; }
        public string newName { get; set; }
        public EditGameForm(List<GameQuizQuestion> questions)
        {
            InitializeComponent();
            list = questions;
            comboBoxGameList.DataSource = list.Select(q => q.GameTitle).ToList();
            pictureBoxGameImage.ImageLocation = list[0].ImagePath;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            oldName = comboBoxGameList.SelectedItem?.ToString();
            newName = textBoxNewName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxGameImage.ImageLocation = list.FirstOrDefault(q => q.GameTitle == comboBoxGameList.SelectedItem?.ToString()).ImagePath;
        }
    }
}
