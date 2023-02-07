using System;
using System.IO;
using System.Windows.Forms;
using _2048ClassLibrary;

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
            try
            {
                string[] values = FileProvider.ReadFile(MainForm.path).Trim().Split('\n');
                foreach (var line in values)
                {
                    var massive = line.Trim().Split('#');
                    var name = massive[0];
                    var score = massive[1];
                    scoreDataGridView.Rows.Add(name, score);
                }
            }
            catch { }
        }
    }
}