using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradePrediction
{
    public partial class BuildCourseForm : Form
    {
        public BuildCourseForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (File.Exists("SavedData.xml"))
            {
                var confirmation = MessageBox.Show("Previous save found, would you like to load?",
                                   "Load State",
                                   MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {

                    Level_Select levelSelectForm = new Level_Select();
                   Level_Select.loadState = true;
                    this.Hide();
                    levelSelectForm.Activate();
                    levelSelectForm.ShowDialog();
                    this.Dispose();
           
      

                }
                else
                {

                    addCourseForm courseForm = new addCourseForm();
                    
                    courseForm.Activate();
                    courseForm.ShowDialog();

                }


            }
            else
            {
                addCourseForm courseForm = new addCourseForm();

                courseForm.Activate();
                courseForm.ShowDialog();

            }

        }



        private void BuildCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BuildCourseForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
