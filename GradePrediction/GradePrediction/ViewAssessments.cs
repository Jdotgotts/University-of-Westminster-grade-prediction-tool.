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
    public partial class ViewAssessments : Form
    {
        private Module md;
        List<Assessment> assessmentList = new List<Assessment>();
        int totalWeight = 0;
      
        int y = 10;
        internal Module MD
        {
            get { return md; }
            set { md = value; }
        }

    
        public ViewAssessments()
        {
            InitializeComponent();
          
        }

        private void EditAssessment_Load(object sender, EventArgs e)
        {
            assessmentList = MD.ReturnAssessment();

            for(int i = 0; i < assessmentList.Count; i++)
            {
                Label lbl = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                Button btn = new Button();
                Button btn2 = new Button();
         

                lbl.Text = assessmentList[i].AssessmentName;
               lbl2.Text = assessmentList[i].AssessmentWeighting.ToString() + "%";
                lbl3.Text = assessmentList[i].AssessmentMark.ToString() + "%";

                if (assessmentList[i].AssessmentMark > 30)
                {
                    lbl3.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    lbl3.ForeColor = System.Drawing.Color.Red;
                }

                totalWeight = totalWeight + assessmentList[i].AssessmentWeighting;

                btn.Name = assessmentList[i].AssessmentName;
                btn2.Name = assessmentList[i].AssessmentName;
               


                btn.Click += new EventHandler(btn_Click);
                btn2.Click += new EventHandler(btn2_Click);
           

                btn.Text = "Edit";
                btn2.Text = "Delete";

                lbl.AutoSize = true;

                lbl.Location = new Point(15,y);
                lbl2.Location = new Point(213,y);
                lbl3.Location = new Point(355,y);
         
                btn.Location = new Point(500, y);
                btn2.Location = new Point(590, y);
            
                this.assessmentTab.Controls.Add(lbl);
                this.assessmentTab.Controls.Add(lbl2);
                this.assessmentTab.Controls.Add(lbl3);
                this.assessmentTab.Controls.Add(btn);
                this.assessmentTab.Controls.Add(btn2);
      

                y = y + 40;
            }
            y = 10;

           
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i < assessmentList.Count; i++)
            {
                if (btn.Name.Equals(assessmentList[i].AssessmentName))
                {
                    string name;
                    int mark, weight;
                    name = assessmentList[i].AssessmentName;
                    mark = assessmentList[i].AssessmentMark;
                    weight = assessmentList[i].AssessmentWeighting;
                    EditAssessment ea = new EditAssessment(name,mark,weight);
                   
                    ea.FormClosing += new FormClosingEventHandler(this.EditAssessment_FormClosing);
                    ea.AS = assessmentList[i];
                    ea.MD = this.MD;
                    ea.Activate();

                    EditAssessment.totalWeight = totalWeight;
                    ea.ShowDialog();
                }
            }
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure want to delete this assessment?",
                                    "assessment Delete",
                                    MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes) { 
            Button btn = sender as Button;
            for (int i = 0; i < assessmentList.Count; i++)
            {
                if (btn.Name.Equals(assessmentList[i].AssessmentName))
                {
                        totalWeight = totalWeight - assessmentList[i].AssessmentWeighting;
                        assessmentList.Remove(assessmentList[i]);
                        
                    MD.UpdateList(assessmentList);
                }
            }
        }
            Update();
        }


        private void EditAssessment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            totalWeight = 0;
            this.assessmentTab.Controls.Clear();
            assessmentList = MD.ReturnAssessment();

            for (int i = 0; i < assessmentList.Count; i++)
            {
                Label lbl = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                Button btn = new Button();
                Button btn2 = new Button();


                lbl.Text = assessmentList[i].AssessmentName;
                lbl2.Text = assessmentList[i].AssessmentWeighting.ToString() + "%";
                lbl3.Text = assessmentList[i].AssessmentMark.ToString() + "%";

                if(assessmentList[i].AssessmentMark > 30)
                {
                    lbl3.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    lbl3.ForeColor = System.Drawing.Color.Red;
                }

                totalWeight = totalWeight + assessmentList[i].AssessmentWeighting;

                btn.Name = assessmentList[i].AssessmentName;
                btn2.Name = assessmentList[i].AssessmentName;
                btn.Click += new EventHandler(btn_Click);
                btn2.Click += new EventHandler(btn2_Click);

                lbl.AutoSize = true;

                btn.Text = "Edit";
                btn2.Text = "Delete";

                lbl.Location = new Point(15, y);
                lbl2.Location = new Point(213, y);
                lbl3.Location = new Point(355, y);
                btn.Location = new Point(500, y);
                btn2.Location = new Point(590, y);

                this.assessmentTab.Controls.Add(lbl);
                this.assessmentTab.Controls.Add(lbl2);
                this.assessmentTab.Controls.Add(lbl3);
                this.assessmentTab.Controls.Add(btn);
                this.assessmentTab.Controls.Add(btn2);

                y = y + 40;
            }
            y = 10;

        }

      





        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalWeight >= 100)
            {
                MessageBox.Show("Assessments exceed max weighting (100%), please edit or delete one.");
            }
            else
            {

                addAssessment addAssess = new addAssessment();
               addAssess.FormClosing += new FormClosingEventHandler(this.addAssessment_FormClosing);
                addAssess.Activate();
                addAssessment.totalWeight = totalWeight;
                addAssess.MD = this.MD;
                addAssess.ShowDialog();
            }
        }


        private void addAssessment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Update();
        }
    }
}
