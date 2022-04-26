using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    class Subject
    {
        private string code;
        private string type;
        private int creditHours;
        private int subjectFees;

        public string getcode() { return code; }
        public string gettype() { return type; }
        public int getcreditHours() { return creditHours; }
        public int getsubjectFees() { return subjectFees; }
        public void setcode(string code) { this.code=code; }
        public void settype(string type) { this.type=type; }
        public void setcode(int creditHours) { this.creditHours=creditHours; }
        public void setsubjectFees(int subjectFees) { this.subjectFees = subjectFees; }
        public Subject(string code, string type, int creditHours, int subjectFees)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.subjectFees = subjectFees;
        }
    }
}
