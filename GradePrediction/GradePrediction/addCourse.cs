using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradePrediction
{
    public partial class addCourseForm : Form
    {

        private Course cd;
        internal Course CD
        {
            get { return cd; }
            set { cd = value; }
        }
        public addCourseForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cd = new Course();
            cd.CourseName = this.courseNameTxt.Text;
            cd.CourseCode = this.courseCodeTxt.Text;
            Level_Select levelSelectForm = new Level_Select();
            levelSelectForm.CD = this.CD;
            this.Close();
            this.Dispose();
            levelSelectForm.Activate();
            levelSelectForm.ShowDialog();
            
            
        }

        private void addCourseForm_Load(object sender, EventArgs e)
        {
             
        }
    }
}
