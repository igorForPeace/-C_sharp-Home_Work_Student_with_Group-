using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1_Home_Work_Student_with_Group_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student a = new Student();
            //a.Show();
            //Student b = new Student();
            //b.Show();
            //Student c = new Student();
            //c.Show();
            //Student d = new Student();
            //d.Show();
            //d.SetName("Gbljh");
            //d.Show();

            //Group b = new Group();
            //b.ShowGroup();


            //Student[] group = new Student[3];
            //group[0] = new Student("Плахотнюк", "Игорь", "Витальевич");
            //group[1] = new Student("Белецкая", "Настасья", "Владимировна");
            //group[2] = new Student("Подосочный", "Дмитрий", "Русланович");
            //Group d = new Group(group);
            //d.ShowGroup();

            //Group a = new Group(5);
            //Group b = new Group(a, "Новенькие 2", "Логисты" , 4);
            //a.ShowGroup();
            //b.ShowGroup();

            //Group a = new Group(2);
            //a.ShowGroup();
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++=");
            //a.AddStudent();
            //a.ShowGroup();
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++=");
            //a.AddStudent("Плахотнюк", "Игорь", "Витальевич");
            //a.ShowGroup();
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++=");
            //Student d = new Student("Березюк", "Иван", "Владимирович");
            //d.Show();
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++=");
            //a.AddStudent(ref d);
            //a.ShowGroup();

            Group a = new Group(3);
            a.ShowGroup();
            a.Remove();
            a.ShowGroup();
            


        }
    }
}
