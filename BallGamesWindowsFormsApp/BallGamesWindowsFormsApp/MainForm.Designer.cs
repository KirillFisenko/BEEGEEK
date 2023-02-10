namespace BallGamesWindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stopBallButton = new System.Windows.Forms.Button();
            this.drawRandomBallbutton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weitghLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stopBallButton
            // 
            this.stopBallButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBallButton.ForeColor = System.Drawing.Color.Crimson;
            this.stopBallButton.Location = new System.Drawing.Point(658, 137);
            this.stopBallButton.Name = "stopBallButton";
            this.stopBallButton.Size = new System.Drawing.Size(205, 87);
            this.stopBallButton.TabIndex = 0;
            this.stopBallButton.Text = "Остановить";
            this.stopBallButton.UseVisualStyleBackColor = true;
            this.stopBallButton.Click += new System.EventHandler(this.stopBallButton_Click);
            // 
            // drawRandomBallbutton
            // 
            this.drawRandomBallbutton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawRandomBallbutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.drawRandomBallbutton.Location = new System.Drawing.Point(658, 12);
            this.drawRandomBallbutton.Name = "drawRandomBallbutton";
            this.drawRandomBallbutton.Size = new System.Drawing.Size(205, 87);
            this.drawRandomBallbutton.TabIndex = 1;
            this.drawRandomBallbutton.Text = "Создать";
            this.drawRandomBallbutton.UseVisualStyleBackColor = true;
            this.drawRandomBallbutton.Click += new System.EventHandler(this.drawRandomBallbutton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.restartButton.Location = new System.Drawing.Point(658, 265);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(205, 87);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Перезагрузить";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Orange;
            this.exitButton.Location = new System.Drawing.Point(658, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(205, 87);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(33, 453);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 13);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "x = ";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(33, 477);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 13);
            this.yLabel.TabIndex = 5;
            this.yLabel.Text = "y = ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(226, 453);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(48, 13);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "height = ";
            // 
            // weitghLabel
            // 
            this.weitghLabel.AutoSize = true;
            this.weitghLabel.Location = new System.Drawing.Point(226, 477);
            this.weitghLabel.Name = "weitghLabel";
            this.weitghLabel.Size = new System.Drawing.Size(50, 13);
            this.weitghLabel.TabIndex = 7;
            this.weitghLabel.Text = "weitgh = ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.weitghLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.drawRandomBallbutton);
            this.Controls.Add(this.stopBallButton);
            this.Name = "MainForm";
            this.Text = "BallGames";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopBallButton;
        private System.Windows.Forms.Button drawRandomBallbutton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weitghLabel;
    }
}

