using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradePrediction
{
   public class Assessment
    {
        private string assessmentName;
        private int assessmentWeighting, assessmentMark;

        public string AssessmentName
        {
            get { return assessmentName; }
            set { assessmentName = value; }
        }

        public int AssessmentWeighting
        {
            get { return assessmentWeighting; }
            set { assessmentWeighting = value; }
        }
        public int AssessmentMark
        {
            get { return assessmentMark; }
            set { assessmentMark = value; }
        }

        public void getAssessment()
        {
            Console.WriteLine($"Assessment Name= {this.assessmentName} \n Assessment Weighting= {this.assessmentWeighting}");
        }


    }
}
