using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Student : IComparable
    {
        public string Name { get; set; } //Имя
        public string CreditCardNumber { get; set; } //Номер зачетной книжки
        public int GroupNumber { get; set; } // Номер группы
        public int Age { get; set; } //Возраст

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                var d = obj as Student;
                return this.Name.CompareTo(d.Name);
            }
            else
            {
                throw new Exception("Not Compare");
            }
        }
        public string Print()
        {
            return "Имя студента: " + Name + "\n" + "Номер зачетной книжки: " + CreditCardNumber + "\n" + "Номер группы: " + GroupNumber + "\n" + "Возраст: " + Age + "\n";
        }
    }
}
