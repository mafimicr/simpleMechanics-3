using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleMechanics_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool answer;
            int number1 = 10, number2 = 15, number3 = 5, number4 = 75, number5 = 3;

            answer = 5 < 10;
            answer = 6 < 10;
            answer = 6 > 10.0;
            answer = 60 > 10;
            answer = 200 > 10;
            answer = 100.0 > 200.000;
            answer = 3 == 3;
            answer = 16 == (64 / 4);
            answer = 10 == (2 * 5);
            answer = (16 != 12);
            answer = 20 != 20.0001;
            answer= 3<= 4;
            answer = 13 <= 67;
            answer = 15 <= 98.0;
            answer = 14 >= 3;
            answer = 25 >= 10;
            answer = 20 >= 13;
            answer = (2*8) >= 10;
            answer = (10*100) >= (10*5);
            answer = (3*100) >= (30*10);
            if (4 > 1)
            {
                answer = true;
            }
            if (11 > 5)
            {
                answer = true;       
            }
            if (42 > 34)
            {
                answer = true;
            }
            if (155 > 64)
            {
                answer = true;
            }
            if (10 > -29)
            {
                answer = true;
            }
            if (11.6 > 11.5)
            {
                answer = true;
            }
            if (number1 > 1)
            {
                answer = true;
            }
            if (19 > number1)
            {
                answer = true;
            }
            if (20 > number2)
            {
                answer = true;
            }
            if (number2 < 32)
            {
                answer = true;
            }
            if (number2 > 21)
            {
                answer = true;
            }
            if (number2 > 15.5)
            {
                answer = true;
            }
            if (number3 == 5)
            {
                answer = true;
            }
            if (number4 == 75)
            {
                answer = true;
            }
            if (number5 == 3)
            {
                answer = true;
            }
            if (number1 != 3)
            {
                answer = true;
            }
            if (number2 != 16)
            {
                answer = true;
            }
            if (number3 != 1)
            {
                answer = true;
            }
            if (4 > 1)
            {
                answer = true;
            }
            if (number4 != 81)
            {
                answer = true;
            }
            if (number5 != 1)
            {
                answer = true;
            }


            if (4 > 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (11 > 5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (10 > -29)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (11.6 > 11.5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (number1 > 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (19 > number1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (number2 < 32)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (number5 ==5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (number1 != 3)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (number5 != 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (number2 > 1)
            {
                answer = true;
            }
            else
            {
                if (number2 > -45)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number2 > 1)
            {
                answer = true;
            }
            else if (number2 > -45)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            if (number3 < 34)
            {
                answer = true;
            }else if (number3 < 64)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
        }
    }
}
