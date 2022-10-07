using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6_Assignment
{
    public partial class Form1 : Form
    {
        public class Bottle
        {
            int[] height = { 10, 15, 20, 30, 40 };
            int[] volume = { 2, 6, 8, 12, 25 };

            public void bottleHeight()
            {
                for (int i = 0; i < height.Length - 1; i++)
                {
                    MessageBox.Show("height of the bottle = " + height[i]);
                }
            }
            public void bottleVolume()
            {
                for (int i = 0; i < volume.Length - 1; i++)
                {
                    MessageBox.Show("volume of the bottle =" + volume[i] + " litres");
                }
            }
        }
        
        

        

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Bottle k = new Bottle();
            k.bottleHeight();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bottle k = new Bottle();
            k.bottleVolume();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bottle k = new Bottle();
            k.bottleHeight();
        }
    }
}