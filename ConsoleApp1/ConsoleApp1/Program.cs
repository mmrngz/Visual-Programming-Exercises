using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayList1 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string[] dayList2 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
            var resultDayList1 = dayList1.Except(dayList2); //dayList1'de olup dayList2'de olmayan kayıtlar resultDayList1 nesnesine aktarılır.
            Console.WriteLine("********************** Except ************************");
            foreach (var day in resultDayList1)
                Console.WriteLine(day);





            Console.WriteLine("********************** Union ************************");
            var resultDayList2 = dayList1.Union(dayList2);
            foreach (var day in resultDayList2)
                Console.WriteLine(day);








            Console.WriteLine("********************** Concatenation ************************");
            var resultDayList3 = dayList1.Concat(dayList2);
            foreach (var day in resultDayList3)
                Console.WriteLine(day);












            Console.WriteLine("********************** Intersect ************************");
            var resultDayList4 = dayList1.Intersect(dayList2);
            foreach (var day in resultDayList4)
                Console.WriteLine(day);









            string[] dayList3 = { "Pazartesi", "Pazartesi", "Salı", "Salı", "Çarşamba", "Çarşamba", "Perşembe", "Perşembe", "Cuma", "Cuma", "Cumartesi", "Cumartesi", "Pazar", "Pazar" };

            var resultDayList5 = dayList3.Distinct();
            Console.WriteLine("********************** Distinct ************************");

            foreach (var item in resultDayList5)
                Console.WriteLine(item);






            List<Person> personList1 = new List<Person>();
            personList1.Add(new Person { id = 1, firstName = "Ahmet", lastName = "Yılmaz", age = 49 });
            personList1.Add(new Person { id = 2, firstName = "Hülya", lastName = "Kaya", age = 34 });
            personList1.Add(new Person { id = 3, firstName = "Fatma", lastName = "Yıldırım", age = 25 });
            personList1.Add(new Person { id = 4, firstName = "Ece", lastName = "Yıldız", age = 21 });
            personList1.Add(new Student { id = 5, firstName = "Gökhan", lastName = "Demir", age = 41, department = "Computer Engineering", studentID = 100 });
            personList1.Add(new Officer { id = 6, firstName = "Oğuz", lastName = "Çelik", age = 23, salary = 30000 });

            List<Person> personList2 = new List<Person>();
            personList2.Add(new Person { id = 1, firstName = "Ahmet", lastName = "Yılmaz", age = 49 });
            personList2.Add(new Officer { id = 7, firstName = "Alper", lastName = "Doğan", age = 25, salary = 4500 });
            personList2.Add(new Person { id = 8, firstName = "Ahmet", lastName = "Yılmaz2", age = 51 });
            personList2.Add(new Person { id = 9, firstName = "Ece", lastName = "Yıldız2", age = 34 });
            personList2.Add(new Student { id = 10, firstName = "Gökhan", lastName = "Demir2", age = 19, department = "Computer Engineering", studentID = 101 });
            personList2.Add(new Student { id = 11, firstName = "Eren", lastName = "Efe", age = 19, department = "Computer Engineering", studentID = 102 });
            personList2.Add(new Student { id = 12, firstName = "Eren", lastName = "Gökdeniz", age = 25, department = "Industrial Engineering", studentID = 103 });






            Console.WriteLine("********************** Except ************************");
            var resultPersonList1 = personList1.Except(personList2);
            foreach (var person in resultPersonList1)
                person.showInfo();

            Console.WriteLine("********************** Union ************************");
            var resultPersonList2 = personList1.Union(personList2);
            foreach (var person in resultPersonList2)
                person.showInfo();

            Console.WriteLine("********************** Concat ************************");
            var resultPersonList3 = personList1.Concat(personList2);
            foreach (var person in resultPersonList3)
                person.showInfo();

            Console.WriteLine("********************** Intersect ************************");
            var resultPersonList4 = personList1.Intersect(personList2);
            foreach (var person in resultPersonList4)
                person.showInfo();

            Console.WriteLine("********************** Distinct ************************");
            var resultPersonList5 = personList1.Distinct();
            foreach (var person in resultPersonList5)
                person.showInfo();






        }
    }
}
