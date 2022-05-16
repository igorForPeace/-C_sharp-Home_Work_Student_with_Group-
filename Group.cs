﻿using System;

using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Student_with_Group_
{

    

    class Group : IEnumerable

    {
        private Student[] students;
        private int count_of_student;
        private string name_of_group;
        private string specialization;
        private int course;


        public Group(int count, string name_of_group, string specialization, int course)
        {
            this.count_of_student = count;
            students = new Student[count_of_student];
            for (int i = 0; i < count_of_student; i++)
            {
                students[i] = new Student();
            }
            this.name_of_group = name_of_group;
            this.specialization = specialization;
            this.course = course;
        }
        public Group(Student[]array) :this(array.Length, "Новенькие" , "Маркетинг" , 5)
        {
            for (int i = 0; i < count_of_student; i++)
            {
                students[i] = array[i];
            }
        }
        public Group(Group a, string name_of_group, string specialization, int course) 
            :this(a.Count_of_students, name_of_group, specialization, course)
        {
            for (int i = 0; i < count_of_student; i++)
            {
                this.students[i] = a.students[i];
            }
        }
        public Group() : this(10, "Молчаливые", "Економика" , 3) { }
        public Group(int number) : this(number, "Молчаливые", "Економика", 3) { }

        public string Name_of_group
        {
            get { return name_of_group; }
            set { name_of_group = value; }
        }
        public int Count_of_students
        {
            get { return count_of_student; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }                       
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public Student this[int index]
        {
            get
            {
                if (index >= 0 && index < students.Length)
                {
                    return students[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < students.Length)
                {
                    students[index] = value;
                }
            }
        }

        public void ShowGroup()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Group name: " + Name_of_group);
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("Count of students: " + Count_of_students);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("List of Students: ");
            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student № "+(i+1));
                students[i].Show();
            }
        }

        public void Print()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Group name: " + Name_of_group);
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("Count of students: " + Count_of_students);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("List of Students: ");
            Console.WriteLine();
            foreach (var item in students)
            {
                item.Show();
            }
        }

        public void AddStudent()
        {
            Array.Resize(ref students, students.Length + 1);
            students[count_of_student] = new Student();
            count_of_student++;
        }
        public void AddStudent(string surname, string name, string patronymic)
        {
            AddStudent();
            students[students.Length-1] = new Student(surname, name, patronymic);
        }
        public void AddStudent(ref Student a)
        {
            AddStudent();
            students[students.Length - 1] = a;
        }
        public void Remove()  // отчисление неуспевающего студента 
        {
            double MIN = students[0].Average();
            int index=0;
            for (int i = 1; i < students.Length; i++)
            {
                if (MIN>students[i].Average())
                {
                    MIN = students[i].Average();
                    index = i;
                }
            }
            Student[] newStudents = new Student[count_of_student - 1];
            for (int i = 0; i < index; i++)
            {
                newStudents[i] = students[i];
            }
            for (int i = index+1; i < count_of_student; i++)
            {
                newStudents[i - 1] = students[i];
            }
            count_of_student--;
            students = newStudents;
        }


        public void SortByAverage()
        {
            Array.Sort(students);
        }

        public void SortByLastName()
        {
            Array.Sort(students, new SortBySurname());
        }

        public void SortByDateOfBirth()
        {
            Array.Sort(students, new SortByAge());
        }

        public void SearchByName(string name)
        {
            int count = 0;
            Console.Write("\nСтуденты с именем "+name);
            for (int i = 0; i < this.students.Length; i++)
            {
                if (this.students[i].GetName()==name)
                {
                    Console.WriteLine();
                    this.students[i].Show();
                    count++;
                }
            }
            if (count == 0) Console.Write(" нет\n");
        }

        public void SearchBySurname(string surname)
        {
            int count = 0;
            Console.Write("\nСтуденты с Фамилией " + surname);
            for (int i = 0; i < this.students.Length; i++)
            {
                if (this.students[i].GetSurname() == surname)
                {
                    Console.WriteLine();
                    this.students[i].Show();
                    count++;
                }
            }
            if (count == 0) Console.Write(" нет\n");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public GroupEnum GetEnumerator()
        {
            return new GroupEnum(students); 
        }
    }
   

    public class GroupEnum : IEnumerator
    {
        public Student[] students;
        int position = -1;

        public GroupEnum(Student[] list)
        {
            students = list;
        }
        
        public bool MoveNext()
        {
            position++;
            return (position < students.Length);
        }
        
        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Student Current
        {
            get
            {
                try
                {
                    return students[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
