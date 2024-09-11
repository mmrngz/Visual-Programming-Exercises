using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace yeniconsol
{
    internal class Program
    {



        static void Main(string[] args)
        {



            ArrayList myList = new ArrayList();
            myList.Add("Max Verstappen");
            myList.Add("Daniel Ricciardo");
            myList.Add("Fernando Alonso");
            myList.Add(2000);
            myList.Add(2001);

            Console.WriteLine("Search : ");
            string searchKeyword = Console.ReadLine();
            int index1 = myList.IndexOf(searchKeyword);
            if (index1 == -1)
            {
                Console.WriteLine(searchKeyword + " doesn't exist in the list");
            }
            else
            {
                Console.WriteLine("Value {0} : {1}", index1, myList[index1]);
            }
            Console.Read();
        }



    }

            
        
         
     
         
   

}
