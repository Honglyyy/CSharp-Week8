using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatResponsivDesign
{
    public partial class UC_Daily : UserControl
    {
        int n;
        public UC_Daily()
        {
            InitializeComponent();
        }
        private void userInput()
        {
            listBox.Items.Clear();
            n = int.Parse(numberTxt.Text);
        }
        private void printResult(int result)
        {
            totalTxt.Text = result.ToString();
        }
        //Sum Button function
        private int normalSum()
        {
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                listBox.Items.Add(i);
                sum += i;
            }
            return sum;
        }
        private int evenSum()
        {
            int sum = 0;
            for (int i = 0; i <= n; i += 2)
            {
                listBox.Items.Add(i);
                sum += i;
            }
            return sum;
        }
        private int oddSum()
        {
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                listBox.Items.Add(i);
                sum += i;
            }
            return sum;
        }

        private int powerSum()
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                listBox.Items.Add(i);
                sum += (i * i);
            }
            return sum;
        }
        private int facSum()
        {
            
            int sum = 1;

            for (int i = 1; i <= n; i++)
            {
                listBox.Items.Add(i);
                sum *= i;
            }
            return sum;
        }
        private int fibSum()
        {
            int a = 0, b = 1, sum = 0;

            for (int i = 0; i <= n; i++)
            {
                listBox.Items.Add(a);
                sum += a;

                int next = a + b;
                a = b;
                b = next;
            }
            return sum;
        }
        // normalSum() return sum meaning normalSum = sum
        private void sumBtn_Click(object sender, EventArgs e)
        {
            userInput();
            int result = normalSum();
            printResult(result);
           
        }
    
        private void evenBtn_Click(object sender, EventArgs e)
        {
            userInput();
            int result = evenSum();
            printResult(result);
        }

        private void oddBtn_Click(object sender, EventArgs e)
        {
            userInput();
            int result = oddSum();
            printResult(result);
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            userInput();
            int result = powerSum();
            printResult(result);
        }

        private void facBtn_Click(object sender, EventArgs e)
        {
            userInput();
            int result = facSum();
            printResult(result);
        }

        private void fibBtn_Click(object sender, EventArgs e)
        {
            userInput();
            int result = fibSum();
            printResult(result);
        }

    }
}
