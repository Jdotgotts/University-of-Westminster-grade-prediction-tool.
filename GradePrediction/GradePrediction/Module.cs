using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GradePrediction
{
   
    public class Module
    {
        private string moduleName, moduleCode;
        private int moduleCredits;
        private double moduleMark;
        Assessment assessment;
        private int level;
   
        private List<Assessment> assesList = new List<Assessment>();



        public void getAssessmentInfo(Assessment obj)
        {
            Console.WriteLine($"Module Name = {this.moduleName}\n Module Code= {this.moduleCode} \n Module Credits= {this.moduleCode}\n");
            obj.getAssessment();
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public string ModuleName
        {
            get { return moduleName; }
            set { moduleName = value; }
        }
        public string ModuleCode
        {
            get { return moduleCode; }
            set { moduleCode = value; }
        }
        public int ModuleCredits
        {
            get { return moduleCredits; }
            set { moduleCredits = value; }
        }


        public double ModuleMarks
        {
            get { return moduleMark; }
            set { moduleMark = value; }
        }
        
   
       



        public void AddAssessment(string name, int marking, int weighting)
        {
            assessment = new Assessment();
            assessment.AssessmentName = name;
            assessment.AssessmentMark = marking;
            assessment.AssessmentWeighting = weighting;
            assesList.Add(assessment);

        }
        
        public List<Assessment> ReturnAssessment()
        {
            return assesList;
        }

        public void UpdateList(List<Assessment> assessment)
        {
            this.assesList = assessment;
        }
        
        
    }
       
    }



