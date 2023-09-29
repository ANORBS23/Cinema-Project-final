using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;//assigning variables
            bool newticket = false;
            bool date = false;
            int seating1 = 50;
            int seating2 = 50;
            int seating3 = 50;
            int seating4 = 50;
            int seating5 = 50;






            DateTime myDate = DateTime.Today;//setting the date so that is only accepts date from the current date to 1 week in future
            var addedDateTime = DateTime.Today.AddDays(7);
            while (date == false)
            {
                Console.WriteLine("please enter the date that you wish to attend the film.DD/MM/YYYY");
                try
                {
                    myDate = DateTime.Parse(Console.ReadLine());
                    if (myDate <= DateTime.Today.AddDays(7) && myDate >= DateTime.Today)
                    {
                        Console.WriteLine("your date was valid");
                        date = true;
                    }



                    else
                    {
                        Console.WriteLine("you cannot book for this date!");
                    }


                }
                catch (Exception a)//catches any unexpected inputs so doesnt crash code
                {
                    Console.WriteLine(a.ToString());
                    Console.WriteLine("invalid date entered");
                    date = false;
                    Console.ReadLine();
                }
            }

            while (valid == false && date == true)
            {

                //loops around until either logic statement changes




                Console.WriteLine("valid date entered");
                Console.WriteLine("welcome to aquinas multiplex,");
                Console.WriteLine("We are presently showing");
                Console.WriteLine("1)Rush[15]");
                Console.WriteLine(seating1 + "tickets remaining");
                Console.WriteLine("2)how I live[15]");
                Console.WriteLine(seating2 + "tickets remaining");
                Console.WriteLine("3)thor[12]");
                Console.WriteLine(seating3 + "tickets remaining");
                Console.WriteLine("4)Filth[18]");
                Console.WriteLine(seating4 + "tickets remaining");
                Console.WriteLine("5)Planes[U]");
                Console.WriteLine(seating5 + "tickets remaining");
                Console.WriteLine("please enter your age");


                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the number of the film that you want to watch");
                    int usrfilm = Convert.ToInt32(Console.ReadLine());//allows user to enter thefilm number



                    if (usrfilm > 0 && usrfilm < 6)//verifys that the number is in the required range
                    {

                        if (usrfilm == 1 && age >= 15)//verifys the user is old enough to enter
                        {
                            valid = true;
                            Console.WriteLine("You are old enough to watch the film");

                            seating1 = seating1 - 1;
                            Console.WriteLine("there are" + seating1 + "seats available");//shows how many remaining seats are available

                        }
                        else if (usrfilm == 1 && age < 15)//if user isn't old enough they will not be able to access film and sent back to main menu again to rebook
                        {

                            Console.WriteLine("Access denied");
                            valid = false;
                        }


                        if (usrfilm == 2 && age >= 15)
                        {
                            Console.WriteLine("You are old enough to watch the film");
                            seating2 = seating2 - 1;
                            Console.WriteLine("there are" + seating2 + "seats available");
                            valid = true;
                        }
                        else if (usrfilm == 2 && age < 15)
                        {

                            Console.WriteLine("Acess denied");
                            valid = false;
                        }


                        if (usrfilm == 3 && age >= 12)
                        {
                            Console.WriteLine("You are old enough to watch the film");
                            seating3 = seating3 - 1;
                            Console.WriteLine("there are" + seating3 + "seats available");
                            valid = true;
                        }
                        else if (usrfilm == 3 && age < 12)
                        {

                            Console.WriteLine("Acess denied");
                            valid = false;
                        }








                        if (usrfilm == 4 && age >= 18)
                        {
                            Console.WriteLine("You are old enough to watch the film");
                            seating4 = seating4 - 1;
                            Console.WriteLine("there are" + seating4 + "seats available");
                            valid = true;

                        }
                        else if (usrfilm == 4 && age < 18)
                        {

                            Console.WriteLine("Acess denied");
                            valid = false;
                        }

                        if (usrfilm == 5)
                        {
                            Console.WriteLine("You are old enough to watch the film");

                            valid = true;
                            seating5 = seating5 - 1;
                            Console.WriteLine("there are " + seating5 + "seats available");
                        }
                        if (valid == true)
                        {
                            Console.WriteLine("---------------------------");//ticket
                            if (usrfilm == 1)
                            {
                                Console.WriteLine("Film:Rush");//outputs the name of the film depending on the number of film that the user inputted
                            }
                            if (usrfilm == 2)
                            {
                                Console.WriteLine("Film:How I live");
                            }
                            if (usrfilm == 3)
                            {
                                Console.WriteLine("Film:Thor");
                            }
                            if (usrfilm == 4)
                            {
                                Console.WriteLine("Film:Filth");
                            }
                            if (usrfilm == 5)
                            {
                                Console.WriteLine("Film:Planes");
                            }
                            Console.WriteLine("Date attending: " + myDate);
                            Console.WriteLine("Enjoy the film");
                            Console.WriteLine("---------------------------");

                        }




                        Console.WriteLine("New Ticket y");//allows for user to get another ticket and if they don't it takes you to a new page
                        Console.WriteLine("press y for yes/Press any other character for no");

                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            ConsoleKeyInfo cki = Console.ReadKey();
                            newticket = cki.KeyChar == 'Y';
                            valid = false;
                            cki = Console.ReadKey();

                        }
                        else
                        {
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                Console.Clear();
                                Console.WriteLine("thanks for booking!");
                            }
                        }





                        Console.ReadLine();



















                    }










                }
                catch (Exception e)//deals with any execptions that werent expected therefore doesn't crash the program.
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("you entered an invalid film number please try again/invalid age");
                    Console.ReadLine();
                }
                Console.ReadLine();


            }


        }
    }
}
