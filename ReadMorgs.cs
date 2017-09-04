
using System.Collections.Generic;
using System.Linq;


namespace CST276_Assign_3
{
    class ReadMorgs : ReadFileDecarator
    {
        public ReadMorgs(ReadMorgFile wrapped)
            : base(wrapped)
        {
        }

        public override string GetState()
        {

            
            return   WrappedMorgs.GetState().Substring(WrappedMorgs.GetState().Length+ Begin(0), End(95));
            

        }

        public List<Morgs> BuilldMorgs(Morgs m)
        {
            
            var x = WrappedMorgs.GetState().Substring(WrappedMorgs.GetState().Length + Begin(0), End(95)).ToArray();
            var name = x.GetValue(0).ToString();
            var location1 = x.GetValue(1).ToString()+x.GetValue(2);
            var location2 = x.GetValue(3).ToString()+ x.GetValue(4);
            var movemnt = x.GetValue(5).ToString()+ x.GetValue(6)+x.GetValue(7)+x.GetValue(8)+x.GetValue(9)+x.GetValue(10)+x.GetValue(11);
            var feedingBehavior = x.GetValue(12).ToString() +x.GetValue(13)+x.GetValue(14)+x.GetValue(15)+x.GetValue(16)+x.GetValue(17)+x.GetValue(18)+x.GetValue(19)+
                                        x.GetValue(20) + x.GetValue(21)+ x.GetValue(22);
            var nameMechanical = x.GetValue(27).ToString();
            var location1Mechanical = x.GetValue(28).ToString() + x.GetValue(29);
            var location2Mechanical = x.GetValue(30).ToString() + x.GetValue(31);
            var movementMechanical = x.GetValue(32).ToString() + x.GetValue(33) + x.GetValue(34) + x.GetValue(35) +
                                      x.GetValue(36);
            var feedingMechanicalBehavior = x.GetValue(37).ToString() + x.GetValue(38) + x.GetValue(39) + x.GetValue(40) +
                                            x.GetValue(41) + x.GetValue(42) + x.GetValue(43) + x.GetValue(44) +
                                            x.GetValue(45) + x.GetValue(46);
            var nameOrganic = x.GetValue(51).ToString();
            var location1Organic = x.GetValue(52).ToString();
            var location2Organic = x.GetValue(53).ToString();
            var movementOrganic = x.GetValue(54).ToString() + x.GetValue(55) + x.GetValue(56) + x.GetValue(57) +
                                  x.GetValue(58) + x.GetValue(59) + x.GetValue(60);
            var feedingOrganicBehavior = x.GetValue(61).ToString() + x.GetValue(62) + x.GetValue(63) + x.GetValue(64) +
                                         x.GetValue(65) + x.GetValue(66) + x.GetValue(67) + x.GetValue(68) +
                                         x.GetValue(69) + x.GetValue(70) + x.GetValue(71) + x.GetValue(72);
            var nameCyborg = x.GetValue(77).ToString();
            var location1Cyborg = x.GetValue(78).ToString() + x.GetValue(79);
            var location2Cyborg = x.GetValue(80).ToString();
            var movementCyborg = x.GetValue(81).ToString() + x.GetValue(82) + x.GetValue(83) + x.GetValue(84) +
                                  x.GetValue(85) + x.GetValue(85);
            var feedingCyborgBehavior = x.GetValue(86).ToString() + x.GetValue(87) + x.GetValue(88) + x.GetValue(89) +
                                        x.GetValue(90) + x.GetValue(91) + x.GetValue(92) + x.GetValue(93) + x.GetValue(94);                           
            Morgs morg = new Morgs(name, location1, location2, feedingBehavior, movemnt);
            MechanicalMorgs mechanicalMorgs = new MechanicalMorgs(nameMechanical, location1Mechanical, location2Mechanical, movementMechanical, feedingMechanicalBehavior);
            OrganicMorgs organicMorgs = new OrganicMorgs(nameOrganic, location1Organic, location2Organic, movementOrganic, feedingOrganicBehavior);
            CyborgMorgs cyborgMorgs = new CyborgMorgs(nameCyborg, location1Cyborg, location2Cyborg, movementCyborg, feedingCyborgBehavior);
            List<Morgs> h = new List<Morgs>();
            

            h.Add(morg);
            h.Add(mechanicalMorgs);
            h.Add(organicMorgs);
            h.Add(cyborgMorgs);
            
                return h;
            
            

        }
        public override void Close()
        {
            WrappedMorgs.Close();
        }

        public int Begin(int begin)
        {
            return begin;
        }

        public int End(int end)
        {
            return end;
        }
    }
}
