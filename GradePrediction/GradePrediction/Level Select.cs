using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GradePrediction
{
    public partial class Level_Select : Form
    {
        AddModule am;
        ViewAssessments va;
        EditModule em;
        Boolean level4, level5, level6 = false;
        List<Module> moduleList = new List<Module>();

        List<Module> moduleListlvl4 = new List<Module>();
        List<Module> moduleListlvl5 = new List<Module>();
        List<Module> moduleListlvl6 = new List<Module>();

        List<Assessment> assessmentList = new List<Assessment>();


        int totalCredits = 0;

        public static bool loadState;

        int lvl4Y = 10;
        int lvl5Y = 10;
        int lvl6Y = 10;

        string assessmentName, moduleName, moduleCode;
        int mark, weight, moduleMark, credits;


        Course cd = new Course();
        Module md = new Module();
        internal Course CD
        {
            get { return cd; }
            set { cd = value; }
        }

        internal Module MD
        {
            get { return md; }
            set { md = value; }
        }
        public Level_Select()
        {
            InitializeComponent();
        }

        private void level4Page_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            totalCredits = 0;
          
            try
            {
                for (int i = 0; i < moduleListlvl4.Count; i++)
                {
                    totalCredits = totalCredits + moduleListlvl4[i].ModuleCredits;
                }
                if (totalCredits >= 120)
                {
                    MessageBox.Show("Credit limit reached, please delete a module to continue");
                }
                else
                {
                    if (moduleListlvl4.Count >= 7)
                    {
                        MessageBox.Show("Module limit of 7 exceeded, please delete a module to continue.");
                    }
                    else
                    {
                        level5 = false;
                        level6 = false;
                        level4 = true;

                        am = new AddModule(moduleList, totalCredits);
                        am.FormClosing += new FormClosingEventHandler(this.AddModule_FormClosing);
                        am.Activate();
                        am.ShowDialog();
                    }
                }


            }
            catch (NullReferenceException exception)
            {

            }




        }

        private void Level_Select_Load(object sender, EventArgs e)
        {
            int totalWeight = 0;


            //If connected to database can load and import in to data structures. 
            //Can load from database and save in to xml using xml textwriter 
            //Then load from XML

            if (loadState)
            {

                // DATABASE LOAD CODE


                //try
                //{
                //    SqlConnection myConnection = new SqlConnection("Integrated Security=true;" +
                //                           "password=password;server=.\\SQLEXPRESS;" +
                //                           "Trusted_Connection=yes;" +
                //                           "database=XML; " +
                //                           "connection timeout=30");




                //    myConnection.Open();




                //    SqlDataAdapter Modules4 = new SqlDataAdapter("Select * From dbo.Course where Module_Level = 4", myConnection);
                //    DataSet course4 = new DataSet("Course");
                //    Modules4.FillSchema(course4, SchemaType.Source, "Course");
                //    Modules4.Fill(course4, "Course");

                //    DataTable tblCourse;
                //    tblCourse = course4.Tables["Course"];


                //    int maxWeight = 0;

                //    foreach (DataRow drCurrent in tblCourse.Rows)
                //    {

                //        Module loadModule = new Module();
                //        Assessment loadAssessment = new Assessment();

                //        this.courseNameLbl.Text = drCurrent["Course_Name"].ToString();
                //        this.courseCodeLbl.Text = drCurrent["Course_Code"].ToString();
                //        loadModule.Level = int.Parse(drCurrent["Module_Level"].ToString());
                //        loadModule.ModuleName = drCurrent["Module_Name"].ToString();
                //        loadModule.ModuleCode = drCurrent["Module_Code"].ToString();
                //        loadModule.ModuleCredits = int.Parse(drCurrent["Module_Credits"].ToString());
                //        loadAssessment.AssessmentName = drCurrent["Assessment_Name"].ToString();
                //        maxWeight = maxWeight + int.Parse(drCurrent["Assessment_Weighting"].ToString());
                //        loadAssessment.AssessmentWeighting = int.Parse(drCurrent["Assessment_Weighting"].ToString());
                //        loadAssessment.AssessmentMark = int.Parse(drCurrent["Assessment_Mark"].ToString());
                //        assessmentList.Add(loadAssessment);

                //        if (maxWeight == 100)
                //        {
                //            List<Assessment> assessList2 = new List<Assessment>();
                //            assessList2.AddRange(assessmentList);
                //            loadModule.UpdateList(assessList2);
                //            //     moduleListlvl4.Add(loadModule);
                //            assessmentList.Clear();
                //            maxWeight = 0;

                //        }

                //    }



                //    SqlDataAdapter Modules5 = new SqlDataAdapter("Select * From dbo.Course where Module_Level = 5", myConnection);
                //    DataSet course5 = new DataSet("Course2");
                //    Modules5.FillSchema(course5, SchemaType.Source, "Course2");
                //    Modules5.Fill(course5, "Course2");

                //    DataTable tblCourse5;
                //    tblCourse5 = course5.Tables["Course2"];


                //    int maxWeight2 = 0;

                //    foreach (DataRow drCurrent in tblCourse5.Rows)
                //    {

                //        Module loadModule = new Module();
                //        Assessment loadAssessment = new Assessment();

                //        this.courseNameLbl.Text = drCurrent["Course_Name"].ToString();
                //        this.courseCodeLbl.Text = drCurrent["Course_Code"].ToString();
                //        loadModule.Level = int.Parse(drCurrent["Module_Level"].ToString());
                //        loadModule.ModuleName = drCurrent["Module_Name"].ToString();
                //        loadModule.ModuleCode = drCurrent["Module_Code"].ToString();
                //        loadModule.ModuleCredits = int.Parse(drCurrent["Module_Credits"].ToString());
                //        loadAssessment.AssessmentName = drCurrent["Assessment_Name"].ToString();
                //        maxWeight2 = maxWeight2 + int.Parse(drCurrent["Assessment_Weighting"].ToString());
                //        loadAssessment.AssessmentWeighting = int.Parse(drCurrent["Assessment_Weighting"].ToString());
                //        loadAssessment.AssessmentMark = int.Parse(drCurrent["Assessment_Mark"].ToString());
                //        assessmentList.Add(loadAssessment);

                //        if (maxWeight2 == 100)
                //        {

                //            List<Assessment> assessList2 = new List<Assessment>();
                //            assessList2.AddRange(assessmentList);
                //            loadModule.UpdateList(assessList2);
                //            //         moduleListlvl5.Add(loadModule);
                //            assessmentList.Clear();
                //            maxWeight2 = 0;

                //        }

                //    }



                //    SqlDataAdapter Modules6 = new SqlDataAdapter("Select * From dbo.Course where Module_Level = 6", myConnection);
                //    DataSet course6 = new DataSet("Course3");
                //    Modules6.FillSchema(course6, SchemaType.Source, "Course3");
                //    Modules6.Fill(course6, "Course3");

                //    DataTable tblCourse6;
                //    tblCourse6 = course6.Tables["Course3"];


                //    int maxWeight3 = 0;

                //    foreach (DataRow drCurrent in tblCourse6.Rows)
                //    {

                //        Module loadModule = new Module();
                //        Assessment loadAssessment = new Assessment();

                //        this.courseNameLbl.Text = drCurrent["Course_Name"].ToString();
                //        this.courseCodeLbl.Text = drCurrent["Course_Code"].ToString();
                //        loadModule.Level = int.Parse(drCurrent["Module_Level"].ToString());
                //        loadModule.ModuleName = drCurrent["Module_Name"].ToString();
                //        loadModule.ModuleCode = drCurrent["Module_Code"].ToString();
                //        loadModule.ModuleCredits = int.Parse(drCurrent["Module_Credits"].ToString());
                //        loadAssessment.AssessmentName = drCurrent["Assessment_Name"].ToString();
                //        maxWeight3 = maxWeight3 + int.Parse(drCurrent["Assessment_Weighting"].ToString());
                //        loadAssessment.AssessmentWeighting = int.Parse(drCurrent["Assessment_Weighting"].ToString());
                //        loadAssessment.AssessmentMark = int.Parse(drCurrent["Assessment_Mark"].ToString());
                //        assessmentList.Add(loadAssessment);

                //        if (maxWeight3 == 100)
                //        {

                //            List<Assessment> assessList2 = new List<Assessment>();
                //            assessList2.AddRange(assessmentList);
                //            loadModule.UpdateList(assessList2);
                //            //         moduleListlvl6.Add(loadModule);
                //            assessmentList.Clear();
                //            maxWeight3 = 0;

                //        }

                //    }
                //    myConnection.Close();
                //}
                //catch (Exception err)
                //{
                //    Console.WriteLine(err);
                //}




                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("SavedData.xml");

                    XmlNode xmllst = doc.SelectSingleNode("Modules");


                    using (XmlReader reader = XmlReader.Create("SavedData.xml"))
                        while (reader.Read())
                        {
                            if (reader.IsStartElement())
                            {
                                if (reader.Name == "Modules4")
                                {
                                    readmodules4(reader.ReadSubtree());
                                }
                                else if (reader.Name == "Modules5")
                                {
                                    readmodules5(reader.ReadSubtree());
                                }
                                else if (reader.Name == "Modules6")
                                {
                                    readmodules6(reader.ReadSubtree());
                                }
                            }

                            switch (reader.Name)
                            {


                                case "CourseName":

                                    this.courseNameLbl.Text = reader.ReadString();
                                    cd.CourseName = this.courseNameLbl.Text;


                                    break;

                                case "CourseCode":
                                    this.courseCodeLbl.Text = reader.ReadString();
                                    cd.CourseCode = this.courseCodeLbl.Text;
                                    break;

                            }
                        }



                    void readmodules4(XmlReader reader)
                    {

                        totalWeight = 0;
                        while (reader.Read())
                        {

                            switch (reader.Name)
                            {


                                case "Name":
                                    moduleName = reader.ReadString();


                                    break;

                                case "Code":
                                    moduleCode = reader.ReadString();

                                    break;

                                case "Credits":
                                    credits = int.Parse(reader.ReadString());

                                    break;
                                case "AssessmentName":
                                    assessmentName = reader.ReadString();

                                    break;
                                case "Mark":
                                    mark = int.Parse(reader.ReadString());

                                    break;
                                case "Weighting":
                                    weight = int.Parse(reader.ReadString());
                                    totalWeight = totalWeight + weight;

                                    break;



                            }


                            if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Assessment")
                            {

                                Assessment assess = new Assessment();
                                assess.AssessmentMark = mark;
                                assess.AssessmentName = assessmentName;
                                assess.AssessmentWeighting = weight;
                                assessmentList.Add(assess);


                            }




                            if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Module")
                            {
                                List<Assessment> asessList2 = new List<Assessment>();

                                asessList2.AddRange(assessmentList);
                                Module mod2 = new Module();
                                mod2.ModuleName = moduleName;
                                mod2.ModuleCode = moduleCode;
                                mod2.ModuleCredits = credits;
                                mod2.Level = 4;
                                mod2.UpdateList(asessList2);
                                moduleListlvl4.Add(mod2);
                                assessmentList.Clear();
                                totalWeight = 0;


                            }
                        }
                        Update();
                    }

            
                


                
                        void readmodules5(XmlReader reader)
                        {

                            totalWeight = 0;
                            while (reader.Read())
                            {

                                switch (reader.Name)
                                {


                                    case "Name":
                                        moduleName = reader.ReadString();


                                        break;

                                    case "Code":
                                        moduleCode = reader.ReadString();

                                        break;

                                    case "Credits":
                                        credits = int.Parse(reader.ReadString());

                                        break;
                                    case "AssessmentName":
                                        assessmentName = reader.ReadString();

                                        break;
                                    case "Mark":
                                        mark = int.Parse(reader.ReadString());

                                        break;
                                    case "Weighting":
                                        weight = int.Parse(reader.ReadString());
                                        totalWeight = totalWeight + weight;
                                        break;



                                }


                                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Assessment")
                                {

                                    Assessment assess = new Assessment();
                                    assess.AssessmentMark = mark;
                                    assess.AssessmentName = assessmentName;
                                    assess.AssessmentWeighting = weight;
                                    assessmentList.Add(assess);


                             

                                }

                            if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Module")
                            {
                                List<Assessment> asessList2 = new List<Assessment>();

                                asessList2.AddRange(assessmentList);
                                Module mod2 = new Module();
                                mod2.ModuleName = moduleName;
                                mod2.ModuleCode = moduleCode;
                                mod2.ModuleCredits = credits;
                                mod2.Level = 5;
                                mod2.UpdateList(asessList2);
                                moduleListlvl5.Add(mod2);
                                assessmentList.Clear();
                                totalWeight = 0;


                            }


                        }


                            Update();
                        }

                        void readmodules6(XmlReader reader)
                        {

               


                            totalWeight = 0;

                            while (reader.Read())
                            {

                                switch (reader.Name)
                                {


                                    case "Name":
                                        moduleName = reader.ReadString();


                                    break;

                                    case "Code":
                                        moduleCode = reader.ReadString();

                                        break;

                                    case "Credits":
                                        credits = int.Parse(reader.ReadString());

                                        break;
                                    case "AssessmentName":
                                        assessmentName = reader.ReadString();

                                        break;
                                    case "Mark":
                                        mark = int.Parse(reader.ReadString());

                                        break;
                                    case "Weighting":
                                        weight = int.Parse(reader.ReadString());
                                        totalWeight = totalWeight + weight;
                                        break;



                                }


                                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Assessment")
                                {

                           
                                Assessment assess = new Assessment();
                                    assess.AssessmentMark = mark;
                                    assess.AssessmentName = assessmentName;
                                    assess.AssessmentWeighting = weight;
                                    assessmentList.Add(assess);


                            

                                }


                            if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Module")
                            {
                                List<Assessment> asessList2 = new List<Assessment>();

                                asessList2.AddRange(assessmentList);
                                Module mod2 = new Module();
                                mod2.ModuleName = moduleName;
                                mod2.ModuleCode = moduleCode;
                                mod2.ModuleCredits = credits;
                                mod2.Level = 6;
                                mod2.UpdateList(asessList2);
                                moduleListlvl6.Add(mod2);
                                assessmentList.Clear();
                                totalWeight = 0;


                            }





                            }
                            moduleList = moduleListlvl4.Concat(moduleListlvl5).Concat(moduleListlvl6).ToList();

                            Update();
                        }
                    }
                    
                catch (FileNotFoundException exception)
                {
                    Console.WriteLine(exception);
                }

            }
            else
            {
                  this.courseNameLbl.Text = cd.CourseName;
                  this.courseCodeLbl.Text = cd.CourseCode;

            }


        }


    
        ////  XDocument doc = XDocument.Load("Test.xml");
        //XmlRootAttribute xRoot = new XmlRootAttribute();
        //xRoot.ElementName = "ModulesList";

        //List<Module> modules;
        //using (var reader = new StreamReader("Test.xml"))
        //{
        //    XmlSerializer deserializer = new XmlSerializer(typeof(List<Module>), xRoot);

        //    modules = (List<Module>)deserializer.Deserialize(reader);



        //}

        //moduleListlvl4 = modules;


        //    var test = modules.GroupBy(u => u.Level).ToDictionary(g => g.Key, g => g.ToList());



        //    foreach (var p in test)
        //    {
        //        var id = p.Key;
        //        moduleListlvl4 = p.Value;
        //        Console.WriteLine("ID={0}: {1} Module", id, moduleListlvl4.Count);
        //    }

        //    for(int i = 0; i < moduleListlvl4.Count; i++)
        //    {

        //        assessmentList = moduleListlvl4[i].ReturnAssessment();
        //        Console.WriteLine(assessmentList.Count);
        //    }
        //    Update();

        //}


    
    






        private void EditModule_FormClosing(object sender, FormClosingEventArgs e)
        {

        
            Update();

        }

        private void AddModule_FormClosing(object sender, FormClosingEventArgs e)
        {


            try
            {

                
                this.MD = am.MD;
                if (this.MD.Equals(null)){
                    Console.WriteLine("Null!");
                }
                else {

                    moduleList.Add(MD);


                    if (level4)
                    {


                        MD.Level = 4;
                        moduleListlvl4.Add(MD);

                        Update();
                    }
                    else if (level5)
                    {
                        MD.Level = 5;
                        moduleListlvl5.Add(MD);

                        Update();

                    }
                    else if (level6)
                    {
                        MD.Level = 6;
                        moduleListlvl6.Add(MD);

                        Update();

                    }
                }
            }catch(NullReferenceException ex)
            {

            }



        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {

            Summary ms = new Summary(moduleListlvl4, moduleListlvl5, moduleListlvl6);
            ms.Activate();
            ms.CD = this.CD;
          
            ms.ShowDialog();
        




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addModuleLvl5_Click(object sender, EventArgs e)
        {

            totalCredits = 0;
            for (int i = 0; i < moduleListlvl5.Count; i++)
            {
                totalCredits = totalCredits + moduleListlvl5[i].ModuleCredits;
            }
            if (totalCredits >= 120)
            {
                MessageBox.Show("Credit limit reached, please delete a module to continue");
            }
            else
            {
                if (moduleListlvl5.Count >= 6)
                {
                    MessageBox.Show("Module limit of 6 exceeded, please delete a module to continue.");
                }
                else
                {
                    level6 = false;
                    level4 = false;
                    level5 = true;
                    am = new AddModule(moduleList, totalCredits);
                    am.FormClosing += new FormClosingEventHandler(this.AddModule_FormClosing);
                    am.Activate();
                    am.ShowDialog();
                }
            }



        }

        private void addModuleLvl6_Click(object sender, EventArgs e)
        {

            totalCredits = 0;

            for (int i = 0; i < moduleListlvl6.Count; i++)
            {
                totalCredits = totalCredits + moduleListlvl6[i].ModuleCredits;
            }
            if (totalCredits >= 120)
            {
                MessageBox.Show("Credit limit reached, please delete a module to continue");
            }
            else
            {
                if (moduleListlvl6.Count >= 5)
                {
                    MessageBox.Show("Module limit of 5 exceeded, please delete a module to continue.");
                }
                else
                {
                    level4 = false;
                    level5 = false;
                    level6 = true;

                    am = new AddModule(moduleList, totalCredits);
                    am.FormClosing += new FormClosingEventHandler(this.AddModule_FormClosing);
                    am.Activate();
                    am.ShowDialog();
                }

            }






        }

        private void EditModuleBtn_Click(object sender, EventArgs e)
        {




        }

        private void deleteModuleLvl4btn_Click(object sender, EventArgs e)
        {






        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int maxCredits4 = 0;
            int maxCredits5 = 0;
            int maxCredits6 = 0;
            for (int i = 0; i < moduleListlvl4.Count; i++)
            {
                maxCredits4 = maxCredits4 + moduleListlvl4[i].ModuleCredits;
            }
                for (int i = 0; i < moduleListlvl4.Count; i++)
            {
                if (btn.Name.Equals(moduleListlvl4[i].ModuleName))
                {
                    Boolean level4 = true;
                    Boolean level5 = false;
                    Boolean level6 = false;
                    em = new EditModule(level4, level5, level6 ,moduleList);
                    em.FormClosing += new FormClosingEventHandler(this.EditModule_FormClosing);
                    em.MD = moduleListlvl4[i];
                    em.Activate();
                    EditModule.totalCredits4 = maxCredits4;
                    em.ShowDialog();
                    break;
                }

            }

            for (int i = 0; i < moduleListlvl5.Count; i++)
            {
                maxCredits5 = maxCredits5 + moduleListlvl5[i].ModuleCredits;
            }

            for (int i = 0; i < moduleListlvl5.Count; i++)
            {
                if (btn.Name.Equals(moduleListlvl5[i].ModuleName))
                {
                    Boolean level4 = false;
                    Boolean level5 = true;
                    Boolean level6 = false;
                    em = new EditModule(level4, level5, level6, moduleList);
                    em.FormClosing += new FormClosingEventHandler(this.EditModule_FormClosing);
                    em.MD = moduleListlvl5[i];
                    em.Activate();
                    EditModule.totalCredits5 = maxCredits5;
                    em.ShowDialog();
                    break;
                }
            }

            for (int i = 0; i < moduleListlvl6.Count; i++)
            {
                maxCredits6 = maxCredits6 + moduleListlvl6[i].ModuleCredits;
            }
            for (int i = 0; i < moduleListlvl6.Count; i++)
            {
                if (btn.Name.Equals(moduleListlvl6[i].ModuleName))
                {
                    Boolean level4 = false;
                    Boolean level5 = false;
                    Boolean level6 = true;
                    em = new EditModule(level4, level5, level6, moduleList);
                    em.FormClosing += new FormClosingEventHandler(this.EditModule_FormClosing);
                    em.MD = moduleListlvl6[i];
                    em.Activate();
                    EditModule.totalCredits6 = maxCredits6;
                    em.ShowDialog();
                    break;
                }
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {

            var confirmation = MessageBox.Show("Are you sure want to delete this module?",
                                     "Module Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                Button btn = sender as Button;
                for (int i = 0; i < moduleListlvl4.Count; i++)
                {
                    if (btn.Name.Equals(moduleListlvl4[i].ModuleName))
                    {
                        moduleListlvl4.Remove(moduleListlvl4[i]);

                    }
                }
                for (int i = 0; i < moduleListlvl5.Count; i++)
                {
                    if (btn.Name.Equals(moduleListlvl5[i].ModuleName))
                    {
                        moduleListlvl5.Remove(moduleListlvl5[i]);

                    }
                }
                for (int i = 0; i < moduleListlvl6.Count; i++)
                {
                    if (btn.Name.Equals(moduleListlvl6[i].ModuleName))
                    {
                        moduleListlvl6.Remove(moduleListlvl6[i]);

                    }
                }

                Update();
            }
            else
            {
               
            }



     

        }
        private void btn3_Click(object sender, EventArgs e) {
            va = new ViewAssessments();
            Button btn = sender as Button;
            for (int i = 0; i < moduleListlvl4.Count; i++)
            {
             
                if (btn.Name.Equals(moduleListlvl4[i].ModuleName))
                {
                    va.MD = moduleListlvl4[i];
                    va.Activate();
                    va.ShowDialog();
                    break;
                }
            }

            for (int i = 0; i < moduleListlvl5.Count; i++)
            {
                if (btn.Name.Equals(moduleListlvl5[i].ModuleName))
                {
          
                    va.MD = moduleListlvl5[i];
                    va.Activate();
                    va.ShowDialog();
                   break;
                   
               
                }
            }

            for (int i = 0; i < moduleListlvl6.Count; i++)
            {
                if (btn.Name.Equals(moduleListlvl6[i].ModuleName))
                {
            
                    va.MD = moduleListlvl6[i];
                    va.Activate();
                    va.ShowDialog();
                    break;
                }
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void courseCodeLbl_Click(object sender, EventArgs e)
        {

        }

        private void lvl4ModuleTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvl4Modules_Click(object sender, EventArgs e)
        {

        }

        private void level5Tab_Click(object sender, EventArgs e)
        {

        }

        private void level4Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update()
        {

          
            this.lvl4Modules.Controls.Clear();
            this.lvl5Modules.Controls.Clear();
            this.lvl6Modules.Controls.Clear();
            try
            {
                for (int i = 0; i < moduleListlvl4.Count; i++)
                {


                    Label lbl = new Label();
                    Label lbl2 = new Label();
                    Label lbl3 = new Label();

                    Button btn = new Button();
                    Button btn2 = new Button();
                    Button btn3 = new Button();


                    lbl3.AutoSize = true;
                    btn.AutoSize = true;
                    btn2.AutoSize = true;
                    btn3.AutoSize = true;

                    lbl.Text = moduleListlvl4[i].ModuleCode;
                    lbl2.Text = moduleListlvl4[i].ModuleCredits.ToString();
                    lbl3.Text = moduleListlvl4[i].ModuleName;
                 


                    btn.Text = "Edit";
                    btn2.Text = "Delete";
                    btn3.Text = "Assessments";

                    lbl.Location = new Point(17, lvl4Y);
                    lbl2.Location = new Point(161, lvl4Y);
                    lbl3.Location = new Point(288, lvl4Y);

                    btn.Location = new Point(715, lvl4Y);
                    btn2.Location = new Point(800, lvl4Y);
                    btn3.Location = new Point(600, lvl4Y);




                    btn.Name = moduleListlvl4[i].ModuleName;
                    btn2.Name = moduleListlvl4[i].ModuleName;
                    btn3.Name = moduleListlvl4[i].ModuleName;

                    btn.Click += new EventHandler(btn_Click);
                    btn2.Click += new EventHandler(btn2_Click);
                    btn3.Click += new EventHandler(btn3_Click);

                    this.lvl4Modules.Controls.Add(lbl);
                    this.lvl4Modules.Controls.Add(lbl2);
                    this.lvl4Modules.Controls.Add(lbl3);
                    this.lvl4Modules.Controls.Add(btn);
                    this.lvl4Modules.Controls.Add(btn2);
                    this.lvl4Modules.Controls.Add(btn3);
                    lvl4Y = lvl4Y + 40;

                }


                lvl4Y = 10;
                for (int i = 0; i < moduleListlvl5.Count; i++)
                {



                    Label lbl = new Label();
                    Label lbl2 = new Label();
                    Label lbl3 = new Label();

                    Button btn = new Button();
                    Button btn2 = new Button();
                    Button btn3 = new Button();

                    lbl3.AutoSize = true;
                    btn.AutoSize = true;
                    btn2.AutoSize = true;
                    btn3.AutoSize = true;

                    lbl.Text = moduleListlvl5[i].ModuleCode;
                    lbl2.Text = moduleListlvl5[i].ModuleCredits.ToString();
                    lbl3.Text = moduleListlvl5[i].ModuleName;

                    btn.Text = "Edit";
                    btn2.Text = "Delete";
                    btn3.Text = "Assessments";


                    lbl.Location = new Point(17, lvl5Y);
                    lbl2.Location = new Point(161, lvl5Y);
                    lbl3.Location = new Point(288, lvl5Y);

                    btn.Location = new Point(715, lvl5Y);
                    btn2.Location = new Point(800, lvl5Y);
                    btn3.Location = new Point(600, lvl5Y);


                    btn.Name = moduleListlvl5[i].ModuleName;
                    btn2.Name = moduleListlvl5[i].ModuleName;
                    btn3.Name = moduleListlvl5[i].ModuleName;

                    btn.Click += new EventHandler(btn_Click);
                    btn2.Click += new EventHandler(btn2_Click);
                    btn3.Click += new EventHandler(btn3_Click);

                    this.lvl5Modules.Controls.Add(lbl);
                    this.lvl5Modules.Controls.Add(lbl2);
                    this.lvl5Modules.Controls.Add(lbl3);
                    this.lvl5Modules.Controls.Add(btn);
                    this.lvl5Modules.Controls.Add(btn2);
                    this.lvl5Modules.Controls.Add(btn3);

                    lvl5Y = lvl5Y + 40;
                }

                lvl5Y = 10;


                for (int i = 0; i < moduleListlvl6.Count; i++)
                {
                    Label lbl = new Label();
                    Label lbl2 = new Label();
                    Label lbl3 = new Label();

                    Button btn = new Button();
                    Button btn2 = new Button();
                    Button btn3 = new Button();

                    lbl3.AutoSize = true;
                    btn.AutoSize = true;
                    btn2.AutoSize = true;
                    btn3.AutoSize = true;


                    lbl.Text = moduleListlvl6[i].ModuleCode;
                    lbl2.Text = moduleListlvl6[i].ModuleCredits.ToString();
                    lbl3.Text = moduleListlvl6[i].ModuleName;


                    btn.Text = "Edit";
                    btn2.Text = "Delete";
                    btn3.Text = "Assessments";


                    lbl.Location = new Point(17, lvl6Y);
                    lbl2.Location = new Point(161, lvl6Y);
                    lbl3.Location = new Point(288, lvl6Y);

                    btn.Location = new Point(715, lvl6Y);
                    btn2.Location = new Point(800, lvl6Y);
                    btn3.Location = new Point(600, lvl6Y);


                    btn.Name = moduleListlvl6[i].ModuleName;
                    btn2.Name = moduleListlvl6[i].ModuleName;
                    btn3.Name = moduleListlvl6[i].ModuleName;

                    btn.Click += new EventHandler(btn_Click);
                    btn2.Click += new EventHandler(btn2_Click);
                    btn3.Click += new EventHandler(btn3_Click);

                    this.lvl6Modules.Controls.Add(lbl);
                    this.lvl6Modules.Controls.Add(lbl2);
                    this.lvl6Modules.Controls.Add(lbl3);
                    this.lvl6Modules.Controls.Add(btn);
                    this.lvl6Modules.Controls.Add(btn2);
                    this.lvl6Modules.Controls.Add(btn3);
                    lvl6Y = lvl6Y + 40;
                }
                lvl6Y = 10;
            } catch(NullReferenceException exception)
            {

            }
        }
    }
}


