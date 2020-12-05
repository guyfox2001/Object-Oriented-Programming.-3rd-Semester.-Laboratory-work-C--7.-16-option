using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Лаба__7._16_Вариант._3Семм
{
	delegate void OurMessage(string Mess);
	delegate void count_student(int Count);
	class Group
    {
		public Group() { this.Students = new LinkedList<Student>(); }
		public void add_student(string Name, string Surname, int ID) {
			Student Adding = new Student();
            Adding.set_name(Name);
			Adding.set_surname(Surname);
			Adding.Set_student_ID_number(ID);

			this.Students.AddLast(Adding);
			this.Size++;

			AddedStudent("We're added student " + Adding.get_name() + ' ' + Adding.get_surname() + " In Group " + this.GroupName);

			if (this.Size > 5)
				CountStudent(this.Size);
		}
		public string get_name() { return this.GroupName;  }
		public void Print_Students_count(int count) { Console.WriteLine("We have a " + count.ToString() + " students"); }
		public void Print_Msg(string msg) { Console.WriteLine(msg); }
		public event OurMessage AddedStudent;
		public event count_student CountStudent;

		private LinkedList <Student> Students;
		private string GroupName;
		private int Size = 0;
	}
}
