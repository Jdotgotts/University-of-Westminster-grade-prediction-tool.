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
    public partial class AddModule : Form
    {
        private Module md;

        List<Module> moduleListlvl4 = new List<Module>();
        List<Module> moduleListlvl5 = new List<Module>();
        List<Module> moduleListlvl6 = new List<Module>();

        List<Module> moduleList = new List<Module>();

        Boolean exists = false;

        int credits, maxCredits, previousCredits;

        internal Module MD

        {
            get { return md; }
            set { md = value; }
        }
        public AddModule(List<Module> moduleList, int credits)
        {
            InitializeComponent();
            this.moduleList = moduleList;
            this.maxCredits = credits;
        }

        private void AddModule_Load(object sender, EventArgs e)
        {


      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            md = new Module();

            if (checkbox20.Checked) {
                credits = 20;
            }
            else if (checkbox40.Checked) {
                credits = 40;
            }






            if (checkbox20.Checked && !moduleNameTxt.Text.Equals("") && !moduleCodeTxt.Text.Equals("") || checkbox40.Checked && ! moduleNameTxt.Text.Equals("") && ! moduleCodeTxt.Text.Equals(""))
            {
                exists = false;

                md.ModuleName = this.moduleNameTxt.Text;
                md.ModuleCode = this.moduleCodeTxt.Text;
                try
                {
                    for (int i = 0; i < moduleList.Count; i++)
                    {


                        if (moduleList[i].ModuleName.Equals(this.moduleNameTxt.Text) || moduleList[i].ModuleCode.Equals(this.moduleCodeTxt.Text))
                        {
                            exists = true;
                        }


                    }

                    if (exists)
                    {
                        System.Windows.Forms.MessageBox.Show("Module already exists, please change.");
                    }
                    else
                    {

                        previousCredits = maxCredits;
                        maxCredits = maxCredits + credits;

                        if (maxCredits > 120)
                        {
                            MessageBox.Show("Exceeds Max Credits, Please change.");
                            maxCredits = previousCredits;
                        }
                        else
                        {


                            if (credits == 0)
                            {

                            }
                            else
                            {
                                md.ModuleCredits = credits;
                            }
                            addAssessment addAssessmentForm = new addAssessment();
                            addAssessmentForm.MD = this.MD;
                            this.Close();
                            addAssessmentForm.Activate();
                            addAssessmentForm.ShowDialog();
                            this.Dispose();
                        }
                    }


                }
                catch(NullReferenceException ERROR)
                {
                    Console.WriteLine(ERROR);
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please fill in all of the fields");
            }


            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void moduleCreditNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
