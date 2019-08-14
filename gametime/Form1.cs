using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gametime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int n1 = snake.Location.X;
            int n2 = snake.Location.Y - 10;
            snake.Location = new Point(n1, n2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int n1 = snake.Location.X;
            int n2 = snake.Location.Y + 10;
            snake.Location = new Point(n1, n2);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n1 = snake.Location.X + 10;
            int n2 = snake.Location.Y;
            snake.Location = new Point(n1, n2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int n1 = snake.Location.X - 10;
            int n2 = snake.Location.Y;
            snake.Location = new Point(n1, n2);
        }
    }
}
