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
    public partial class EditAssessment : Form
    {
        private Module md;
       private Assessment asses;
        string name;
        int mark, weight;

        public static int totalWeight = 0;

        internal Module MD
        {
            get { return md; }
            set { md = value; }
        }
        internal Assessment AS
        {
            get { return asses; }
            set { asses = value; }
        }

        public EditAssessment(string name, int mark, int weight)
        {
            InitializeComponent();
            this.name = name;
            this.mark = mark;
            this.weight = weight;
           

        }

        private void addAssessmentBtn_Click(object sender, EventArgs e)
        {
   
            if (assessmentMarkTxt.Text == "" || assessmentWeightingTxt.Text == "" || assessmentNameTxt.Text == "")
            {
                MessageBox.Show("Please fill in all boxes.");
            }
            else
            {
                int previousWeight = 0;
                if (totalWeight == 100)
                {
               
                    totalWeight = totalWeight - weight;
                    previousWeight = previousWeight + totalWeight;
                    int newWeight = int.Parse(this.assessmentWeightingTxt.Text);
                    totalWeight = totalWeight + newWeight;
                    if(totalWeight > 101)
                    {
                        MessageBox.Show("Weight exceeds 100. Weight is currently: " + previousWeight + " Please ammend.");
                        totalWeight = 100;
                    }
                    else
                    {
                        AS.AssessmentName = this.assessmentNameTxt.Text;
                        AS.AssessmentWeighting = int.Parse(this.assessmentWeightingTxt.Text);
                        AS.AssessmentMark = int.Parse(this.assessmentMarkTxt.Text);

                        this.Close();
                    }

                }
                else
                {
                    int newWeight = int.Parse(this.assessmentWeightingTxt.Text);
                    previousWeight = previousWeight + totalWeight;
                    totalWeight = totalWeight + newWeight;
                    if (totalWeight > 101)
                    {
                        MessageBox.Show("Weight exceeds 100. Weight is currently: " + previousWeight + " Please ammend.");
                        totalWeight = totalWeight - newWeight;
                    }
                    else
                    {


                        AS.AssessmentName = this.assessmentNameTxt.Text;
                        AS.AssessmentWeighting = int.Parse(this.assessmentWeightingTxt.Text);
                        AS.AssessmentMark = int.Parse(this.assessmentMarkTxt.Text);

                        this.Close();
                    }
                }

         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Close();
            this.Dispose();
        }

        private void EditAssessment_Load(object sender, EventArgs e)

        
        {

            Console.WriteLine("Total Weight: " + totalWeight);
            this.assessmentNameTxt.Text = name;
            this.assessmentWeightingTxt.Text = weight.ToString();
            this.assessmentMarkTxt.Text = mark.ToString();
        }
    }
}
