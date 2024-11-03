using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageSlideshowApp
{
    public partial class Form1 : Form
    {

        

        private string[] imagePaths = new string[]
        {
            "E:\\University\\Third year\\Term 1\\Visual Programming\\Tasks\\ImageSlideshowApp\\images\\1.jpg",
            "E:\\University\\Third year\\Term 1\\Visual Programming\\Tasks\\ImageSlideshowApp\\images\\2.jpg",
            "E:\\University\\Third year\\Term 1\\Visual Programming\\Tasks\\ImageSlideshowApp\\images\\3.jpg",
            "E:\\University\\Third year\\Term 1\\Visual Programming\\Tasks\\ImageSlideshowApp\\images\\4.jpg",
            "E:\\University\\Third year\\Term 1\\Visual Programming\\Tasks\\ImageSlideshowApp\\images\\5.jpg"
        };

        private int currentIndex = 0; 

        public Form1()
        {
            InitializeComponent();
            DisplayImage(); 
        }

        
        private void DisplayImage()
        {
            if (imagePaths.Length > 0)
            {
                pictureBox1.ImageLocation = imagePaths[currentIndex];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length; 
            DisplayImage();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Length) % imagePaths.Length; 
            DisplayImage();
        }
    }
}
