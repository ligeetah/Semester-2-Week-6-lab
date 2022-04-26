using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.DL;

namespace uams.BL
{
    class Student
    {

        private string name;
        private int age;
        private double fscMarks;
        private double ecatMarks;
        private double merit;
        private float fee;
        private List<DegreeProgram> preferences;
        private List<Subject> regSubject;
        private DegreeProgram regDegree;

        public string getname() { return name; }
        public int getage() { return age; }
        public double getfscMarks() { return fscMarks; }
        public double getecatMarks() { return ecatMarks; }
        public double getmerit() { return merit; }
        public List<DegreeProgram> getpreferences() { return preferences; }
        public List<Subject> getregSubject() { return regSubject; }
        public DegreeProgram getregDegree() { return regDegree; }
        public void setname(string name) { this.name=name; }
        public void setage(int age) { this.age=age; }
        public void setfscMarks(double fscMarks) { this.fscMarks=fscMarks; }
        public void setecatMarks(double ecatMarks) { this.ecatMarks=ecatMarks; }
        public void setmerit(double merit) { this.merit=merit; }
        public void Addpreferences(DegreeProgram prefrences) { this.preferences.Add(prefrences); }
        public void setregDegree(DegreeProgram regDegree) {this.regDegree=regDegree; }

        public Student(string name, int age, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            regSubject = new List<Subject>();
            
        }
        public void calculateMerit()
        {
            this.merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;
         
        }  
        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null  && stCH + s.getcreditHours()<= 9)
            {
                Subject sub=regDegree.isSubjectExists(s);
                if (sub != null)
                {
                    regSubject.Add(sub);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getCreditHours()
        {
            int count = 0;
            foreach (Subject sub in regSubject)
            {
                count = count + sub.getcreditHours();
            }
            return count;
        }
        public float calculateFee()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (Subject sub in regSubject)
                {
                    fee = fee + sub.getsubjectFees();
                }
            }
            this.fee = fee;
            return fee;
        }
    }
}
