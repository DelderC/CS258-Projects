using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorRating
{
    class ProfessorRating
    {
        private string firstName;
        private string lastName;
        private string university;
        private int easyGrade;
        private int helpGrade;

        public ProfessorRating(string f_Name, string l_Name, string uni)
        {
            firstName = f_Name;
            lastName = l_Name;
            university = uni;
            easyGrade = 3;
            helpGrade = 3;
        }

        public ProfessorRating(string f_Name, string l_Name, string uni, int _easyGrade, int _helpGrade)
        {
            firstName = f_Name;
            lastName = l_Name;
            university = uni;
            easyGrade = _easyGrade;
            helpGrade = _helpGrade;
        }

       public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        public int EasyGrade { get; set; }
        public int HelpGrade { get; set; }

        public override string ToString()
        {
            return "First Name: " + firstName +
                   "\nLast Name: " + lastName +
                   "\nUniversity: " + university +
                   "\nEasiness Grade: " + easyGrade +
                   "\nHelpfulness Grade: " + helpGrade;
        }
    }
}
