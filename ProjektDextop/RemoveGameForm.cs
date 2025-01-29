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
    public partial class RemoveGameForm : Form
    {
        public string SelectedGameTitle { get; set; }
        public RemoveGameForm(List<GameQuizQuestion> questions)
        {
            InitializeComponent();
            comboBoxGames.DataSource = questions.Select(q => q.GameTitle).ToList();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            SelectedGameTitle = comboBoxGames.SelectedItem?.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
