using System;

namespace LabAnimals
{

    class UserInput
    {

        public Talkable CreateNewAnimal()
        {
            Talkable animal;
            Console.WriteLine("what type of animal they want to create? \n 1) Dog \n 2) Cat \n 3) Teacher \n 0) exit");
            int userInput = Int32.Parse(Console.ReadLine());


            Console.WriteLine("What is the name: ");
            string userName = Console.ReadLine();

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Is it a friendly dog: Y/N ");
                    string userBool = Console.ReadLine();
                    bool friendly = false;
                    if (userBool.ToUpper().Equals("Y"))
                    {
                        friendly = true;
                    }

                    animal = new Dog(friendly, userName);
                    break;

                case 2:
                    Console.WriteLine("Mouses Killed: ");
                    int killCount = Int32.Parse(Console.ReadLine());

                    animal = new Cat(killCount, userName);
                    break;

                case 3:
                    Console.WriteLine("Teacher age: ");
                    int age = Int32.Parse(Console.ReadLine());

                    animal = new Teacher(age, userName);
                    break;


                default:
                    animal = new Cat(21, "bob");
                    break;
               
            }

            return animal;
                
        }

    }

}