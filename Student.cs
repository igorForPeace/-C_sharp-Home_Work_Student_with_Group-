using System;

using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Student_with_Group_
{


    class SortBySurname: IComparer<Student>
    {
        public int Compare(Student first, Student second)
        {
            return String.Compare(first.GetSurname(), second.GetSurname());
        }
    }
    class SortByAge : IComparer<Student>
    { 
        public int Compare(Student first, Student second)
        {
            return DateTime.Compare(first.GetDateOfBirth(), second.GetDateOfBirth());
        }
    }
    

    public class Student : IComparable<Student>

    {
        private string surname;
        private string name;
        private string patronymic;
        private DateTime date_of_birth;
        private string adress;
        private int telephone_number;
        private int count_of_credits;
        private int[] credits;
        private int[] course_work;
        private int[] exams;
        public static Random rnd = new Random();
        private void Insert(ref int [] arr)
        {   
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,13);
            }
        }
        private void ShowCredits(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public Student()
        {
            string[] Surnames = { "Петров", "Сидоров" , "Кравченко" , "Тимощук" , "Краснов" , "Чекулаев"
                , "Колбаскин" , "Салатов" , "Пивоваров" , "Зоровиков"};
            this.surname = Surnames[rnd.Next(0,10)];
            string[] Names = { "Игорь" , "Дмитрий","Виктор","Петр","Василий","Константин", "Александр"
                , "Алексей","Иван","Андрей" };
            this.name = Names[rnd.Next(0,10)];
            string[] Patronymics = { "Витальевич", "Викторович","Петрович","Василиевич"
                , "Максимович","Юрьевич","Андреевич","Ульянович","Иванович","Федорович" };
            this.patronymic = Patronymics[rnd.Next(0,10)];
            this.date_of_birth = new DateTime(rnd.Next(1995, 2002), rnd.Next(1, 13), rnd.Next(1, 29));
            this.adress = "Украина, г. Одесса";
            this.telephone_number = rnd.Next(10000000, 99999999);
            this.count_of_credits = 10;
            this.credits = new int[count_of_credits];
            Insert(ref this.credits);
            this.course_work = new int[count_of_credits];
            Insert(ref this.course_work);
            this.exams = new int[count_of_credits];
            Insert(ref this.exams);
        }
        public Student(string surname, string name, string patronymic) : this()
        {
            SetSurname(surname);
            SetName(name);
            SetPatronymic(patronymic);
        }
        public Student (string adress, string surname, string name, string patronymic) : this(surname, name, patronymic)
        {
            this.adress = adress;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPatronymic(string patronymic)
        {
            this.patronymic = patronymic;
        }
        public string GetPatronymic()
        {
            return patronymic;
        }
        public void SetDateOfBirth(DateTime date)
        {
            this.date_of_birth = date;
        }
        public DateTime GetDateOfBirth()
        {
            return this.date_of_birth;
        }
        public void SetAdress(string adress)
        {
            this.adress = adress;
        }
        public string GetAdress()
        {
            return this.adress;
        }
        public int GetTelephone()
        {
            return this.telephone_number;
        }
        public double Average()
        {

            return ((double)credits.Average() + (double)course_work.Average() + (double)exams.Average()) /3;
        }
        public void Show()
        { 
            Console.WriteLine("Surname: " + GetSurname());
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Patronymic: " + GetPatronymic());
            Console.WriteLine("Date of birth: " + GetDateOfBirth());
            Console.WriteLine("Adress: " + GetAdress());
            Console.WriteLine("Telephone number: " + GetTelephone());
            ShowCredits(this.credits);
            ShowCredits(this.course_work);
            ShowCredits(this.exams);
            Console.WriteLine("Average: " + Average());
            Console.WriteLine("======================");
        }

        public int CompareTo(Student other)
        {
            if (this.Average()>other.Average())
            {
                return 1;
            }
            else if (this.Average() < other.Average())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
