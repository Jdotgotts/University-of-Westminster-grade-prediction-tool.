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
    public partial class addAssessment : Form
    {
        private Assessment ad;
      public static int totalWeight = 0;
       
        Module md = new Module();


        internal Assessment AD
        {
            get { return ad; }
            set { ad = value; }
        }

        internal Module MD
        {
            get { return md; }
            set { md = value; }
        }

        public addAssessment()
        {
            InitializeComponent();
        }

        private void addAssessmentBtn_Click(object sender, EventArgs e)
        {
            string name =  "";
            int mark = 0;
            int weight = 0;
            int previousWeight = 0;
         
       



                if (assessmentMarkTxt.Text == "" || assessmentWeightingTxt.Text == "" || assessmentNameTxt.Text == "")
                {
                    MessageBox.Show("Please fill in all boxes.");
                }
                else
                {
                    name = assessmentNameTxt.Text;
                    mark = Convert.ToInt32(assessmentMarkTxt.Value);
                    weight = Convert.ToInt32(assessmentWeightingTxt.Text);
                int tempWeight = totalWeight;
                totalWeight = totalWeight + weight;
                if (totalWeight > 101)
                {
                    MessageBox.Show("Weight exceeds 100%. Weight is currently: " + tempWeight + "%");
                    totalWeight = totalWeight - weight;
                    weight = 0;
                }
                else
                {



                    if (mark > 100)
                    {
                        mark = 100;
                    }

                    else if (totalWeight < 100)
                    {
                        MD.AddAssessment(name, mark, weight);
                        MessageBox.Show("Assessment added. Please add another until weighting is 100%");
                        assessmentNameTxt.Text = "";
                        assessmentMarkTxt.Text = "";
                        assessmentWeightingTxt.Text = "";
                        remainWeighting.Text = "Remaining Weight: " + totalWeight.ToString() + " / " + "100";
                    }
                    else
                    {
                        MD.AddAssessment(name, mark, weight);
                        totalWeight = 0;
                        this.Close();
                    }

                }


            }
        }

        private void addAssessment_Load(object sender, EventArgs e)
        {
            remainWeighting.Text = "";
        }
    }
}
