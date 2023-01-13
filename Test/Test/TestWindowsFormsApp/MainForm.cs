using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClassLibrary;

namespace TestWindowsFormsApp
{
    public partial class MainForm : Form
    {
        Triangle triangle = new Triangle(0, 0, 0);
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            triangle.a = Convert.ToDouble(sideA.Text);
            triangle.b = Convert.ToDouble(sideB.Text);
            triangle.c = Convert.ToDouble(sideC.Text);
            if (Triangle.IsExists(triangle, out double p, out double s))
            {
                isExistst.Text = "Треугольник существует";
                perimetr.Text = Convert.ToString(p);
                square.Text = Convert.ToString(s);                
            }
            else
            {
                isExistst.Text = "Треугольника не сущетвует";
                perimetr.Text = "";
                square.Text = "";
            }
        }
    }
}
