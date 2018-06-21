using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHuman
    {
        public int _hits { get; set; }
        public string _name { get; set; }
        public double _superpower { get; set; }


        public SuperHuman(int hits, String name, double superpower)
        {
            _hits = hits;
            _name = name;
            _superpower = superpower;
            
        }
    }
}
