using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class GameResult : Form
    {
        public GameResult()
        {
            InitializeComponent();
        }

        private void GameResult_Load(object sender, EventArgs e)
        {
            var result = UsersResultStorage.GetUserResult();
            foreach (var user in result)
            {
                resultsDataGridView.Rows.Add(user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }
    }
}
