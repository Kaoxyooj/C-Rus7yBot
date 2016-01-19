using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Rus7yBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Body body = new Body();
            Head head = new Head();
            Leg leg = new Leg();
            Arm arm = new Arm();
            LeftArm lArm = new LeftArm();
            RightArm rArm = new RightArm();
            LeftLeg lLeg = new LeftLeg();
            RightLeg rLeg = new RightLeg();
            head.scan();
            Console.WriteLine("Rus7y attacks with the Chest Cannon");
            body.ChestCannonSound();
            Console.WriteLine("The enemy shook it off with ease.");
            lArm.forceShield();
            rLeg.propulsion();
            rArm.saber();
            Console.WriteLine("Scanner confirms that the lifeform is now lifeless.");

            Console.ReadKey();
        }
    }
}
