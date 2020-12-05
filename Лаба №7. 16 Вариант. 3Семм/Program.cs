using System;
namespace Лаба__7._16_Вариант._3Семм
{
    class Program
    {
        static void Main(string[] args)
        {
			string
				Name      = "ExampleName",
				Surname   = "ExampleSurName",
				GroupName = "ExampleGroupName";
			int
				ID = 123456789;
			Group AI_19 = new Group();
			AI_19.CountStudent += new count_student(AI_19.Print_Students_count);
			AI_19.AddedStudent += new OurMessage(AI_19.Print_Msg);
			for (int i = 0; i < 20; i++)
			{
				AI_19.add_student(Name, Surname, ID);
				Console.WriteLine(i);
			}

		}
	}
}
