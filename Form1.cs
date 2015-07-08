using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timeConsumingButton_Click(object sender, EventArgs e)
        {
            timeConsumingButton.Enabled = false;
            printButton.Enabled = false;

            Thread workerThread = new Thread(waitMinutes);
            workerThread.Start();
            //waitMinutes();

            timeConsumingButton.Enabled = true;
            printButton.Enabled = true;

        }

        private void waitMinutes()
        {
            System.Threading.Thread.Sleep(5000);
        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Numbers.Items.Add(i);
            }

        }

        

    }
}
