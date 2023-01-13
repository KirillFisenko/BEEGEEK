namespace TestWindowsFormsApp
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
            this.sideA = new System.Windows.Forms.TextBox();
            this.sideB = new System.Windows.Forms.TextBox();
            this.sideC = new System.Windows.Forms.TextBox();
            this.perimetr = new System.Windows.Forms.TextBox();
            this.square = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isExistst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideA
            // 
            this.sideA.Location = new System.Drawing.Point(53, 79);
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(100, 20);
            this.sideA.TabIndex = 0;
            // 
            // sideB
            // 
            this.sideB.Location = new System.Drawing.Point(255, 79);
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(100, 20);
            this.sideB.TabIndex = 1;
            // 
            // sideC
            // 
            this.sideC.Location = new System.Drawing.Point(453, 79);
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(100, 20);
            this.sideC.TabIndex = 2;
            // 
            // perimetr
            // 
            this.perimetr.Location = new System.Drawing.Point(109, 229);
            this.perimetr.Name = "perimetr";
            this.perimetr.Size = new System.Drawing.Size(100, 20);
            this.perimetr.TabIndex = 3;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(378, 229);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(100, 20);
            this.square.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(245, 140);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(125, 30);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Side b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Side c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "s";
            // 
            // isExistst
            // 
            this.isExistst.AutoSize = true;
            this.isExistst.Location = new System.Drawing.Point(282, 192);
            this.isExistst.Name = "isExistst";
            this.isExistst.Size = new System.Drawing.Size(0, 13);
            this.isExistst.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 315);
            this.Controls.Add(this.isExistst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.square);
            this.Controls.Add(this.perimetr);
            this.Controls.Add(this.sideC);
            this.Controls.Add(this.sideB);
            this.Controls.Add(this.sideA);
            this.Name = "MainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sideA;
        private System.Windows.Forms.TextBox sideB;
        private System.Windows.Forms.TextBox sideC;
        private System.Windows.Forms.TextBox perimetr;
        private System.Windows.Forms.TextBox square;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label isExistst;
    }
}

