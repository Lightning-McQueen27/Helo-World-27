using System;

namespace Hello_World_._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleString = "Hello World!";
            int exampleint = 4;
            float examplefloat = 50.5f;
            double exampledouble = 50.5;
            short examplesShort = 50;
            long examplelong = 50;

            bool exampleBoolean = true; //alternative: False
            char exampleChar = 'n'; //только 1 символ

            string[] hellos = { "Hallo", "Hello", "Ola", "Ciao" };

            Console.WriteLine(exampleString);

            //for
            //while
            //foreach



            //for (int i = 0; i < hellos.Length; i++)
            int i = 0;
            foreach (string hello in hellos)

                Console.WriteLine("Enter a symbol");
            exampleChar = Console.ReadLine()[0];

            switch (exampleChar)
            {
                case 'n':
                    Console.WriteLine("It's N");
                    break;
                case 't':
                    Console.WriteLine("It's T");
                    break;
                default:
                    Console.WriteLine("It is not any of known symbols");
                    break;
            }

        
            
        }
            

    }

}


