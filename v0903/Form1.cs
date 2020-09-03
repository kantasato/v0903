using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);

        int a = Math.Abs(-10);
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left <= 0)
            {
                vx = Math.Abs(vx) * 11 / 10;
            }
            if (label1.Top <= 0)
            {
                vy = Math.Abs(vy) * 11 / 10;
            }
            if (label1.Right >= ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 11 / 10;
            }
            if (label1.Top >= ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 11 / 10;
            }
        }
    }
}
