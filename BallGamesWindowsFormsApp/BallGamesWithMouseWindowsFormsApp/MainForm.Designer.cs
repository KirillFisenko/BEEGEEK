namespace BallGamesWithMouseWindowsFormsApp
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.drawRandomBallbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countBallslabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.infoLabel.Location = new System.Drawing.Point(289, 26);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(300, 16);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Создай шарики и поймай как можно больше ЛКМ";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Orange;
            this.exitButton.Location = new System.Drawing.Point(657, 450);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(205, 37);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.restartButton.Location = new System.Drawing.Point(657, 12);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(205, 37);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Очистить";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // drawRandomBallbutton
            // 
            this.drawRandomBallbutton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawRandomBallbutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.drawRandomBallbutton.Location = new System.Drawing.Point(12, 12);
            this.drawRandomBallbutton.Name = "drawRandomBallbutton";
            this.drawRandomBallbutton.Size = new System.Drawing.Size(205, 37);
            this.drawRandomBallbutton.TabIndex = 6;
            this.drawRandomBallbutton.Text = "Создать";
            this.drawRandomBallbutton.UseVisualStyleBackColor = true;
            this.drawRandomBallbutton.Click += new System.EventHandler(this.drawRandomBallbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество пойманных шаров";
            // 
            // countBallslabel
            // 
            this.countBallslabel.AutoSize = true;
            this.countBallslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBallslabel.ForeColor = System.Drawing.Color.DarkRed;
            this.countBallslabel.Location = new System.Drawing.Point(96, 469);
            this.countBallslabel.Name = "countBallslabel";
            this.countBallslabel.Size = new System.Drawing.Size(21, 24);
            this.countBallslabel.TabIndex = 11;
            this.countBallslabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.countBallslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.drawRandomBallbutton);
            this.Name = "MainForm";
            this.Text = "BallGames";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button drawRandomBallbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countBallslabel;
        private System.Windows.Forms.Timer timer1;
    }
}

