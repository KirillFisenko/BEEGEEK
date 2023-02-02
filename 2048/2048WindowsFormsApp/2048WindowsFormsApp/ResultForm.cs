using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            string[] values = MainForm.ReadFile(MainForm.path).Trim().Split('\n');
            foreach (var line in values)
            {
                var massive = line.Trim().Split('#');
                var name = massive[0];
                var score = massive[1];
                scoreDataGridView.Rows.Add(name, score);                
            }
        }        
    }
}
