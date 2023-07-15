using System.Data;
using Npgsql;

namespace GestwinTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backupsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anuladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anulados anulados = new Anulados();
            anulados.ShowDialog();
        }
    }
}