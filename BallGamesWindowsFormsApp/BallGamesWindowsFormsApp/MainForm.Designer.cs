﻿namespace BallGamesWindowsFormsApp
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
            this.moveBallButton = new System.Windows.Forms.Button();
            this.drawRandomBallbutton = new System.Windows.Forms.Button();
            this.moveBallbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveBallButton
            // 
            this.moveBallButton.Location = new System.Drawing.Point(464, 116);
            this.moveBallButton.Name = "moveBallButton";
            this.moveBallButton.Size = new System.Drawing.Size(132, 40);
            this.moveBallButton.TabIndex = 0;
            this.moveBallButton.Text = "Двигать1";
            this.moveBallButton.UseVisualStyleBackColor = true;
            this.moveBallButton.Click += new System.EventHandler(this.moveBallButton_Click);
            // 
            // drawRandomBallbutton
            // 
            this.drawRandomBallbutton.Location = new System.Drawing.Point(464, 33);
            this.drawRandomBallbutton.Name = "drawRandomBallbutton";
            this.drawRandomBallbutton.Size = new System.Drawing.Size(132, 47);
            this.drawRandomBallbutton.TabIndex = 1;
            this.drawRandomBallbutton.Text = "Нарисовать случайный шарик";
            this.drawRandomBallbutton.UseVisualStyleBackColor = true;
            this.drawRandomBallbutton.Click += new System.EventHandler(this.drawRandomBallbutton_Click);
            // 
            // moveBallbutton2
            // 
            this.moveBallbutton2.Location = new System.Drawing.Point(464, 194);
            this.moveBallbutton2.Name = "moveBallbutton2";
            this.moveBallbutton2.Size = new System.Drawing.Size(132, 44);
            this.moveBallbutton2.TabIndex = 2;
            this.moveBallbutton2.Text = "Двигать2";
            this.moveBallbutton2.UseVisualStyleBackColor = true;
            this.moveBallbutton2.Click += new System.EventHandler(this.moveBallbutton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 589);
            this.Controls.Add(this.moveBallbutton2);
            this.Controls.Add(this.drawRandomBallbutton);
            this.Controls.Add(this.moveBallButton);
            this.Name = "MainForm";
            this.Text = "BallGames";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveBallButton;
        private System.Windows.Forms.Button drawRandomBallbutton;
        private System.Windows.Forms.Button moveBallbutton2;
    }
}
