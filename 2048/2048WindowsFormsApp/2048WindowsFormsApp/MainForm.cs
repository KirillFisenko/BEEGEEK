using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;
        private static int mapSize = 4;
        private static Random random = new Random();
        private static Random randomIndex = new Random();
        private int score = 0;
        private int bestScore = 0;
        private string userName;
        private string[] newLabelNumber = new string[] { "2", "2", "2", "4" };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();            
            EnterUserName(welcomeForm);
            ChooseMapSize(welcomeForm);
            InitMap();
            GenerateNumber();
            ShowUserName();
            ShowScore();
            ShowBestScore();
        }

        private void ShowUserName()
        {
            userNameLabel.Text = userName;
        }

        private void EnterUserName(WelcomeForm welcomeForm)
        {
            userName = welcomeForm.userNameTextBox.Text;
            if (userName == string.Empty)
            {
                Application.Exit();
            }
        }

        private void ChooseMapSize(WelcomeForm welcomeForm)
        {
            try
            {
                mapSize = Convert.ToInt32(welcomeForm.mapSizeComboBox.Text.Substring(0, 1));
            }
            catch
            {
                Application.Exit();
            }            
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }

        private void ShowBestScore()
        {
            userRecordLabel.Text = bestScore.ToString();
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == String.Empty)
                {
                    var randomNumber = newLabelNumber[randomIndex.Next(newLabelNumber.Length)];
                    labelsMap[indexRow, indexColumn].Text = randomNumber;                    
                    SetColorLabel(labelsMap[indexRow, indexColumn], randomNumber);
                    break;
                }
            }
        }

        private void SetColorLabel(Label labelsMap, string number)
        {            
            switch (number)
            {                
                case "2": labelsMap.BackColor = Color.AliceBlue; break;
                case "4": labelsMap.BackColor = Color.AntiqueWhite; break;
                case "8": labelsMap.BackColor = Color.BurlyWood; break;
                case "16": labelsMap.BackColor = Color.Coral; break;
                case "32": labelsMap.BackColor = Color.Chocolate; break;
                case "64": labelsMap.BackColor = Color.Brown; break;
                case "128": labelsMap.BackColor = Color.Crimson; break;
                case "256": labelsMap.BackColor = Color.DarkRed; break;
                case "512": labelsMap.BackColor = Color.DeepPink; break;
                case "1024": labelsMap.BackColor = Color.DarkOliveGreen; break;
                case "2048": labelsMap.BackColor = Color.Black; break;
            }           
        }

        private void EndGame(Label[,] labelsMap)
        {
            var cnt = 0;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        MessageBox.Show("Вы выиграли! Игра будет перезагружена");
                        Application.Restart();
                    }
                    if (labelsMap[i, j].Text != String.Empty)
                    {
                        cnt++;
                    }                    
                }
            }
            if(cnt == mapSize * mapSize)
            {
                MessageBox.Show("Вы проиграли! Игра будет перезагружена");
                Application.Restart();
            }            
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            Label label = new Label();
            label.BackColor = Color.Silver;
            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.ForeColor = Color.SlateGray;
            label.Size = new Size(70, 70);
            label.Text = String.Empty;
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 5 + indexColumn * 76;
            int y = 90 + indexRow * 76;
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        bestScore= score;
                                        labelsMap[i, j].Text = (number * 2).ToString();                                        
                                        SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);                                        
                                        labelsMap[i, k].Text = string.Empty;
                                        labelsMap[i, k].BackColor = Color.Silver;                                        
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != String.Empty)
                                {                                    
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);
                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, k].BackColor = Color.Silver;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        bestScore = score;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);                                        
                                        labelsMap[i, k].Text = string.Empty;
                                        labelsMap[i, k].BackColor = Color.Silver;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != String.Empty)
                                {                                    
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);
                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, k].BackColor = Color.Silver;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (labelsMap[k, j].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        bestScore = score;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);                                        
                                        labelsMap[k, j].Text = string.Empty;
                                        labelsMap[k, j].BackColor = Color.Silver;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (labelsMap[k, j].Text != String.Empty)
                                {                                    
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);
                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[k, j].BackColor = Color.Silver;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        bestScore = score;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);                                        
                                        labelsMap[k, j].Text = string.Empty;
                                        labelsMap[k, j].BackColor = Color.Silver;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != String.Empty)
                                {                                    
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    SetColorLabel(labelsMap[i, j], labelsMap[i, j].Text);
                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[k, j].BackColor = Color.Silver;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            
            GenerateNumber();            
            ShowScore();
            ShowBestScore();
            EndGame(labelsMap);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameRules = new RulesForm();
            gameRules.ShowDialog();
        }

        private void историяИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameResult = new ResultForm();
            gameResult.ShowDialog();
        }
    }
}
