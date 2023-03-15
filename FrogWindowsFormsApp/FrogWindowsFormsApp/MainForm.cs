using System;
using System.Windows.Forms;

namespace FrogWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int minCountSteps = 24;
        private int userCountSteps;
        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;
            if(distance > 2 || clickedPicture == emptyPictureBox)
            {
                MessageBox.Show("Так нельзя");
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                countStepLabel.Text = (Convert.ToInt32(countStepLabel.Text) + 1).ToString();
                userCountSteps++;
                if (Win())
                {
                    if(userCountSteps - minCountSteps == 0)
                    {
                        MessageBox.Show($"Вы выиграли за минмиальное количество ходов!");
                    }
                    else
                    {
                        MessageBox.Show($"Вы выиграли! Ваше количетво ходов: {userCountSteps}. Минимально возможное - {minCountSteps}");
                    }                    
                }
            }            
        }

        private bool Win()
        {
            if (leftPictureBox1.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox2.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox3.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox4.Location.X > emptyPictureBox.Location.X &&
                emptyPictureBox.Location.X == 440)
            {
                leftPictureBox1.Enabled = false;
                leftPictureBox2.Enabled = false;
                leftPictureBox3.Enabled = false;
                leftPictureBox4.Enabled = false;
                rightPictureBox1.Enabled = false;
                rightPictureBox2.Enabled = false;
                rightPictureBox3.Enabled = false;
                rightPictureBox4.Enabled = false;
                emptyPictureBox.Enabled = false;
                return true;
            }
            return false;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Цель игры — расположить лягушек, которые смотрят влево, в левую часть, а остальных - в правую часть за минимальное количество перепрыгиваний.\r\n\r\nПрыгать можно на листок, если он находится рядом или через 1 лягушку");
        }
    }
}