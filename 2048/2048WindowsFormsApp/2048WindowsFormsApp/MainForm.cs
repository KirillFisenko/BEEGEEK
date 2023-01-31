using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;
        private static int mapSize = 4;
        private static Random random = new Random();
        private static Random randomIndex = new Random();
        private int score = 0;
        private string[] newLabelNumber = new string[] { "2", "2", "2", "4" };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            ChooseMapSize(welcomeForm);
            InitMap();
            GenerateNumber();
            ShowScore();
        }

        private void ChooseMapSize(WelcomeForm welcomeForm)
        {
            mapSize = Convert.ToInt32(welcomeForm.mapSizeComboBox.Text.Substring(0, 1));
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
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
            while (true) //как улучшить (когда 2048, закончить)
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

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            Label label = new Label();
            label.BackColor = Color.Silver;
            label.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
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
    }
}
