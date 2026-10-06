using System.Security.Cryptography;
using System.Threading.Channels;

namespace TASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int countnum = 0;
            int newnum = 0;
            int smallnum = 0;
            int largenum = 0;
            double mean = 0.0;
            char[] chars = { 'P', 'A', 'M', 'S', 'L', 'F', 'C', 'Q' };
            char user;
            bool check; // this is for check duplicated entries
            bool find = false;
            // bonus: Dont allow duplicate entries
            // bonus: new shortcut <B>
            // ma3loma bs ana msh Ai



            do
            {
                Console.WriteLine("---------------- Task2 ----------------");
                Console.WriteLine("Main Menu");
                Console.WriteLine("!Choose a Character!");
                Console.WriteLine("P - Print Numbers");
                Console.WriteLine("A - Add a Number");
                Console.WriteLine("M - Display Mean Of The Numbers");
                Console.WriteLine("S - Display The Smallest Number");
                Console.WriteLine("L - Display The Largest Number");
                Console.WriteLine("F - Find a Number In The List");
                Console.WriteLine("C - Clear The List");
                Console.WriteLine("B - Print Odd Numbers");
                Console.WriteLine("Q - Quit");
                user = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();


                switch (user)
                {
                    case 'P':
                        if (countnum == 0)
                        {
                            Console.WriteLine("The List Is Empty!");
                        }
                        else
                        {
                            for (int i = 0; i < countnum; i++)
                            {
                                Console.WriteLine($"[ {numbers[i]} ]");
                            }
                        }
                        break;
                    case 'A':
                        if (countnum < numbers.Length)
                        {
                            check = false;
                            Console.WriteLine("Add a Number");
                            newnum = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < countnum; i++)
                            {
                                if (numbers[i] == newnum)
                                {
                                    check = true;

                                    break;
                                }
                            }
                            if (check)
                            {
                                Console.WriteLine("The Number You Enterd Is Already Exist!");

                            }
                            else
                            {
                                numbers[countnum] = newnum;
                                countnum++;
                                Console.WriteLine("The Number You Entered Was Added Succefully");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The List Is Full!");
                        }

                        break;

                    case 'M':
                        if (countnum == 0)
                        {
                            Console.WriteLine("No Data To Calculate!");
                        }
                        else
                        {
                            double sum = 0;
                            for (int i = 0; i < countnum; i++)
                            {
                                sum += numbers[i];
                            }
                            mean = sum / countnum;
                            Console.WriteLine($"The Mean Is {mean}");
                        }
                        break;

                    case 'S':
                        if (countnum == 0)
                        {
                            Console.WriteLine("Unable to Find The Smallest Number!");
                        }
                        else
                        {

                            smallnum = numbers[0];
                            for (int i = 1; i < countnum; i++)
                            {
                                if (numbers[i] < smallnum)
                                {
                                    smallnum = numbers[i];
                                }
                            }
                            Console.WriteLine($"The Smallest Number Is {smallnum}");
                        }

                        break;

                    case 'L':
                        if (countnum == 0)
                        {
                            Console.WriteLine("Unable to Find The Largest Number!");
                        }
                        else
                        {

                            largenum = numbers[0];
                            for (int i = 1; i < countnum; i++)
                            {
                                if (numbers[i] > largenum)
                                {
                                    largenum = numbers[i];
                                }
                            }
                            Console.WriteLine($"The Largest Number Is {largenum}");
                        }
                        break;

                    case 'F':
                        if (countnum == 0)
                        {
                            Console.WriteLine("The List Is Empty!");
                        }

                        else
                        {
                            Console.WriteLine("Enter a Number You Want to Search for!");
                            int findnum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"The Number {findnum} Is Exist!");
                            find = false;
                            for (int i = 0; i < countnum; i++)
                            {
                                if (numbers[i] == findnum)
                                {
                                    find = true;
                                    break;
                                }

                            }
                            if (find)
                            {
                                Console.WriteLine($"The Number {findnum} Is Exist");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"The Number {findnum} Is Not Exist!");

                            }


                        }
                        break;

                    case 'C':
                        countnum = 0;
                        Console.WriteLine("List Cleared");
                        break;
                    //دي فكرة من عندي للبونص
                    case 'B':
                        if (countnum == 0)
                        {

                                Console.WriteLine("The List Is Empty!");
                           
                        }

                        else
                        { 
                            bool oddnums = false;
                        for (int i = 0; i < countnum; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.WriteLine($"[ {numbers[i]} ]");
                                    oddnums = true;
                            }
                        }
                            if (!oddnums)
                            {
                                Console.WriteLine("There Is No Odd Numbers!");
                            }
                        }
                        break;

                    case 'Q':
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            }
            while (user != 'Q');





            Console.WriteLine("---------------- Task2 Ended ----------------");




        }








    }
}
