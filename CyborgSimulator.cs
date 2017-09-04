using System;
using Framework;
using Environment = Framework.Environment;


namespace CST276_Assign_3
{
    class CyborgSimulator:MorgsSimulator
    {
        public CyborgSimulator(Environment environment) : base(environment)
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
                    case "A":
                        Console.WriteLine("cyborg morg type is:" + morgs.Name);
                        break;
                    case "B":
                        Console.WriteLine("cyborg morg type is:" + morgs.Name);
                        break;
                    case "C":
                        Console.WriteLine("cyborg morg type is:" + morgs.Name);
                        break;
                    case "D":
                        Console.WriteLine("cyborg morg type is:" + morgs.Name);
                        break;
                    default:
                        Console.WriteLine("cyborg morg type is:" + morgs.Name);
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
                    case "Absorbs B C":
                        Console.WriteLine(morgs.Name + " have absorbed Type B and C");
                        break;
                    case "Envelops A":
                        Console.WriteLine(morgs.Name + " have envolped Type A");
                        break;
                    case "Envelops A B":
                        Console.WriteLine(morgs.Name + " have enveloped Type A and B");
                        break;
                    case "Absorbs C":
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
                    case "Paddles":
                        Console.WriteLine(morgs.Name + " is flying");
                        break;
                    case "Oozes":
                        Console.WriteLine(morgs.Name + " is crawling");
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
                    case "24":
                        x = 24;
                        break;
                    case "13":
                        x = 13;
                        break;
                    case "6":
                        x = 6;
                        break;
                    case "21":
                        x = 21;
                        break;
                    default:
                        x = 1;
                        break;
                }
                switch (position2)
                {
                    case "33":
                        y = 33;
                        break;
                    case "42":
                        y = 42;
                        break;
                    case "7":
                        y = 7;
                        break;
                    case "6":
                        y = 6;
                        break;
                    default:
                        y = 1;
                        break;
                }
            }
            alogrithim = x + y;
            if (alogrithim / 2 > 0)

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
