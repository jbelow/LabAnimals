using System;

namespace LabAnimals
{
    /**
     * Created by mgreen14 on 12/27/17.
     */
    abstract class Person
    {
        public string Name{ get; set;}

        public Person(string name)
        {
            Name = name;
        }

    }
}