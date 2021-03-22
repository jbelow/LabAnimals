using System;
using System.Collections;



namespace LabAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            // Lines to Replace Begin Here
            // zoo.Add(new Dog(true, "Bean"));
            // zoo.Add(new Cat(9, "Charlie"));
            // zoo.Add(new Teacher(44, "Stacy Read"));



            bool boolAgain = false;
            do
            {
                UserInput newAnimal = new UserInput();
                zoo.Add(newAnimal.CreateNewAnimal());

                Console.WriteLine("Do you want to add another one: Y/N");
                string again = Console.ReadLine();

                if (again.ToUpper().Equals("Y"))
                {
                    boolAgain = true;
                } else if (again.ToUpper().Equals("N"))
                {
                    boolAgain = false;
                }

            } while (boolAgain);



            // End Lines to Replace

            foreach (Talkable thing in zoo)
            {
                Console.WriteLine(thing);
                printOut(thing);
            }

        }

        public static void printOut(Talkable p)
        {
            Console.WriteLine(p.Name + " says=" + p.Talk());
            // outFile.fileWrite(p.getName() + " | " + p.talk());
        }

    }


    
}


