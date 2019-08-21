using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpTamagochi.Models
{
    public class Ufo
    {
        public long UfoId { get; set; }
        public string Name { get; set; }
        public int Hunger { get; set; }
        public List<Tricks> Tricks { get; set; }
        public long LastFed { get; set; }
        public bool IsAlive { get; set; }
        public Food Food { get; set; }
        public Drink Drink { get; set; }

        public Ufo()
        {
            LastFed = DateTime.Now.Millisecond;
        }
    }
}
