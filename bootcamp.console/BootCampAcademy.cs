using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp.console
{
    public class BootCampAcademy
    {
        public List<string> LearningPlans { get; set; } = new List<string>();
        public bool IsBootCampAcademyFull { get { return LearningPlans.Count >= LearningPlanMax ? true : false; } }
        public int LearningPlanMax { get; set; } = 3;

        public bool AddLearningPlan(string learningPlan)
        {
            if(!IsBootCampAcademyFull)
            {
                LearningPlans.Add(learningPlan);
                return true;
            }
            return false;
        }
    }
}
