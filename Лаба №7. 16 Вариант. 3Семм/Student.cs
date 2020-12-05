using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба__7._16_Вариант._3Семм
{
    class Student
    {
		public Student() { }
		public string get_name() { return this.PrNameStudent; }
		public string get_surname() { return this.PrSurnameStudent; }
		public int get_student_ID_number() { return this.Pr_student_ID_number; }
		public void set_name(string Set_Name) { this.PrNameStudent = Set_Name; }
		public void set_surname(string Set_SurName) { this.PrSurnameStudent = Set_SurName; }
		public void Set_student_ID_number(int Set_student_ID_number) { }
	
		string PrNameStudent;
        string PrSurnameStudent;
        int Pr_student_ID_number;
    }
}
