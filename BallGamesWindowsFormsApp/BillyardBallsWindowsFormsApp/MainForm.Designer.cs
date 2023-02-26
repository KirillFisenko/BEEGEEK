namespace BillyardBallsWindowsFormsApp
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
            this.leftRedLabel = new System.Windows.Forms.Label();
            this.rightRedLabel = new System.Windows.Forms.Label();
            this.topBlueLabel = new System.Windows.Forms.Label();
            this.downBlueLabel = new System.Windows.Forms.Label();
            this.topRedLabel = new System.Windows.Forms.Label();
            this.downRedLabel = new System.Windows.Forms.Label();
            this.leftBlueLabel = new System.Windows.Forms.Label();
            this.rightBlueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftRedLabel
            // 
            this.leftRedLabel.AutoSize = true;
            this.leftRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftRedLabel.ForeColor = System.Drawing.Color.Red;
            this.leftRedLabel.Location = new System.Drawing.Point(12, 158);
            this.leftRedLabel.Name = "leftRedLabel";
            this.leftRedLabel.Size = new System.Drawing.Size(21, 24);
            this.leftRedLabel.TabIndex = 0;
            this.leftRedLabel.Text = "0";
            // 
            // rightRedLabel
            // 
            this.rightRedLabel.AutoSize = true;
            this.rightRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightRedLabel.ForeColor = System.Drawing.Color.Red;
            this.rightRedLabel.Location = new System.Drawing.Point(767, 158);
            this.rightRedLabel.Name = "rightRedLabel";
            this.rightRedLabel.Size = new System.Drawing.Size(21, 24);
            this.rightRedLabel.TabIndex = 1;
            this.rightRedLabel.Text = "0";
            // 
            // topBlueLabel
            // 
            this.topBlueLabel.AutoSize = true;
            this.topBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.topBlueLabel.Location = new System.Drawing.Point(355, 9);
            this.topBlueLabel.Name = "topBlueLabel";
            this.topBlueLabel.Size = new System.Drawing.Size(21, 24);
            this.topBlueLabel.TabIndex = 2;
            this.topBlueLabel.Text = "0";
            // 
            // downBlueLabel
            // 
            this.downBlueLabel.AutoSize = true;
            this.downBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.downBlueLabel.Location = new System.Drawing.Point(355, 417);
            this.downBlueLabel.Name = "downBlueLabel";
            this.downBlueLabel.Size = new System.Drawing.Size(21, 24);
            this.downBlueLabel.TabIndex = 3;
            this.downBlueLabel.Text = "0";
            // 
            // topRedLabel
            // 
            this.topRedLabel.AutoSize = true;
            this.topRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topRedLabel.ForeColor = System.Drawing.Color.Red;
            this.topRedLabel.Location = new System.Drawing.Point(442, 9);
            this.topRedLabel.Name = "topRedLabel";
            this.topRedLabel.Size = new System.Drawing.Size(21, 24);
            this.topRedLabel.TabIndex = 4;
            this.topRedLabel.Text = "0";
            // 
            // downRedLabel
            // 
            this.downRedLabel.AutoSize = true;
            this.downRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downRedLabel.ForeColor = System.Drawing.Color.Red;
            this.downRedLabel.Location = new System.Drawing.Point(442, 417);
            this.downRedLabel.Name = "downRedLabel";
            this.downRedLabel.Size = new System.Drawing.Size(21, 24);
            this.downRedLabel.TabIndex = 5;
            this.downRedLabel.Text = "0";
            // 
            // leftBlueLabel
            // 
            this.leftBlueLabel.AutoSize = true;
            this.leftBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.leftBlueLabel.Location = new System.Drawing.Point(12, 215);
            this.leftBlueLabel.Name = "leftBlueLabel";
            this.leftBlueLabel.Size = new System.Drawing.Size(21, 24);
            this.leftBlueLabel.TabIndex = 6;
            this.leftBlueLabel.Text = "0";
            // 
            // rightBlueLabel
            // 
            this.rightBlueLabel.AutoSize = true;
            this.rightBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.rightBlueLabel.Location = new System.Drawing.Point(767, 215);
            this.rightBlueLabel.Name = "rightBlueLabel";
            this.rightBlueLabel.Size = new System.Drawing.Size(21, 24);
            this.rightBlueLabel.TabIndex = 7;
            this.rightBlueLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightBlueLabel);
            this.Controls.Add(this.leftBlueLabel);
            this.Controls.Add(this.downRedLabel);
            this.Controls.Add(this.topRedLabel);
            this.Controls.Add(this.downBlueLabel);
            this.Controls.Add(this.topBlueLabel);
            this.Controls.Add(this.rightRedLabel);
            this.Controls.Add(this.leftRedLabel);
            this.Name = "MainForm";
            this.Text = "BillyardBalls";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftRedLabel;
        private System.Windows.Forms.Label rightRedLabel;
        private System.Windows.Forms.Label topBlueLabel;
        private System.Windows.Forms.Label downBlueLabel;
        private System.Windows.Forms.Label topRedLabel;
        private System.Windows.Forms.Label downRedLabel;
        private System.Windows.Forms.Label leftBlueLabel;
        private System.Windows.Forms.Label rightBlueLabel;
    }
}

