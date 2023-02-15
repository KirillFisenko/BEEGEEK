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
            this.stopBallButton = new System.Windows.Forms.Button();
            this.drawRandomBallbutton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stopBallButton
            // 
            this.stopBallButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBallButton.ForeColor = System.Drawing.Color.Crimson;
            this.stopBallButton.Location = new System.Drawing.Point(12, 450);
            this.stopBallButton.Name = "stopBallButton";
            this.stopBallButton.Size = new System.Drawing.Size(205, 37);
            this.stopBallButton.TabIndex = 0;
            this.stopBallButton.Text = "Остановить";
            this.stopBallButton.UseVisualStyleBackColor = true;
            this.stopBallButton.Click += new System.EventHandler(this.stopBallButton_Click);
            // 
            // drawRandomBallbutton
            // 
            this.drawRandomBallbutton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawRandomBallbutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.drawRandomBallbutton.Location = new System.Drawing.Point(12, 12);
            this.drawRandomBallbutton.Name = "drawRandomBallbutton";
            this.drawRandomBallbutton.Size = new System.Drawing.Size(205, 37);
            this.drawRandomBallbutton.TabIndex = 1;
            this.drawRandomBallbutton.Text = "Создать";
            this.drawRandomBallbutton.UseVisualStyleBackColor = true;
            this.drawRandomBallbutton.Click += new System.EventHandler(this.drawRandomBallbutton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.restartButton.Location = new System.Drawing.Point(667, 12);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(205, 37);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Перезагрузить";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Orange;
            this.exitButton.Location = new System.Drawing.Point(667, 450);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(205, 37);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(201, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Создай шарики и поймай как можно больше кнопой \"Остановить\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.drawRandomBallbutton);
            this.Controls.Add(this.stopBallButton);
            this.Name = "MainForm";
            this.Text = "BallGames";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopBallButton;
        private System.Windows.Forms.Button drawRandomBallbutton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

