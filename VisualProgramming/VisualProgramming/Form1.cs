using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace VisualProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("mUHAMMMET");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Furkan\source\repos\Week3\Week3\data.txt";

            string[] lines = {"Lorem Ipsum is simply dummy text of the printing and typesetting industry",
               "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
               "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged",
               "Contrary to popular belief, Lorem Ipsum is not simply random text."
            }; 


            

         

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList.Add("Max Verstappen");
            myList.Add("Daniel Ricciardo");
            myList.Add("Fernando Alonso");
            myList.Add(2000);
            myList.Add(2001);
            myList.Insert(1, "Second Pilot");

            myList.Reverse();

            ArrayList list2 = new ArrayList();
            list2.Add(1);
            list2.Add(5);
            list2.Add(9);
            list2.Add("Banana");

            myList.AddRange(list2);
            myList.InsertRange(2, list2);




            Console.WriteLine("Search : ");
            string searchKeyword = Console.ReadLine();
            int index1 = myList.IndexOf(searchKeyword);

            if (index1 == -1)
            {
                Console.WriteLine("{0} doesn't exist in the list", searchKeyword);
            }
            else
            {
                Console.WriteLine("Value {0} : {1}", index1, myList[index1]);
            }



            if (myList.Contains(2000))
            {
                Console.WriteLine("it exists");
            }
            else
            {
                Console.WriteLine("doesn't exist");
            }


            myList.Clear();
            myList.Sort();



            Console.Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
         
            ht.Add("001", "Fatma Özlem Acar");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Özde	Acarkan");
            ht.Add("004", "Hacı Mehmet Adıgüzel");
            ht.Add("005", "Mükerrem Zeynep Ağca");
            ht.Add("006", "Kerime Hacer	Akıllı");
            ht.Add("007", "Berker Akkiray");

            if (ht.ContainsValue("Özde	Acarkan"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }


            if (ht.ContainsKey("001"))
            {
                Console.WriteLine("This key  is already exist in the list");
            }
            else
            {
                Console.WriteLine("Not Found");
            }



             
            // Get a collection of the values.
            ICollection values = ht.Values;
            ArrayList list1 = new ArrayList();
            list1.AddRange(values);



            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
        }

        private void fFİLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
