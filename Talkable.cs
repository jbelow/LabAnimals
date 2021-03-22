using System;

namespace LabAnimals
{

    /**
     * Created by mgreen14 on 12/27/17.
     */
    interface Talkable
    {
        string Talk();

        // string getName();
        string Name
        {
            get { return Name; }
        }

    }
}