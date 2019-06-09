using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Developer:Ben de Rijk
//Student ID: 9893223
//Project: Login System


namespace Assignment_question_1_Login_system
{
    class Program
    {

        static void Main(string[] args)

        {
            //Welcome message with application description
            Console.WriteLine("*************Welcome to the Rorotua holiday park staff login area.*************");
            Console.WriteLine("********This application will set a username and password for you********");

            // Conditions to control the do while loops
            bool usernameRepeat = false;
            bool passwordRepeat = false;


            //Obtaining username wrapped in a do while loop so the question loops if requiremnts arent met
            do {
                Console.WriteLine("\nPlease enter a username with a minimum of 8 characters:");
                string username = Console.ReadLine();

                //Calling the method and determining whether to loop based on boolean
                if (ValidateUsername(username) == false)
                {
                    usernameRepeat = true;
                }
                else
                {  //Break out of the loop if opposite is true
                    break;
                }

            }while (usernameRepeat == true);


            //Obtaining password/confirm password wrapped in a do while loop so the questions loop if requiremnts arent met
            do
            {
                Console.WriteLine("\nPlease enter a password with a minimum of 8 characters:");
                string password = Console.ReadLine();


                Console.WriteLine("Please confirm your password:");
                string passwordConfirm = Console.ReadLine();

                //Conditional if statement based on whether the ValidatePassword method is true or false
                if (ValidatePassword(password, passwordConfirm) == false)
                {
                    passwordRepeat = true;
                }
                else
                {
                    break;
                }

            }while (passwordRepeat == true);


            Console.WriteLine($"\nThanks. Your username and password has been set.");

            Console.ReadLine();
                    
        }


            //Some information retrieved from https://stackoverflow.com/questions/5859632/regular-expression-for-password-validation?fbclid=IwAR20OdPMqaawmF0xtdIBSOIJsZqPdhk4s0wnW2-mHXxanQdSZXF3sROsCqg
            //Method for username validation
            static bool ValidateUsername(string username)
            {
                
                bool usernameRequirement = username.Length >= 8;
               
                if (username.Length < 8)
                {
                Console.WriteLine($"\nThe username '{username}' does not contain 8 characters. Please try again!\n");
                }
                else
                {
                Console.WriteLine($"\nThe username '{username}' is valid!\n");
                }

                return usernameRequirement;
            
            }
        
           //Method for password validation
            static bool ValidatePassword(string password, string passwordConfirm)
            {

                bool passwordLengthRequirement = password.Length >= 8;
                bool passwordMatchRequirement = passwordConfirm == password;

                if (password.Length < 8)
                {
                Console.WriteLine($"\nThe password '{password}' does not contain 8 characters. Please try again!\n");
                }

                else if(passwordConfirm != password)
                {
                Console.WriteLine($"\nThe passwords '{password}' and '{passwordConfirm}' do not match. Please try again.");
                }
                else
                {
                Console.WriteLine("\nPassword match!");
                }

                return passwordLengthRequirement && passwordMatchRequirement;

            }
    }
}

    

