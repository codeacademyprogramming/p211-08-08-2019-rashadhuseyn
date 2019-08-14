using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Counter = 0;
        public  void SeatSelector(Button seats)
        {
            if (seats.BackColor == Color.Gold)
            {
                seats.BackColor = Color.DeepPink;
                seats.Text = "Reserved";
                Counter++;
            }
            else
            {
                seats.BackColor = Color.Gold;
                seats.Text = "Select your seat please";
                Counter--;
            }
            count.Text = Counter.ToString();
            Price.Text = Counter * 5 + "AZN";
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            SeatSelector(button10);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            SeatSelector(button17);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            SeatSelector(button16);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            SeatSelector(button15);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            SeatSelector(button14);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            SeatSelector(button13);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            SeatSelector(button12);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            SeatSelector(button11);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            SeatSelector(button18);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SeatSelector(button9);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SeatSelector(button8);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SeatSelector(button7);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SeatSelector(button6);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SeatSelector(button5);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SeatSelector(button4);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SeatSelector(button3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SeatSelector(button2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SeatSelector(button1);
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            SeatSelector(button19);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SeatSelector(Button1);
        }
    }
}
