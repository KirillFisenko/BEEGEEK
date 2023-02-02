using System;
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
    }
}
