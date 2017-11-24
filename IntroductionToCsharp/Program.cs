using System;

   class Program
    {
    private static string FirstName;
    private static string LastName;
    static void Main()
        {
        bool check = false;
        Console.WriteLine("Welcome to C# Training");
        Console.WriteLine("Please enter your firstname: ");
        FirstName = Console.ReadLine();
        for (int i = 0; i < FirstName.Length; i++)
        {

            if (FirstName[i] >= 'a' && FirstName[i] <= 'z' || FirstName[i] == ' ')
            {
                check = true;
            }
            else
            {
                check = false;

            }

        }

        if (check == false)
        {
            Console.WriteLine("Enter Valid Value");
            FirstName = Console.ReadLine();
        }

        Console.WriteLine("Please enter your lastname: ");
        LastName = Console.ReadLine();
        for (int i = 0; i < LastName.Length; i++)
        {
            if (LastName[i] >= 'a' && LastName[i] <= 'z' || LastName[i] == ' ')
            {
                check = true;
            }
            else
            {
                check = false;
            }

        }

        if (check == false)
        {
            Console.WriteLine("Enter Valid Value");
            LastName = Console.ReadLine();
        }
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        Console.ReadLine();
        //Console.WriteLine("Hello {1}", LastName);
        //Console.WriteLine("Hello " + UserName);*/


        /*int num, i, result;
        Console.WriteLine("Enter a number \t");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= 10; i++)
        {
            result = num * i;
            Console.WriteLine("{0} * {1} = {2}", num, i, result);
        }*/


        /*bool check = false;

        Console.WriteLine("Please Enter the Name");
        name = Console.ReadLine();

        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 'a' && name[i] <= 'z' || name[i] == ' ')
            {
                check = true;
            }
            else
            {
                check = false;
            }

        }

        if (check == false)
        {
            Console.WriteLine("Enter Valid Value");
            name = Console.ReadLine();
        }*/



    }

   
}

