/*
 Name: Zed Trzcinski
 Assign 3
 Date: 11/15/2016
 Professor: Peter Myers

 */

namespace CST276_Assign_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = null, location1 = null, location2 = null, movemnt = null, feedingBehavior = null;
            Morgs morgs = new Morgs(name, location1, location2, movemnt, feedingBehavior);
            ReadMorgs readMorgs = new ReadMorgs(new Cvs(new Extraction("state.txt")));
            var i = readMorgs.BuilldMorgs(morgs);
            MorgEnviroment enviroment = new MorgEnviroment();
            MorgsSimulator morgsSimulator = new MorgsSimulator(enviroment);
           
            foreach (var item in i)
            {
                enviroment.AddEntity(item);
                morgsSimulator.WeatherCondition(item.Location1);
                morgsSimulator.Step();
            }
            OrganicMorgs organicMorg = new OrganicMorgs(name, location1, location2, movemnt, feedingBehavior);
            ReadMorgs readorganicMorgs = new ReadMorgs(new Cvs(new Extraction("organictext.txt")));
            var d = readorganicMorgs.BuilldMorgs(organicMorg);
            OrganicEnviroment organicEnviroment = new OrganicEnviroment();
            OrganicSimulator organicSimulator =new OrganicSimulator(organicEnviroment);
            foreach (var organicItem  in d)
            {
                organicEnviroment.AddEntity(organicItem);
                organicSimulator.Step();
            }
            MechanicalMorgs mechanicalMorgs = new MechanicalMorgs(name, location1, location2, movemnt, feedingBehavior);
            ReadMorgs readmechanicalMorgs = new ReadMorgs(new Cvs(new Extraction("mechanical.txt")));
            var l = readmechanicalMorgs.BuilldMorgs(mechanicalMorgs);
            MechanicalEnviroment mechanicalEnviroment= new MechanicalEnviroment();
            MechanicalSimulator mechanicalSimulator = new MechanicalSimulator(mechanicalEnviroment);
            foreach (var mechItem in l)
            {
                mechanicalEnviroment.AddEntity(mechItem);
                mechanicalSimulator.Step();
            }
            CyborgMorgs cyborgMorgs= new CyborgMorgs(name, location1, location2, movemnt, feedingBehavior);
            ReadMorgs readmecyborglMorgs = new ReadMorgs(new Cvs(new Extraction("cyborg.txt")));
            var j = readmecyborglMorgs.BuilldMorgs(cyborgMorgs);
            CyborgEnviroment cyborgEnviroment = new CyborgEnviroment();
            CyborgSimulator cyborgSimulator = new CyborgSimulator(cyborgEnviroment);
            foreach (var cybItem in l)
            {
                cyborgEnviroment.AddEntity(cybItem);
                cyborgSimulator.Step();
            }

        }

        
    }
}
