using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Developer:Ben de Rijk
//Student ID: 9893223
//Project: Adding 2 matrices

namespace Assignement_question_3_Adding_matricies
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //Reference links that heleped me
        //https://www.tutorialspoint.com/chash-program-to-add-two-matrices
        //https://stackoverflow.com/questions/20776768/2d-array-in-c-sharp-with-random-numbers
              

            //Random number generator to populate matrices
            Random random = new Random();

            //Declaring 3 unpopulated matrices that have a row and column of 3 values 
            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            int[,] matrixC = new int[3, 3];

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("******This application will display the result of 2 matrices added together******");
            Console.WriteLine("*********************************************************************************");

            //Populating Matrix A with random numbers
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    matrixA[i, j] = random.Next(-10, +10);

                }
            }
            //Displaying Matrix A with a for loop in a 3x3 box format
            Console.Write("\n******Matrix A******\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", matrixA[i, j]);
            }
            Console.Write("\n\n");

            //Populating Matrix B with random numbers
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    matrixB[i, j] = random.Next(-10, +10);

                }
            }

            //Displaying Matrix B with a for loop in a 3x3 box format
            Console.Write("\n******Matrix B******\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", matrixB[i, j]);
            }
            Console.Write("\n\n");

            Console.WriteLine("Would you like to see the result of the 2 matrices added together? Y/N");
            string user = Console.ReadLine().ToLower();

            if(user == "y")
            {

            //Populating Matrix B with numbers from the addition of Matrix A & B
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                 matrixC[i, j] = matrixA[i, j] + matrixB[i, j];

            //Displaying Matrix C with a for loop in a 3x3 box format
            Console.Write("\n******Matrix C is Matrix A and Matrix B added together******\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", matrixC[i, j]);
            }
            Console.Write("\n\n");

            }

            else
            {
                Console.WriteLine("Press any key to exit");
            }

            Console.ReadKey();
        }

    }

}
    

