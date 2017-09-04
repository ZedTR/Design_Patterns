using System;
using Framework;
using Environment = Framework.Environment;

namespace CST276_Assign_3
{
    class OrganicSimulator: MorgsSimulator
    {
        public OrganicSimulator(Environment environment) : base(environment)
        {
        }
        protected override void Type(Entity e)
        {
            Morgs morgs = e as Morgs;
            if (morgs != null)
            {
                var type = morgs.Name;
                switch (type)
                {
                    case "N":
                        Console.WriteLine("organic morg type is:" + morgs.Name);
                        break;
                    case "K":
                        Console.WriteLine("organic morg type is:" + morgs.Name);
                        break;
                    case "F":
                        Console.WriteLine("organic morg type is:" + morgs.Name);
                        break;
                    case "G":
                        Console.WriteLine("organic morg type is:" + morgs.Name);
                        break;
                    default:
                        Console.WriteLine("organic morg type is:" + morgs.Name);
                        break;
                }
            }
        }
      

        protected override void Hunt(Entity e)
        {
            Morgs morgs = e as Morgs;
            if (morgs != null)
            {
                var hunting = morgs.FeedingBehavior;
                switch (hunting)
                {
                    case "Absorbs K G":
                        Console.WriteLine(morgs.Name + " have absorbed Type B and C");
                        break;
                    case "Envelops G":
                        Console.WriteLine(morgs.Name + " have envolped Type A");
                        break;
                    case "Envelops N K":
                        Console.WriteLine(morgs.Name + " have enveloped Type A and B");
                        break;
                    case "Absorbs N":
                        Console.WriteLine(morgs.Name + " have abosorbed Type C");
                        break;
                    default:
                        Console.WriteLine(morgs.Name + " is sleeping!!!");
                        break;
                }
            }
        }

        protected override void Move(Entity e)
        {
            Morgs morgs = e as Morgs;
            if (morgs != null)
            {
                var action = morgs.Movement;
                switch (action)
                {
                    case "Invades":
                        Console.WriteLine(morgs.Name + " is Invading");
                        break;
                    case "Hides":
                        Console.WriteLine(morgs.Name + " is Hiding");
                        break;
                    default:
                        Console.WriteLine(morgs.Name + " is not moving!!!");
                        break;
                }
            }
        }

        protected override bool CloseEnough(Entity e)
        {
            var x = 0;
            var y = 0;
            bool closeToAct = true;
            bool tooFar = false;
            var alogrithim = 0;
            Morgs morgs = e as Morgs;
            if (morgs != null)
            {

                var position1 = morgs.Location1;
                var position2 = morgs.Location2;
                switch (position1)
                {
                    case "11":
                        x = 11;
                        break;
                    case "7":
                        x = 7;
                        break;
                    case "22":
                        x = 22;
                        break;
                    default:
                        x = 0;
                        break;
                }
                switch (position2)
                {
                    case "10":
                        y = 10;
                        break;
                    case "12":
                        y = 12;
                        break;
                    case "7":
                        y = 7;
                        break;
                    default:
                        y = 5;
                        break;
                }
            }
            alogrithim = x + y;
            if (alogrithim / 2 < 10)

                return closeToAct;
            else
                return tooFar;
        }

        protected override void Eat(Entity e)
        {
            Morgs morgs = e as Morgs;
            if (CloseEnough(morgs))
            {
                Type(morgs);
                Move(morgs);
                Hunt(morgs);
            }
            else
            {
                Type(morgs);
                Move(morgs);
            }
        }
    }
}
