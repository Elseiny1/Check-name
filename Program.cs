using System;

namespace Check_name
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of names: ");
            byte size=byte.Parse(Console.ReadLine());
            string[] names=new string[size];
            Console.WriteLine("Enter names: ");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter checked name");
            string checkname=Console.ReadLine();
            int j=0;
            do
            {
                if(checkname==names[j])
                { Console.WriteLine("success to find "+checkname); break; }
                else if(checkname!=names[j])
                { j++; }
            }while(j<size);
            if(j==size)
            { Console.WriteLine("Failed to find: " + checkname); }
        }

    }
}