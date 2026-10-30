using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Student
    {
        public int Id { get; set; }
        public string Namn { get; set; } = "";
        public int Alder { get; set; }
        public string Klass { get; set; } = "";
        public int Poang { get; set; }

        Student()
        {
            Id = 0;
            Namn = "";
            Alder = 0;
            Klass = "";
            Poang = 0;
        }

        Student(int id, string namn, int alder, string klass, int poang)
        {
            Id = id;
            Namn = namn;
            Alder = alder;
            Klass = klass;
            Poang = poang;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Namn: {Namn}, Ålder: {Alder}, Klass: {Klass}, Poäng: {Poang}";
        }

        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student(1, "Anna", 19, "A", 85),
                new Student(2, "Bertil", 22, "B", 72),
                new Student(3, "Cecilia", 20, "A", 91),
                new Student(4, "David", 24, "C", 64),
                new Student(5, "Eva", 19, "B", 85),
                new Student(6, "Felix", 21, "A", 77),
                new Student(7, "Gustav", 23, "C", 58),
                new Student(8, "Hanna", 20, "B", 95)
            };
        }
    }
}
