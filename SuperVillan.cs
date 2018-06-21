using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperVillan : SuperHuman
    {
        public int _life { get; set; }
        public int _strength { get; set; }

        public SuperVillan(int hits, string name, int life, double superpower, int strength) : base(hits, name, superpower)
        {
            _hits = hits;
            _name = name;
            _life = life;
            _superpower = superpower;
            _strength = strength;
        }

        public void damage(int _strength)
        {
            if(_strength == 30)
            {
                Console.WriteLine("you are alive");
                
            }
            else if(_strength <= 10)
            {
                Console.WriteLine("sorry you are dead! Evil King");

            }
            else
            {
                Console.WriteLine("you can still fight");
            }

        }


    }
}
