using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace CST276_Assign_3
{
    class MechanicalMorgs: Morgs
    {
        public override void Eat(string e)
        {
            Console.WriteLine(" feeding behavior " + e);
        }


        public MechanicalMorgs(string name, string location1, string location2, string feedBehavior, string movemnet) : base(name, location1, location2, feedBehavior, movemnet)
        {
        }
    }
}
