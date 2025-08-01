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
    public partial class ArrayForm : Form
    {
        int[] num = new int[6];
        int count = 0;
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void Btn1DArr_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            // Example of a one-dimensional array in C# manually initialized
            //int total = 0;
            //int[] num =new int[]{ 1, 2, 3, 4, 5, 6, 10, 11 };
            //num[2] = 100; // Change the value at index 2 to 100
            //for (int i = 0; i < num.Length; i++)
            //{
            //    total += num[i];
            //    listBox.Items.Add($"Num[{i}]: {num[i]}");
            //}
            //listBox.Items.Add("Total is: " + total);

            //-----------------------------------------------------------

            // Example of a one-dimensional array in C# using a loop to initialize
            //Loop throught 10 times 10 numbers
            //int total = 0;
            //int[] num = new int[10];
            //for (int i = 0; i < num.Length; i++){
            //    num[i] = (10 - i) * 10;
            //    total += num[i];
            //    listBox.Items.Add(num[i]);
            //}
            //listBox.Items.Add("Total: " + (int)total);


            //int total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                //num[i] = 5;
                //num[i] = (i == 0) ? 5: i*10; //Tenary
                if (i == 0)
                {
                    num[i] = 5;
                }
                else
                {
                    num[i] = i * 10;
                }
                listBox.Items.Add($"num[{i}]:" + num[i]);
            }

        }

        private void Btn2DArr_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            int total = 0;
            int[,] Arr2D = new int[3, 4]; // 3 rows, 4 columns
            int value = 1; // Start from 1

            // Fill the array with values 1 to 12
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Arr2D[i, j] = value;
                    value++;
                }
            }

            // Calculate total
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    total += Arr2D[i, j];
                }
            }

            // Create rows based on your custom condition
            string oddRow = "Odd : ";
            string evenRow = "Even: ";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int number = Arr2D[i, j];

                    if (number < 10 && number % 2 == 1) // 1,3,5,7,9
                        oddRow += number.ToString().PadLeft(4);
                    else if (number >= 10)              // 10,11,12
                        evenRow += number.ToString().PadLeft(4);
                }
            }

            // Display in ListBox
            listBox.Items.Add(oddRow);
            listBox.Items.Add(evenRow);
            listBox.Items.Add("-------------------");
            listBox.Items.Add("Total: " + total);

        }
        private void BtnInputNum_Click(object sender, EventArgs e)
        {
            if (count != num.Length)
            {
                num[count++] = int.Parse(TxtNumber.Text);
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
            else
            {
                MessageBox.Show("Array is full, please reset the array to add more numbers.");
            }
        }
    }
}
