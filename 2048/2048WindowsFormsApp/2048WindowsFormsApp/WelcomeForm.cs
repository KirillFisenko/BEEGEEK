using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("Введите имя");
            }
            if (mapSizeComboBox.Text == String.Empty)
            {
                MessageBox.Show("Выберете размер поля");
            }
            if (userNameTextBox.Text != String.Empty && mapSizeComboBox.Text != String.Empty)
            {
                Close();
            }                       
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
