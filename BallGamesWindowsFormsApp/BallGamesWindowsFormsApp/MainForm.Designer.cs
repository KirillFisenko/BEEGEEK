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
            this.drawBallButton = new System.Windows.Forms.Button();
            this.drawRandomBallbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawBallButton
            // 
            this.drawBallButton.Location = new System.Drawing.Point(464, 12);
            this.drawBallButton.Name = "drawBallButton";
            this.drawBallButton.Size = new System.Drawing.Size(132, 40);
            this.drawBallButton.TabIndex = 0;
            this.drawBallButton.Text = "Нарисовать шарик";
            this.drawBallButton.UseVisualStyleBackColor = true;
            this.drawBallButton.Click += new System.EventHandler(this.drawBallButton_Click);
            // 
            // drawRandomBallbutton
            // 
            this.drawRandomBallbutton.Location = new System.Drawing.Point(464, 94);
            this.drawRandomBallbutton.Name = "drawRandomBallbutton";
            this.drawRandomBallbutton.Size = new System.Drawing.Size(132, 47);
            this.drawRandomBallbutton.TabIndex = 1;
            this.drawRandomBallbutton.Text = "Нарисовать случайный шарик";
            this.drawRandomBallbutton.UseVisualStyleBackColor = true;
            this.drawRandomBallbutton.Click += new System.EventHandler(this.drawRandomBallbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 589);
            this.Controls.Add(this.drawRandomBallbutton);
            this.Controls.Add(this.drawBallButton);
            this.Name = "MainForm";
            this.Text = "BallGames";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawBallButton;
        private System.Windows.Forms.Button drawRandomBallbutton;
    }
}

