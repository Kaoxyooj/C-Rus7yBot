using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Rus7yBot
{
    class LeftArm : Arm
    {
         bool miniNuke = true;
         bool shoulderRocketPack = true;
         bool forceFieldShield = true;

        public void forceShield()
        {
            Console.WriteLine("The enemey attacks! But with quick reflexes Rus7y blocks with the ForceShield.");
        }

    }
}
