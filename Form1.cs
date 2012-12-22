using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        // holds location of files
        string[] files = {null};
        // variable to hold position in array
        int i = 0;

        // check that a folder is selected
        bool folderSelected = false;
        
        public Form1()
        {
            InitializeComponent();
            //allow key input
            this.KeyPreview = true;
            //assigns Form1_KeyPress method to key down
            this.KeyDown +=  new KeyEventHandler(Form1_KeyPress);
        }

        private void Next_Event()
        {
            // if the position is at the end of the array go back to the start
            if (i == files.Length - 1)
            {
                i = 0;

            }
            else
            {
                // otherwise progress to the next file
                i++;
            }

            // safety check that a folder has been selected
            if (folderSelected)
            {
                // load new file 
                pictureBox1.Load(files[i]);
            }
            
        }

        private void back_Event()
        {
            // if array location is 0 set next location to end of the array
            if (i == 0)
            {
                i = files.Length - 1;
            }
            else
            {
                // otherwise go back one position in the array
                i--;
            }
            // safety check that the folder has been selected
            if (folderSelected)
            {
                // load new file
                pictureBox1.Load(files[i]);
            }
                        
        }

        void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            // if "B" is pressed
            if (e.KeyData == Keys.B)
            {
                // previous file displayed
                back_Event();
                // event has been handled
                e.Handled = true ;
            }
            // if "N" is pressed
            if (e.KeyData == Keys.N)
            {
                // display next file
                Next_Event();
                // event has been handled
                e.Handled = true ;
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            // show previous file
            back_Event();
        }

        private void Photos_Click(object sender, EventArgs e)
        {
            if (photoBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // get all jpg files from the directory and put location strings in the array files
                files = Directory.GetFiles(photoBrowserDialog.SelectedPath, "*.jpg");

                // sets that a folder is selected more usefull when the extra file types are supported
                folderSelected = true;

                // display file in image box
                pictureBox1.Load(files[i]);

            }
        }

        private void Show_Controls(object sender, EventArgs e)
        {
            if (ControlPanel.Visible)
            {
                ControlPanel.Visible = false;
                //tableLayoutPanel1.RowCount = 1;
                
              
            }
            else if (!ControlPanel.Visible)
            {
                ControlPanel.Visible = true;
                //tableLayoutPanel1.RowCount = 2;
            }
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            // go to next image
            Next_Event();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // go to next image
            Next_Event();
        }

        private void Play_Click_1(object sender, EventArgs e)
        {
            // start and stop timer
            switch (timer1.Enabled)
            {
                case true:
                    {
                        timer1.Enabled = false;
                        //timer1.Stop();
                        break;
                    }
                case false:
                    {
                        timer1.Enabled = true;
                        break;
                    }
            }
        }

        private void Films_Click(object sender, EventArgs e)
        {

        }

        private void Music_Click(object sender, EventArgs e)
        {

        }

        private void musicFolderDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void filmsBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void photoBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

    }
}
