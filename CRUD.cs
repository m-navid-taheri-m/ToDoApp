using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{       public class Crud
    {
       

        public static void Create(string? myTask, ref List<string?> myList)
        {

           
   
            try
            {
                myList.Add(myTask);

                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine($"Task {myTask} has been successfully added  to your list.");
                Console.WriteLine("\n");
                Show(myList);
                Console.WriteLine("\n");

                Console.WriteLine("count :" + myList.Count());

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               
            }


        }


        public static void Update(ref List<string?> myList)
        {
            Console.WriteLine("Enter the index of the task that you want to update : \n");
            var myListIndex = Convert.ToInt32(Console.ReadLine());
            
            var strings = myList.ToArray();

            Console.WriteLine("Enter any text to update the index : ");
            strings[myListIndex] = Console.ReadLine();
            myList = strings.ToList();

            Console.WriteLine($"The task on index {myListIndex}  has been updated ");

            Show(myList);


        }
       public static void Delete(ref List<string?> myList)
        {

            Console.WriteLine("Enter the index of the task that you want to be deleted ?");
            var myIndex = Convert.ToInt32(Console.ReadLine());
            myList.RemoveAt(myIndex);

            Console.WriteLine($"The task {myIndex} has been deleted successfully !");
            Show(myList);

        }

       public static void Show(List<string?> myList)
       {
             Console.WriteLine("Your tasks so far : ");

            foreach (var variable in myList) 
                Console.WriteLine(variable + "[" + myList.IndexOf(variable) + "]");


       }




    }
}
