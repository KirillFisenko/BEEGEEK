using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected List<RandomSizeAndPointBall> randomSizeAndPointBalls = new List<RandomSizeAndPointBall>();
        private int countBalls;
        private int formWidth = 900;
        private int formHeight = 538;
        private int quantityBalls = 15;
        private int countClick = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void stopBallButton_Click(object sender, EventArgs e)
        {
            if (countClick == 0)
            {
                try
                {
                    timer.Stop();

                    for (int i = 0; i < quantityBalls; i++)
                    {
                        var pointUpLeftX = randomSizeAndPointBalls[i].x;
                        var pointUpLeftY = randomSizeAndPointBalls[i].y;
                        var pointDownRightX = randomSizeAndPointBalls[i].x + randomSizeAndPointBalls[i].size;
                        var pointDownRightY = randomSizeAndPointBalls[i].y + randomSizeAndPointBalls[i].size;

                        if (pointUpLeftX >= 0 && pointDownRightX <= formWidth && pointUpLeftY >= 0 && pointDownRightY <= formHeight)
                        {
                            countBalls++;
                        }
                    }
                    MessageBox.Show("Количество пойманных шаров: " + countBalls);
                    countClick++;
                }
                catch
                {
                    MessageBox.Show("Сначала нужно создать шарики");
                }
            }
            else
            {
                MessageBox.Show("Теперь нужно очистить поле кнопкой Перезагрузить");
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

        }


        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < quantityBalls; i++)
            {
                randomSizeAndPointBalls[i].Move();
            }
        }

        private void drawRandomBallbutton_Click(object sender, EventArgs e)
        {
            if (countClick == 0)
            {
                for (int i = 0; i < quantityBalls; i++)
                {
                    var randomSizeAndPointBall = new RandomSizeAndPointBall(this);
                    randomSizeAndPointBalls.Add(randomSizeAndPointBall);
                }
                timer.Start();
            }
            else
            {
                MessageBox.Show("Теперь нужно очистить поле кнопкой Перезагрузить");
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}