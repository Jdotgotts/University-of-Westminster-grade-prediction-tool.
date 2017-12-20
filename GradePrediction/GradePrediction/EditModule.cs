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
    public partial class EditModule : Form
    {
        private Module md;
        int credits;


        Boolean level4, level5, level6 = false;

        public static int totalCredits4 = 0;
        public static int totalCredits5 = 0;
        public static int totalCredits6 = 0;


        List<Module> moduleList = new List<Module>();

        Boolean exists = false;

        internal Module MD
        {
            get { return md; }
            set { md = value; }
        }
        public EditModule(Boolean lvl4, Boolean lvl5, Boolean lvl6, List<Module> moduleList)
        {
            InitializeComponent();

            this.level4 = lvl4;
            this.level5 = lvl5;
            this.level6 = lvl6;

            this.moduleList = moduleList;
        }

        private void EditModule_Load(object sender, EventArgs e)
        {
            this.moduleNameTxt.Text = MD.ModuleName;
            this.moduleCodeTxt.Text = MD.ModuleCode;
            if(MD.ModuleCredits == 20)
            {
                checkbox20.Checked = true;
            }
            else if(MD.ModuleCredits == 40)
            {
                checkbox40.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkbox20.Checked)
            {
                credits = 20;
            }
            else if (checkbox40.Checked)
            {
                credits = 40;
            }
            if (checkbox20.Checked && !moduleNameTxt.Text.Equals("") && !moduleCodeTxt.Text.Equals("") || checkbox40.Checked && !moduleNameTxt.Text.Equals("") && !moduleCodeTxt.Text.Equals(""))
            {

                for(int i = 0; i < moduleList.Count; i++)
                {
                    if (this.moduleNameTxt.Text.Equals(moduleList[i].ModuleName) || this.moduleCodeTxt.Text.Equals(moduleList[i].ModuleCode))
                    {
                       
                        exists = true;
                    }
                }


                if (exists)
                {
                    MessageBox.Show("Module already exists, please change.");
                    exists = false;
                }
                else
                {

                    



                    if (level4)
                    {




                        if (totalCredits4 == 120)
                        {


                            totalCredits4 = totalCredits4 - MD.ModuleCredits;

                            int tempCredits = totalCredits4;
                            totalCredits4 = totalCredits4 + credits;


                            if (totalCredits4 > 121)
                            {
                                MessageBox.Show("Credits exceeds 120. Credits are currently: " + tempCredits + " Please ammend.");
                                totalCredits4 = 120;
                            }
                            else
                            {
                                MD.ModuleName = this.moduleNameTxt.Text;
                                MD.ModuleCode = this.moduleCodeTxt.Text;
                                MD.ModuleCredits = credits;
                                this.Close();
                            }

                        }

                        else
                        {


                            int tempCredits = totalCredits4;
                            totalCredits4 = totalCredits4 + credits;
                            if (totalCredits4 > 121)
                            {
                                MessageBox.Show("Credits exceeds 120. Credits are currently: " + tempCredits + " Please ammend.");
                                totalCredits4 = totalCredits4 - credits;
                            }


                            else
                            {

                                MD.ModuleName = this.moduleNameTxt.Text;
                                MD.ModuleCode = this.moduleCodeTxt.Text;
                                MD.ModuleCredits = credits;
                                this.Close();

                            }


                        }
                    }

                    if (level5)
                    {


                        if (totalCredits5 == 120)
                        {


                            totalCredits5 = totalCredits5 - MD.ModuleCredits;

                            int tempCredits = totalCredits5;
                            totalCredits5 = totalCredits5 + credits;


                            if (totalCredits5 > 121)
                            {
                                MessageBox.Show("Credits exceeds 120. Credits are currently: " + tempCredits + " Please ammend.");
                                totalCredits5 = 120;
                            }
                            else
                            {
                                MD.ModuleName = this.moduleNameTxt.Text;
                                MD.ModuleCode = this.moduleCodeTxt.Text;
                                MD.ModuleCredits = credits;
                                this.Close();
                            }

                        }

                        else
                        {


                            int tempCredits = totalCredits5;
                            totalCredits5 = totalCredits5 + credits;
                            if (totalCredits5 > 121)
                            {
                                MessageBox.Show("Credits exceeds 120. Credits are currently: " + tempCredits + " Please ammend.");
                                totalCredits5 = totalCredits5 - credits;
                            }


                            else
                            {

                                MD.ModuleName = this.moduleNameTxt.Text;
                                MD.ModuleCode = this.moduleCodeTxt.Text;
                                MD.ModuleCredits = credits;
                                this.Close();

                            }


                        }


                    }

                    if (level6)
                    {



                        if (totalCredits6 == 120)
                        {


                            totalCredits6 = totalCredits6 - MD.ModuleCredits;

                            int tempCredits = totalCredits6;
                            totalCredits6 = totalCredits6 + credits;

                            if (totalCredits6 > 121)
                            {
                                MessageBox.Show("Credits exceeds 120. Credits are currently: " + tempCredits + " Please ammend.");
                                totalCredits6 = 120;
                            }
                            else
                            {
                                MD.ModuleName = this.moduleNameTxt.Text;
                                MD.ModuleCode = this.moduleCodeTxt.Text;
                                MD.ModuleCredits = credits;
                                this.Close();
                            }

                        }

                        else
                        {


                            int tempCredits = totalCredits6;
                            totalCredits6 = totalCredits6 + credits;
                            if (totalCredits6 > 121)
                            {
                                MessageBox.Show("Credits exceeds 120. Credits are currently: " + tempCredits + " Please ammend.");
                                totalCredits6 = totalCredits6 - credits;
                            }


                            else
                            {

                                MD.ModuleName = this.moduleNameTxt.Text;
                                MD.ModuleCode = this.moduleCodeTxt.Text;
                                MD.ModuleCredits = credits;
                                this.Close();

                            }


                        }

                    }

                }
          
            }
            else
            {
                MessageBox.Show("Please fill in all of the fields");
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAssessments va = new ViewAssessments();
            va.MD = this.MD;
            va.Activate();
            va.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
}
