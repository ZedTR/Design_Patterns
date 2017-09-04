using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace CST276_Assign_3
{
    class Morgs: Entity
    {
        public override void Eat(string e)
        {
            Console.WriteLine(" feeding behavior " + e);
        }
        private string name;
        private string location1;
        private string location2;
        private string feedBehavior;
        private string movemnet;
       
        public Morgs(string name, string location1, string location2, string feedBehavior, string movemnet) 
        {
            this.name =name;
            this.location1 = location1;
            this.location2 = location2;
            this.feedBehavior = feedBehavior;
            this.movemnet = movemnet;
        }
        public string Name { get { return name; } }
        public string Location1 { get { return location1; } }
        public string Location2 { get { return location2; } }
        public string FeedingBehavior { get { return feedBehavior; } }
        public string Movement { get{ return movemnet;} }
    }
}
