using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;

namespace Library.Initializer
{
    public static class DataInitializer 
    {
       
        public static void Seed(ModelBuilder modelBuilder) 
        {
            string password1=BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");
            modelBuilder.Entity<AppUser>().HasData
              (
                new AppUser() { ID = 1, UserName = "Muhammet" , Password =password1 , Role =Enums.Role.admin },
                new AppUser() { ID = 2,UserName= "Duhan" ,Password= password2,Role= Enums.Role.user}

              ) ;
            modelBuilder.Entity<Student>().HasData
              (
                new Student() { ID = 1,FirstName = "Muhammet",LastName="Marangoz",SchoolNumber ="2010213025" },
                new Student() { ID = 2,FirstName = "Duhan", LastName = "Avcı", SchoolNumber = "2010213024" },
                new Student() { ID = 3,FirstName = "Muha", LastName = "Mar", SchoolNumber = "2010213026" },
                new Student() { ID = 4,FirstName = "Duh", LastName = "Av", SchoolNumber = "2010213027" }



              );
            modelBuilder.Entity<StudentDetail>().HasData
             (
               new StudentDetail() { ID = 1, StudentID = 1, BirthDay = new DateTime(1997,11,30),Gender=Enums.Gender.man  },
               new StudentDetail() { ID = 2, StudentID = 2, BirthDay = new DateTime(1996,11,30),Gender = Enums.Gender.woman},
               new StudentDetail() { ID = 3, StudentID = 3, BirthDay =  new DateTime(1995,11,30),Gender = Enums.Gender.man },
               new StudentDetail() { ID = 4, StudentID = 4, BirthDay =  new DateTime(1994,11,30),Gender = Enums.Gender.woman }



             );

        }
    }
}
