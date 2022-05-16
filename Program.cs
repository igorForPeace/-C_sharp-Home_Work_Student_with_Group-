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


            //Group a = new Group(3);
            ////a.ShowGroup();
            //a[0].Show();
            //Student temp = new Student("Плахотнюк", "Игорь", "Витальевич");
            //a[0] = temp;
            //a[0].Show();
            //a.ShowGroup();





            // тест метода CompareTo
            // сортирует среднюю оценку по возрастанию

            //Student[] student = new Student[5];
            //student[0] = new Student();
            //student[1] = new Student();
            //student[2] = new Student();
            //student[3] = new Student();
            //student[4] = new Student();
            //foreach (var item in student)
            //{
            //    item.Show();
            //}
            //Console.WriteLine();
            //Array.Sort(student);
            //foreach (var item in student)
            //{
            //    item.Show();
            //}
            //Console.WriteLine(student[5]); // Кидает исключение за выход из массива





            // тест сортировки по фамилии

            //Student[] student = new Student[5];
            //student[0] = new Student();
            //student[1] = new Student();
            //student[2] = new Student();
            //student[3] = new Student();
            //student[4] = new Student();
            //Console.WriteLine("Массив студентов до сортровки:");
            //Console.WriteLine();
            //foreach (var item in student)
            //{
            //    item.Show();
            //}
            //Console.WriteLine();
            //Array.Sort(student, new SortBySurname());
            //Console.WriteLine("Массив студентов После сортровки:");
            //Console.WriteLine();
            //foreach (var item in student)
            //{
            //    item.Show();
            //}




            // тест сортировки по возрасту

            //Student[] student = new Student[5];
            //student[0] = new Student();
            //student[1] = new Student();
            //student[2] = new Student();
            //student[3] = new Student();
            //student[4] = new Student();
            //Console.WriteLine("Массив студентов до сортровки:");
            //Console.WriteLine();
            //foreach (var item in student)
            //{
            //    item.Show();
            //}
            //Console.WriteLine();
            //Array.Sort(student, new SortByAge());
            //Console.WriteLine("Массив студентов После сортровки:");
            //Console.WriteLine();
            //foreach (var item in student)
            //{
            //    item.Show();
            //}




            // метод Print через foreach

            //Group a = new Group();
            //a.Print();





            // реализация IEnumarator \ IEnumarable

            //Student[] studentA = new Student[5];
            //studentA[0] = new Student();
            //studentA[1] = new Student();
            //studentA[2] = new Student();
            //studentA[3] = new Student();
            //studentA[4] = new Student();

            //Group groupA = new Group(studentA);

            //foreach (var item in groupA)
            //{
            //    item.Show();
            //}



            /////////////////////////////////
            //// Сотрировка группы по среднему балу
            ///

            //Group group = new Group();
            //Console.WriteLine();
            //Console.WriteLine("Массив студентов до сортровки:");
            //Console.WriteLine();
            //group.ShowGroup();
            //Console.WriteLine();
            //Console.WriteLine("Массив студентов после сортровки:");
            //Console.WriteLine();
            //group.SortByAverage();
            //group.ShowGroup();





            /////////////////////////////////
            //// Сотрировка группы по Фамилии
            ///

            //Group group = new Group();
            //Console.WriteLine();
            //Console.WriteLine("Массив студентов до сортровки:");
            //Console.WriteLine();
            //group.ShowGroup();
            //Console.WriteLine();
            //Console.WriteLine("Массив студентов после сортровки:");
            //Console.WriteLine();
            //group.SortByLastName();
            //group.ShowGroup();






            /////////////////////////////////
            //// Сотрировка группы по возрасту
            ///


            //Group group = new Group();
            //Console.WriteLine();
            //Console.WriteLine("Массив студентов до сортровки:");
            //Console.WriteLine();
            //group.ShowGroup();
            //Console.WriteLine();
            //Console.WriteLine("Массив студентов после сортровки:");
            //Console.WriteLine();
            //group.SortByDateOfBirth();
            //group.ShowGroup();



             
            ///////////// метод Search по имени и фамилии

            Group group = new Group();
            group.ShowGroup();
            group.SearchByName("Петр");
            group.SearchBySurname("Кравченко");


            
            



        }
    }
}
