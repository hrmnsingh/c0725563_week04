using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0725563_week04
{

    class Program

    {

        static void Main(string[] args)

        {

            Countryside c = new Countryside();

            c.run();

            c.travel();

            Console.ReadLine();



        }

    }



    class LearningExperiment
    {

        public void run()
        {

            Village Toronto;

            Toronto = new Village();

            Village a, b, c;

            Toronto.villageName = "version A";

            a = Toronto;

            Console.WriteLine(a.villageName);

            Toronto = new Village();

            Toronto.villageName = "version B";

            b = Toronto;

            Console.WriteLine(b.villageName);

            Toronto = new Village();

            Toronto.villageName = "version C";

            c = Toronto;

            Console.WriteLine(c.villageName);





        }

    }





    class Village

    {

        public bool isAstrildeHere;

        public Village nextVillage;

        public Village prevVillage;

        public string villageName;

    }



    class Countryside

    {

        Village Toronto, Maple, Ajax, CurrentVillage;



        public void run()

        {

            Maple = new Village();

            Toronto = new Village();

            Ajax = new Village();

            Ajax.villageName = "Ajax";

            Ajax.isAstrildeHere = true;

            Maple.villageName = "Maple";

            Maple.nextVillage = Toronto;

            Toronto.nextVillage = Ajax;

            Toronto.villageName = "Toronto";

            Ajax.nextVillage = null;

        }

        public void travel()

        {

            CurrentVillage = Maple;



            while (true)

            {

                if (CurrentVillage.isAstrildeHere)
                {

                    Console.WriteLine("Astrilde is in " + CurrentVillage.villageName);

                    Console.ReadLine();
                }

                else { CurrentVillage = CurrentVillage.nextVillage; }

            }





















        }

    }





}
