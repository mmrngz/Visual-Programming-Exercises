using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person : IEquatable<Person>
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        //Not: showInfo'yu virtual olarak tanımlamamızın sebebi Student ve Officer classlarında bu metodun override edilmesini (ezilmesini) sağlamaktır.
        public virtual void showInfo()
        {
            Console.WriteLine($"ID : {id}\nFirst Name : {firstName}\nLast Name: {lastName}\nAge:  {age} ");
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        //Dikkat!: Alttaki Equal Metodu IEquatable interface'inden geliyor ve ihtiyaç halinde 2 Person nesnesinin eşitlik durumunu kontrol ediyor. Sadece çağrıldığında çalışır.
        public bool Equals(Person p1)
        {
            if (p1 is null)
                return false;

            return this.firstName == p1.firstName;
        }

        //Alttaki Equals Metodu ise Object classından gelen ve 2 nesnenin eşitlik durumunun kontrol edildiği asıl metottur. Bu metot çalıştığında yapmasını istediğimiz şey kendisine gönderilen obj adındaki parametreyi Person nesnesi haline getirip üstteki Equals metoduna yollaması. Bu sayede üstteki Equals metodunun oluşturacağı değer nihai değer olacaktır.
        public override bool Equals(object obj) => Equals(obj as Person);
        public override int GetHashCode() => (firstName).GetHashCode();


    }
    public class Student : Person
    {
        public string department { get; set; }
        public int studentID { get; set; }
        public override void showInfo()
        {
            Console.WriteLine($"ID : {id}\nFirst Name : {firstName}\nLast Name: {lastName}\nAge:  {age}\nStudentId: {studentID}\nDepartment: {department}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }

    }

    public class Officer : Person
    {
        public int salary { get; set; }
        public override void showInfo()
        {
            Console.WriteLine($"ID : {id}\nFirst Name : {firstName}\nLast Name: {lastName}\nAge:  {age}\nSalary: {salary}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }


}
