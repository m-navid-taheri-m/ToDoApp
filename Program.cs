using System.Threading.Channels;

namespace ToDoApp;

internal class Program
{ 
    
    private static void Main(string[] args)
    {
        
        var endApp = false;

        var myList = new List<string?>();

        var crud = new Crud();

        Console.WriteLine("\t\t\t------------- Welcome to the ToDoApp! -------------\t\t\t");
        while (!endApp)
        {
            
            Console.WriteLine("Choose your options : ");
            Console.WriteLine("\tc -Create a task");
            Console.WriteLine("\td -Delete a task");
            Console.WriteLine("\tu -Update a task");
            Console.WriteLine("\ts -Show your list");
            var option = Console.ReadLine() ?? throw new InvalidOperationException();


            switch (option)
            {

                case "s":
                    Crud.Show(myList);
                    break;
                case "c":

                    Console.WriteLine("Enter any text to be added as your task :");
                            Crud.Create(Console.ReadLine()!, ref myList);                
                    break;
                case "d":
                    Crud.Delete(ref myList);
                    break;
                case "u":

                    
                    Crud.Update(ref myList);
                    break;
              
              
            }
        }


    }
}