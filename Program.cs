// See https://aka.ms/new-console-template for more information
here:
Console.WriteLine("C# Programs\nPress 1 for Menu\nPress 0 for exit");
int c=Convert.ToInt32 (Console.ReadLine());
Console.Clear();
if (c == 1)
{
    Console.WriteLine("\t\t\t\t\t\tMENU");
    Console.WriteLine("--------------------------------------------------------------------------------------------");
    Console.WriteLine("Press 1 for Basic Program\nPress 2 for If else Statements Based Program\nPress 3 for Array based program\nPress 4 for function based program");
    int t = Convert.ToInt32(Console.ReadLine());
    switch (t)
    {
        //1
        case 1:
            Console.WriteLine("\"Basic Input/Output Program\"");
            Console.WriteLine("Enter Your Full Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome" + name);
            break;
        //2
        case 2:
            Console.WriteLine("\"Conditional Based Program\"");
            Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("You can Vote!!!");
            else
                Console.WriteLine("Not Eligible!!!");
            break;
        //3
            
        case 3:
            Console.WriteLine("\"Array Based Program\"");
            Console.WriteLine("Enter Size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter {0} Element's",size);
            for (int i = 0; i < size; i++)
            { a[i]=Convert.ToInt32(Console.ReadLine()); }
            Console.WriteLine("Array Elements Are:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]);
            }
            break;
        //4
        case 4:
            Console.WriteLine("5\"Functions\"");
            static int fun()
            {
                Console.WriteLine("Fuction is Invoked, Enter Two numbers:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                return (n1 + n2);
            }
            Console.WriteLine("Sum=" + fun());


            break;
       
        default:
            Console.WriteLine("Error");
            break;
    }
    goto here;
}
else
{
    Console.WriteLine("You are Successfully Exit!!!");
}
