using System;

namespace LabAnimals
{

    /**
     * Created by mgreen14 on 12/28/17.
     */
    class Cat : Pet, Talkable
    {
        private int mousesKilled { get; set; }



        public Cat(int mousesKilled, string name) : base(name)
        {
            this.mousesKilled = mousesKilled;

        }

        public void addMouse()
        {
            mousesKilled++;
        }


        public string Talk()
        {
            return "Meow";
        }

        override
        public string ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + mousesKilled;
        }
    }
}