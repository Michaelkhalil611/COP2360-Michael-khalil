using System;

namespace HandlingDivision
{
    class Program
    {
        static void Main(string[] args)
        {    //ask the user to enter the first number:
            Console.WriteLine("Please Enter your first number: ");
            string input_1 = Console.ReadLine();

            // ask the user to enter the second number:
            Console.WriteLine("Please enter your second number: ");
            string input_2 = Console.ReadLine();
            

            try // using try and catch statement to allow to define errors in a block of code.
            {    //Convery the strings to integers to be able to decide on a number. 
                int number_1 = Convert.ToInt32(input_1);
                int number_2 = Convert.ToInt32(input_2);
                
                // in result we divide number_1 on number_2
                int result = number_1/number_2;
                
                //When the right number gets entered print the result 
                Console.WriteLine($"The result of dividing {number_1} by {number_2} is:{result}");

                // using catch 
            } 
            catch (FormatException ex)//  It will catch an error if the input is not a valid integer 
             
            {
                Console.WriteLine("ERROR: One or both of the inputs are not correct numbers please Enter a valid number. ");
                
            }

            catch( DivideByZeroException) // it will catch if there is an attempt to Dicise by Zereo 
            {
                Console.WriteLine("ERROR: Divison by zero is not allowed pleass Enter a valid number");

            }

            catch(OverflowException) // it will catch if the number is too big or too small 
            {
                Console.WriteLine("ERROR: one or both numbers are too large  or to small please Enter a valid number");
            }

            catch(Exception ex) // it will catch any aother errors 
            {
                Console.WriteLine("ERROR: An unexpected error occured pleass try again");
            }

            finally // the finally it will print after the code ends every time no input is needed
            {
                Console.WriteLine("Thanks!!");
            }            
        }
    }
}


