using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    class DegreeProgram
    {
        private string degreeName;
        private float degreeDuration;
        private List<Subject> subjects;
        private int seats;

        public string getdegreeName()
        {
            return degreeName;
        }
        public float getdegreeDuration()
        {
            return degreeDuration;
        }
        public List<Subject> getsubjects()
        {
            return subjects;
        }
        public int getseats()
        {
            return seats;
        }
        public void setdegreeName(string degreeName)
        {
           this.degreeName=degreeName;
        }
        public void setdegreeDuration(int degreeDuration)
        {
            this.degreeDuration=degreeDuration;
        }
        public void setseats(int seats)
        {
            this.seats=seats;
        }


        public DegreeProgram(string degreeName, float degreeDuration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public Subject isSubjectExists(Subject sub)
        {
            foreach (Subject s in subjects)
            {
                if (s.getcode()== sub.getcode())
                {
                    return s;
                }
            }
            return null;
        }

        public bool AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if(creditHours + s.getcreditHours()<= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < subjects.Count; x++)
            {
                count = count + subjects[x].getcreditHours();
            }
            return count;
        }

    }
}
