using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GradePrediction
{
    public partial class Summary : Form

    {
        Module md = new Module();


        List<Module> moduleListlvl4 = new List<Module>();
        List<Module> moduleListlvl5 = new List<Module>();
        List<Module> moduleListlvl6 = new List<Module>();
        List<Assessment> assessmentList = new List<Assessment>();

        List<Module> sortedlvl5List = new List<Module>();
        List<Module> sortedlvl6List = new List<Module>();


        List<int> lvl5Modules = new List<int>();
        List<int> lvl6Modules = new List<int>();

        double yearOutcome = 0.0;

        int lvl4Y = 105;
        int lvl5Y = 445;
        int lvl6Y = 744;

        int totalWeight = 0;
        double overall2 = 0;

        Course cd = new Course();

        internal Module MD
        {
            get { return md; }
            set { md = value; }
        }

        internal Course CD
        {
            get { return cd; }
            set { cd = value; }
        }


        public Summary()
        {
            InitializeComponent();
        }


        public Summary(List<Module> moduleList4, List<Module> moduleList5, List<Module> moduleList6)
        {
            InitializeComponent();
            this.moduleListlvl4 = moduleList4;
            this.moduleListlvl5 = moduleList5;
            this.moduleListlvl6 = moduleList6;
        }

        private void Summary_Load(object sender, EventArgs e)
        {
           
            int grade, weight;
            double overall = 0;
            awardLbl.Text = "";
            lvl4Outcome.Text = "";
            lvl5Outcome.Text = "";
            lvl6Outcome.Text = "";


            for (int i = 0; i < moduleListlvl4.Count; i++)
            {
                Label lbl4 = new Label();

                Label lbl = new Label();

                lbl.Text = moduleListlvl4[i].ModuleCredits.ToString();
                lbl.Location = new Point(52, lvl4Y);

                Label lbl2 = new Label();
                lbl2.Text = moduleListlvl4[i].ModuleCode;
                lbl2.Location = new Point(157, lvl4Y);

                Label lbl3 = new Label();
                lbl3.Text = moduleListlvl4[i].ModuleName;
                lbl3.Location = new Point(288, lvl4Y);

                this.Controls.Add(lbl);
                this.Controls.Add(lbl2);
                this.Controls.Add(lbl3);
                lbl3.AutoSize = true;

                assessmentList = moduleListlvl4[i].ReturnAssessment();

                for (int y = 0; y < assessmentList.Count; y++)
                {




                 

                    grade = assessmentList[y].AssessmentMark;
                    weight = assessmentList[y].AssessmentWeighting;

                    totalWeight = totalWeight + weight;


                    overall = grade * weight;
                    overall2 = overall2 + overall;



             



                





                }
                overall = overall2 / 100;
                lbl4.Text = overall.ToString() + "%";
                moduleListlvl4[i].ModuleMarks = overall;
                lbl4.Location = new Point(720, lvl4Y);
                this.Controls.Add(lbl4);
              

                if (overall < 40)
                {

                    lbl4.ForeColor = System.Drawing.Color.Red;
                    Label lblOutcome = new Label();
                    lblOutcome.Text = "Fail";
                    lblOutcome.Location = new Point(862, lvl4Y);
                    this.Controls.Add(lblOutcome);
                }
                else
                {
                    lbl4.ForeColor = System.Drawing.Color.Blue;
                    Label lblOutcome = new Label();
                    lblOutcome.Text = "Pass";
                    lblOutcome.Location = new Point(862, lvl4Y);

                    this.Controls.Add(lblOutcome);
                }

                totalWeight = 0;
                overall2 = 0;

                lvl4Y = lvl4Y + 40;
            }
          



            for (int i = 0; i < moduleListlvl5.Count; i++)
            {

                Label lbl = new Label();
                lbl.Text = moduleListlvl5[i].ModuleCredits.ToString();
                lbl.Location = new Point(52, lvl5Y);

                Label lbl2 = new Label();
                lbl2.Text = moduleListlvl5[i].ModuleCode;
                lbl2.Location = new Point(157, lvl5Y);

                Label lbl3 = new Label();
                lbl3.Text = moduleListlvl5[i].ModuleName;
                lbl3.Location = new Point(288, lvl5Y);

                Label lbl4 = new Label();
                lbl3.AutoSize = true;
                this.Controls.Add(lbl);
                this.Controls.Add(lbl2);
                this.Controls.Add(lbl3);


                assessmentList = moduleListlvl5[i].ReturnAssessment();





                for (int y = 0; y < assessmentList.Count; y++)
                {


          


         

                    grade = assessmentList[y].AssessmentMark;
                    weight = assessmentList[y].AssessmentWeighting;

                    totalWeight = totalWeight + weight;





                    overall = grade * weight;
                    overall2 = overall2 + overall;



        








                }

                overall = overall2 / 100;
                lbl4.Text = overall.ToString() + "%";
                moduleListlvl5[i].ModuleMarks = overall;
                lbl4.Location = new Point(720, lvl5Y);
                this.Controls.Add(lbl4);



                if (overall < 40)
                {
                    lbl4.ForeColor = System.Drawing.Color.Red;
                    Label lblOutcome = new Label();
                    lblOutcome.Text = "Fail";
                    lblOutcome.Location = new Point(862, lvl5Y);
                    this.Controls.Add(lblOutcome);
                }
                else
                {
                    lbl4.ForeColor = System.Drawing.Color.Blue;
                    Label lblOutcome = new Label();
                    lblOutcome.Text = "Pass";
                    lblOutcome.Location = new Point(862, lvl5Y);
                    this.Controls.Add(lblOutcome);
                }

                lvl5Y = lvl5Y + 40;

                totalWeight = 0;
                overall2 = 0;
            }



            for (int i = 0; i < moduleListlvl6.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = moduleListlvl6[i].ModuleCredits.ToString();
                lbl.Location = new Point(52, lvl6Y);

                Label lbl2 = new Label();
                lbl2.Text = moduleListlvl6[i].ModuleCode;
                lbl2.Location = new Point(157, lvl6Y);

                Label lbl3 = new Label();
                lbl3.Text = moduleListlvl6[i].ModuleName;
                lbl3.Location = new Point(288, lvl6Y);

                Label lbl4 = new Label();
                lbl3.AutoSize = true;
                this.Controls.Add(lbl);
                this.Controls.Add(lbl2);
                this.Controls.Add(lbl3);



                assessmentList = moduleListlvl6[i].ReturnAssessment();


                for (int y = 0; y < assessmentList.Count; y++)
                {




      

                    grade = assessmentList[y].AssessmentMark;
                    weight = assessmentList[y].AssessmentWeighting;

                    totalWeight = totalWeight + weight;






                    overall = grade * weight;
                    overall2 = overall2 + overall;




              




                }


                overall = overall2 / 100;
                lbl4.Text = overall.ToString() + "%";
                moduleListlvl6[i].ModuleMarks = overall;
                lbl4.Location = new Point(720, lvl6Y);
                this.Controls.Add(lbl4);



                if (overall < 40)
                {
                    lbl4.ForeColor = System.Drawing.Color.Red;
                    Label lblOutcome = new Label();
                    lblOutcome.Text = "Fail";
                    lblOutcome.Location = new Point(862, lvl6Y);
                    this.Controls.Add(lblOutcome);
                }
                else
                {
                    lbl4.ForeColor = System.Drawing.Color.Blue;
                    Label lblOutcome = new Label();
                    lblOutcome.Text = "Pass";
                    lblOutcome.Location = new Point(862, lvl6Y);
                    this.Controls.Add(lblOutcome);
                }


                totalWeight = 0;
                overall2 = 0;

                lvl6Y = lvl6Y + 40;
            }

            moduleListlvl5 = moduleListlvl5.OrderByDescending(s => s.ModuleCredits).ThenByDescending(s => s.ModuleMarks).ToList();
            moduleListlvl6 = moduleListlvl6.OrderByDescending(s => s.ModuleCredits).ThenByDescending(s => s.ModuleMarks).ToList();


            int totalCredits = 0;
            try
            {
                for (int i = 0; i < moduleListlvl5.Count; i++)
                {
                    if (totalCredits == 220)
                    {
                        break;
                    }

                    {
                        if (moduleListlvl5[i].ModuleMarks >= moduleListlvl6[i].ModuleMarks)
                        {
                            sortedlvl5List.Add(moduleListlvl5[i]);
                            totalCredits = totalCredits + moduleListlvl5[i].ModuleCredits;
                            if (totalCredits == 220)
                            {
                                break;
                            }
                            else
                            {
                                sortedlvl6List.Add(moduleListlvl6[i]);
                            }

                        }

                        else
                        {
                            sortedlvl6List.Add(moduleListlvl6[i]);
                            if (totalCredits == 220)
                            {
                                break;
                            }
                            else
                            {
                                sortedlvl5List.Add(moduleListlvl5[i]);
                            }
                        }

                    }
                }
            } catch (ArgumentOutOfRangeException exception)
            {
                awardLbl.Text = "N/A";
            }



            int level5CreditVolume = 0;
            int level6CreditVolume = 0;

            double weighinglvl5 = 0.333333;
            double weighinglvl6 = 0.666667;


            double lvl5Sum = 0;
            double lvl5Sum2 = 0;
            double lvl6Sum = 0;
            double lvl6Sum2 = 0;

      

            for (int i = 0; i < sortedlvl5List.Count; i++)
            {
                level5CreditVolume = level5CreditVolume + sortedlvl5List[i].ModuleCredits;
            }

            for (int i = 0; i < sortedlvl5List.Count; i++)
            {

                lvl5Sum = sortedlvl5List[i].ModuleMarks * sortedlvl5List[i].ModuleCredits;



                lvl5Sum = lvl5Sum / level5CreditVolume;



                lvl5Sum = lvl5Sum * weighinglvl5;



                lvl5Sum2 = lvl5Sum2 + lvl5Sum;
                lvl5Sum = 0;

            }

            for (int i = 0; i < sortedlvl6List.Count; i++)
            {
                level6CreditVolume = level6CreditVolume + sortedlvl6List[i].ModuleCredits;

            }

            for (int i = 0; i < sortedlvl6List.Count; i++)
            {
                lvl6Sum = sortedlvl6List[i].ModuleMarks * sortedlvl6List[i].ModuleCredits;


                lvl6Sum = lvl6Sum / level6CreditVolume;


                lvl6Sum = lvl6Sum * weighinglvl6;


                lvl6Sum2 = lvl6Sum2 + lvl6Sum;

            }

            int a = 0;

            double indicatorScore = lvl5Sum2 + lvl6Sum2;

            int indicator2 = (int)Math.Round(indicatorScore);

          

            if (indicator2 >= 70)
            {
                a = 1;
            }
            else if (indicator2 >= 60)
            {
                a = 2;
            }
            else if (indicator2 >= 50)
            {
                a = 3;
            }
            else if (indicator2 >= 40)
            {
                a = 4;
            }
            else if (indicator2 < 40)
            {
                a = 5;
            }

            switch (a)
            {
                case 1:
                    awardLbl.Text = "1st Class Honours";
                    break;

                case 2:
                    awardLbl.Text = "2nd Class Honours Upper Division";
                    break;

                case 3:
                    awardLbl.Text = "2nd Class Honours Lower Division ";
                    break;

                case 4:
                    awardLbl.Text = "3rd Class Honours";
                    break;
                case 5:
                    awardLbl.Text = "N/A";
                    break;



            }


            for (int i = 0; i < moduleListlvl4.Count; i++)
            {
                yearOutcome = yearOutcome + moduleListlvl4[i].ModuleMarks;


            }

            yearOutcome = yearOutcome / 7;

            yearOutcome = System.Math.Round(yearOutcome, 2);
            lvl4Outcome.Text = yearOutcome.ToString() + "%";

            if (yearOutcome >= 40)
            {
                lvl4Outcome.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lvl4Outcome.ForeColor = System.Drawing.Color.Red;
            }



            yearOutcome = 0.0;
            for (int i = 0; i < moduleListlvl5.Count; i++)
            {
                yearOutcome = yearOutcome + moduleListlvl5[i].ModuleMarks;


            }

            yearOutcome = yearOutcome / 6;

            yearOutcome = System.Math.Round(yearOutcome, 2);
            lvl5Outcome.Text = yearOutcome.ToString() + "%";

            if (yearOutcome >= 40)
            {
                lvl5Outcome.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lvl5Outcome.ForeColor = System.Drawing.Color.Red;
            }


            yearOutcome = 0.0;
            for (int i = 0; i < moduleListlvl6.Count; i++)
            {
                yearOutcome = yearOutcome + moduleListlvl6[i].ModuleMarks;


            }

            yearOutcome = yearOutcome / 5;

            yearOutcome = System.Math.Round(yearOutcome, 2);
            lvl6Outcome.Text = yearOutcome.ToString() + "%";
            if (yearOutcome >= 40)
            {
                lvl6Outcome.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lvl6Outcome.ForeColor = System.Drawing.Color.Red;
            }






        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void creditsLbl_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("SavedData.xml"))
            {
                var confirmation = MessageBox.Show("Would you like to overwrite the save?",
                                   "Overwrite",
                                   MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    String workingDir = Directory.GetCurrentDirectory();
                    // Create a new file in the working directory
                    XmlTextWriter textWriter = new XmlTextWriter("SavedData.xml", null);
                    // Opens the document
                    textWriter.WriteStartDocument();

                    textWriter.WriteStartElement("Course", "");

                    textWriter.WriteStartElement("CourseName", "");
                    textWriter.WriteString(cd.CourseName);
                    textWriter.WriteEndElement();

                    textWriter.WriteStartElement("CourseCode", "");
                    textWriter.WriteString(cd.CourseCode);
                    textWriter.WriteEndElement();

                    textWriter.WriteStartElement("Modules4", "");
                    //nested element
                    for (int i = 0; i < moduleListlvl4.Count; i++)
                    {
                        textWriter.WriteStartElement("Module", "");
                        textWriter.WriteStartElement("Name", "");
                        textWriter.WriteString(moduleListlvl4[i].ModuleName);
                        textWriter.WriteEndElement();


                        textWriter.WriteStartElement("Code", "");
                        textWriter.WriteString(moduleListlvl4[i].ModuleCode);
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Credits", "");
                        textWriter.WriteString(moduleListlvl4[i].ModuleCredits.ToString());
                        textWriter.WriteEndElement();

                        assessmentList = moduleListlvl4[i].ReturnAssessment();
                        for (int y = 0; y < assessmentList.Count; y++)
                        {
                            textWriter.WriteStartElement("Assessment", "");
                            textWriter.WriteStartElement("AssessmentName", "");
                            textWriter.WriteString(assessmentList[y].AssessmentName);
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("Mark", "");
                            textWriter.WriteString(assessmentList[y].AssessmentMark.ToString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("Weighting", "");
                            textWriter.WriteString(assessmentList[y].AssessmentWeighting.ToString());
                            textWriter.WriteEndElement();
                            textWriter.WriteEndElement();
                        }
                        textWriter.WriteEndElement();
                    }

                    textWriter.WriteEndElement();



                    textWriter.WriteStartElement("Modules5", "");

                    for (int i = 0; i < moduleListlvl5.Count; i++)
                    {
                        textWriter.WriteStartElement("Module", "");
                        textWriter.WriteStartElement("Name", "");
                        textWriter.WriteString(moduleListlvl5[i].ModuleName);
                        textWriter.WriteEndElement();


                        textWriter.WriteStartElement("Code", "");
                        textWriter.WriteString(moduleListlvl5[i].ModuleCode);
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Credits", "");
                        textWriter.WriteString(moduleListlvl5[i].ModuleCredits.ToString());
                        textWriter.WriteEndElement();

                        assessmentList = moduleListlvl5[i].ReturnAssessment();
                        for (int y = 0; y < assessmentList.Count; y++)
                        {
                            textWriter.WriteStartElement("Assessment", "");
                            textWriter.WriteStartElement("AssessmentName", "");
                            textWriter.WriteString(assessmentList[y].AssessmentName);
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("Mark", "");
                            textWriter.WriteString(assessmentList[y].AssessmentMark.ToString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("Weighting", "");
                            textWriter.WriteString(assessmentList[y].AssessmentWeighting.ToString());
                            textWriter.WriteEndElement();
                            textWriter.WriteEndElement();
                        }
                        textWriter.WriteEndElement();
                    }


                    textWriter.WriteEndElement();

                    textWriter.WriteStartElement("Modules6", "");
                    for (int i = 0; i < moduleListlvl6.Count; i++)
                    {
                        textWriter.WriteStartElement("Module", "");
                        textWriter.WriteStartElement("Name", "");
                        textWriter.WriteString(moduleListlvl6[i].ModuleName);
                        textWriter.WriteEndElement();


                        textWriter.WriteStartElement("Code", "");
                        textWriter.WriteString(moduleListlvl6[i].ModuleCode);
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Credits", "");
                        textWriter.WriteString(moduleListlvl6[i].ModuleCredits.ToString());
                        textWriter.WriteEndElement();

                        assessmentList = moduleListlvl6[i].ReturnAssessment();

                        for (int y = 0; y < assessmentList.Count; y++)
                        {
                            textWriter.WriteStartElement("Assessment", "");
                            textWriter.WriteStartElement("AssessmentName", "");
                            textWriter.WriteString(assessmentList[y].AssessmentName);
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("Mark", "");
                            textWriter.WriteString(assessmentList[y].AssessmentMark.ToString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("Weighting", "");
                            textWriter.WriteString(assessmentList[y].AssessmentWeighting.ToString());
                            textWriter.WriteEndElement();
                            textWriter.WriteEndElement();
                        }
                        textWriter.WriteEndElement();

                    }


                    textWriter.WriteEndElement();
                    textWriter.WriteEndElement();
                    // close writer
                    textWriter.Close();
                    Console.ReadLine();

                    Thread thread1 = new Thread(new ThreadStart(saveThread));
                    thread1.Start();

                }

            }


            else
            {

                String workingDir = Directory.GetCurrentDirectory();
                // Create a new file in the working directory
                XmlTextWriter textWriter = new XmlTextWriter("SavedData.xml", null);
                // Opens the document
                textWriter.WriteStartDocument();

                textWriter.WriteStartElement("Course", "");

                textWriter.WriteStartElement("CourseName", "");
                textWriter.WriteString(cd.CourseName);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("CourseCode", "");
                textWriter.WriteString(cd.CourseCode);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("Modules4", "");
                //nested element
                for (int i = 0; i < moduleListlvl4.Count; i++)
                {
                    textWriter.WriteStartElement("Module", "");
                    textWriter.WriteStartElement("Name", "");
                    textWriter.WriteString(moduleListlvl4[i].ModuleName);
                    textWriter.WriteEndElement();


                    textWriter.WriteStartElement("Code", "");
                    textWriter.WriteString(moduleListlvl4[i].ModuleCode);
                    textWriter.WriteEndElement();

                    textWriter.WriteStartElement("Credits", "");
                    textWriter.WriteString(moduleListlvl4[i].ModuleCredits.ToString());
                    textWriter.WriteEndElement();

                    assessmentList = moduleListlvl4[i].ReturnAssessment();
                    for (int y = 0; y < assessmentList.Count; y++)
                    {
                        textWriter.WriteStartElement("Assessment", "");
                        textWriter.WriteStartElement("AssessmentName", "");
                        textWriter.WriteString(assessmentList[y].AssessmentName);
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Mark", "");
                        textWriter.WriteString(assessmentList[y].AssessmentMark.ToString());
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Weighting", "");
                        textWriter.WriteString(assessmentList[y].AssessmentWeighting.ToString());
                        textWriter.WriteEndElement();
                        textWriter.WriteEndElement();
                    }
                    textWriter.WriteEndElement();
                }

                textWriter.WriteEndElement();



                textWriter.WriteStartElement("Modules5", "");

                for (int i = 0; i < moduleListlvl5.Count; i++)
                {
                    textWriter.WriteStartElement("Module", "");
                    textWriter.WriteStartElement("Name", "");
                    textWriter.WriteString(moduleListlvl5[i].ModuleName);
                    textWriter.WriteEndElement();


                    textWriter.WriteStartElement("Code", "");
                    textWriter.WriteString(moduleListlvl5[i].ModuleCode);
                    textWriter.WriteEndElement();

                    textWriter.WriteStartElement("Credits", "");
                    textWriter.WriteString(moduleListlvl5[i].ModuleCredits.ToString());
                    textWriter.WriteEndElement();

                    assessmentList = moduleListlvl5[i].ReturnAssessment();
                    for (int y = 0; y < assessmentList.Count; y++)
                    {
                        textWriter.WriteStartElement("Assessment", "");
                        textWriter.WriteStartElement("AssessmentName", "");
                        textWriter.WriteString(assessmentList[y].AssessmentName);
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Mark", "");
                        textWriter.WriteString(assessmentList[y].AssessmentMark.ToString());
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Weighting", "");
                        textWriter.WriteString(assessmentList[y].AssessmentWeighting.ToString());
                        textWriter.WriteEndElement();
                        textWriter.WriteEndElement();
                    }
                    textWriter.WriteEndElement();
                }


                textWriter.WriteEndElement();

                textWriter.WriteStartElement("Modules6", "");
                for (int i = 0; i < moduleListlvl6.Count; i++)
                {
                    textWriter.WriteStartElement("Module", "");
                    textWriter.WriteStartElement("Name", "");
                    textWriter.WriteString(moduleListlvl6[i].ModuleName);
                    textWriter.WriteEndElement();


                    textWriter.WriteStartElement("Code", "");
                    textWriter.WriteString(moduleListlvl6[i].ModuleCode);
                    textWriter.WriteEndElement();

                    textWriter.WriteStartElement("Credits", "");
                    textWriter.WriteString(moduleListlvl6[i].ModuleCredits.ToString());
                    textWriter.WriteEndElement();

                    assessmentList = moduleListlvl6[i].ReturnAssessment();

                    for (int y = 0; y < assessmentList.Count; y++)
                    {
                        textWriter.WriteStartElement("Assessment", "");
                        textWriter.WriteStartElement("AssessmentName", "");
                        textWriter.WriteString(assessmentList[y].AssessmentName);
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Mark", "");
                        textWriter.WriteString(assessmentList[y].AssessmentMark.ToString());
                        textWriter.WriteEndElement();

                        textWriter.WriteStartElement("Weighting", "");
                        textWriter.WriteString(assessmentList[y].AssessmentWeighting.ToString());
                        textWriter.WriteEndElement();
                        textWriter.WriteEndElement();
                    }
                    textWriter.WriteEndElement();

                }


                textWriter.WriteEndElement();
                textWriter.WriteEndElement();
                // close writer
                textWriter.Close();
                Console.ReadLine();

                Thread thread1 = new Thread(new ThreadStart(saveThread));
                thread1.Start();


            }

        }

        private void saveThread()
        {
      

            Object threadLock = false;

            //If another thread, check if this thread has locked the object until it can proceed.
            lock (threadLock) {
                try
                {
                    SqlConnection myConnection = new SqlConnection("Integrated Security=true;" +
                                           "password=password;server=.\\SQLEXPRESS;" +
                                           "Trusted_Connection=yes;" +
                                           "database=XML; " +
                                           "connection timeout=30");

                    


                    myConnection.Open();



                    using (SqlCommand command = new SqlCommand(
               "CREATE TABLE Course (Course_Name TEXT, Course_Code TEXT, Module_Level INT, Module_Name TEXT, Module_Code TEXT, Module_Credits INT, Assessment_Name TEXT, Assessment_Weighting INT, Assessment_Mark INT)", myConnection))



                        command.ExecuteNonQuery();





                    string courseName = cd.CourseName;
                    string courseCode = cd.CourseCode;
                    for (int i = 0; i < moduleListlvl4.Count; i++)
                    {

                        string moduleName = moduleListlvl4[i].ModuleName;
                        string moduleCode = moduleListlvl4[i].ModuleCode;
                        int moduleCredits = moduleListlvl4[i].ModuleCredits;
                        int level = moduleListlvl4[i].Level;



                        assessmentList = moduleListlvl4[i].ReturnAssessment();
                        for (int y = 0; y < assessmentList.Count; y++)
                        {
                            string assessmentName = assessmentList[y].AssessmentName;
                            int assessmentWeighting = assessmentList[y].AssessmentWeighting;
                            int assessmentMark = assessmentList[y].AssessmentMark;
                            using (SqlCommand command = new SqlCommand(
                              "INSERT INTO [Course](Course_Name, Course_Code, Module_Name, Module_Code, Module_Credits,  Assessment_Name, Assessment_Weighting, Assessment_Mark) VALUES(@Course_Name, @Course_Code, @Module_Name, @Module_Code,@Module_Credits,@Assessment_Name,@Assessment_Weighting,@Assessment_Mark)", myConnection))
                            {
                                command.Parameters.Add(new SqlParameter("@Course_Name", courseName));
                                command.Parameters.Add(new SqlParameter("@Course_Code", courseCode));
                                command.Parameters.Add(new SqlParameter("@Module_Level", level));
                                command.Parameters.Add(new SqlParameter("@Module_Name", moduleName));
                                command.Parameters.Add(new SqlParameter("@Module_Code", moduleCode));
                                command.Parameters.Add(new SqlParameter("@Module_Credits", moduleCredits));
                                command.Parameters.Add(new SqlParameter("@Assessment_Name", assessmentName));
                                command.Parameters.Add(new SqlParameter("@Assessment_Weighting", assessmentWeighting));
                                command.Parameters.Add(new SqlParameter("@Assessment_Mark", assessmentMark));
                                command.ExecuteNonQuery();

                            }

                        }



                    }

                    for (int i = 0; i < moduleListlvl5.Count; i++)
                    {

                        string moduleName = moduleListlvl5[i].ModuleName;
                        string moduleCode = moduleListlvl5[i].ModuleCode;
                        int moduleCredits = moduleListlvl5[i].ModuleCredits;
                        int level = moduleListlvl5[i].Level;



                        assessmentList = moduleListlvl5[i].ReturnAssessment();
                        for (int y = 0; y < assessmentList.Count; y++)
                        {
                            string assessmentName = assessmentList[y].AssessmentName;
                            int assessmentWeighting = assessmentList[y].AssessmentWeighting;
                            int assessmentMark = assessmentList[y].AssessmentMark;
                            using (SqlCommand command = new SqlCommand(
                              "INSERT INTO [Course](Course_Name, Course_Code, Module_Name, Module_Code, Module_Credits,  Assessment_Name, Assessment_Weighting, Assessment_Mark) VALUES(@Course_Name, @Course_Code, @Module_Name, @Module_Code,@Module_Credits,@Assessment_Name,@Assessment_Weighting,@Assessment_Mark)", myConnection))
                            {
                                command.Parameters.Add(new SqlParameter("@Course_Name", courseName));
                                command.Parameters.Add(new SqlParameter("@Course_Code", courseCode));
                                command.Parameters.Add(new SqlParameter("@Module_Level", level));
                                command.Parameters.Add(new SqlParameter("@Module_Name", moduleName));
                                command.Parameters.Add(new SqlParameter("@Module_Code", moduleCode));
                                command.Parameters.Add(new SqlParameter("@Module_Credits", moduleCredits));
                                command.Parameters.Add(new SqlParameter("@Assessment_Name", assessmentName));
                                command.Parameters.Add(new SqlParameter("@Assessment_Weighting", assessmentWeighting));
                                command.Parameters.Add(new SqlParameter("@Assessment_Mark", assessmentMark));
                                command.ExecuteNonQuery();

                            }

                        }



                    }


                    for (int i = 0; i < moduleListlvl6.Count; i++)
                    {

                        string moduleName = moduleListlvl6[i].ModuleName;
                        string moduleCode = moduleListlvl6[i].ModuleCode;
                        int moduleCredits = moduleListlvl6[i].ModuleCredits;
                        int level = moduleListlvl6[i].Level;



                        assessmentList = moduleListlvl6[i].ReturnAssessment();
                        for (int y = 0; y < assessmentList.Count; y++)
                        {
                            string assessmentName = assessmentList[y].AssessmentName;
                            int assessmentWeighting = assessmentList[y].AssessmentWeighting;
                            int assessmentMark = assessmentList[y].AssessmentMark;
                            using (SqlCommand command = new SqlCommand(
                              "INSERT INTO [Course](Course_Name, Course_Code, Module_Name, Module_Code, Module_Credits,  Assessment_Name, Assessment_Weighting, Assessment_Mark) VALUES(@Course_Name, @Course_Code, @Module_Name, @Module_Code,@Module_Credits,@Assessment_Name,@Assessment_Weighting,@Assessment_Mark)", myConnection))
                            {
                                command.Parameters.Add(new SqlParameter("@Course_Name", courseName));
                                command.Parameters.Add(new SqlParameter("@Course_Code", courseCode));
                                command.Parameters.Add(new SqlParameter("@Module_Level", level));
                                command.Parameters.Add(new SqlParameter("@Module_Name", moduleName));
                                command.Parameters.Add(new SqlParameter("@Module_Code", moduleCode));
                                command.Parameters.Add(new SqlParameter("@Module_Credits", moduleCredits));
                                command.Parameters.Add(new SqlParameter("@Assessment_Name", assessmentName));
                                command.Parameters.Add(new SqlParameter("@Assessment_Weighting", assessmentWeighting));
                                command.Parameters.Add(new SqlParameter("@Assessment_Mark", assessmentMark));
                                command.ExecuteNonQuery();

                            }

                        }



                    }

                    myConnection.Close();
                    MessageBox.Show("Save Successful", "Save Confirmation");
                    
                }


                catch (Exception ex)
                {

                }

            }

            if (!(bool)threadLock)
            {
                Console.WriteLine("Thread has not locked object.");
            }
        }







        //List<Module> Modules = moduleListlvl4.Concat(moduleListlvl5).Concat(moduleListlvl6).ToList();


        //XDocument doc = new XDocument();

        //using (XmlWriter writer = doc.CreateWriter())
        //{
        //    writer.WriteStartElement("ModulesList");

        //    foreach (Module module in Modules)
        //        new XmlSerializer(typeof(Module)).Serialize(writer, module);

        //    writer.WriteEndElement();
        //}

        //doc.Save("Test.xml");













        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
