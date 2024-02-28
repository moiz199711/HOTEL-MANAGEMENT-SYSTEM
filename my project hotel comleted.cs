using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prject
{
    class Program
    {
        string phone;
        string room;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.logo();
        }
        public void entermain()
        {
            Console.WriteLine("\n\n\t\t\t====================================================");
            Console.WriteLine("\t\t\t\tPress M to MAIN MENU ");
            Console.WriteLine("\t\t\t\tPress E key to exit:");
            Console.WriteLine("\t\t\t====================================================");
            string E = Convert.ToString(Console.ReadLine());
            if (E == "m" || E == "M")
            {
                Console.Clear();
                Aftersuccessful();
                if (E == "a" || E == "A")
                {
                    Console.ReadLine();
                }
            }
        }
        public void choicefood()
        {
            int mixveg = 120;
            int palakpaneer = 60;
            int shahianeer = 80;
            int chanamasala = 50;
            int mottonkorma = 250;
            int mughlaimotton = 450;
            int mottonkarai = 350;
            int muttonmalaiboti = 320;
            int chickenkorma = 160;
            int chickenkarai = 160;
            int chickentandori = 200;
            int chickentikka = 120;
            int seekkabab = 80;
            int fishtikka = 100;
            int roti = 10;
            int nan = 15;
            int paratha = 15;
            int alooaratha = 40;
            int up = 25;
            int dew = 25;
            int sting = 30;
            int fanta = 25;
            int waterbottle = 20;
            int totalprice = 0;

            Console.WriteLine("\n                                Food And Menu                           ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                  VEGITABLES                   ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t1. mixveg \t\t\t Rs.120.00/-");
            Console.WriteLine("\t2. palakpaneer \t\t\t Rs.60.00/-");
            Console.WriteLine("\t3. shahipaneer \t\t\t Rs.80.00/-");
            Console.WriteLine("\t4. chanamasala \t\t\t Rs.50.00/-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                   MUTTON                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t5. Muttonkorma \t\t\t Rs.250.00/-");
            Console.WriteLine("\t6. mughlaimutton \t\t Rs.450.00/-");
            Console.WriteLine("\t7. muttonkarai \t\t\t Rs.350.00/-");
            Console.WriteLine("\t8. muttonmalaiboti \t\t Rs.320.00/-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                   CHICKEN                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t9. chickenkorma \t\t\t Rs.160.00/-");
            Console.WriteLine("\t10. chickenkarai \t\t\t Rs.160.00/-");
            Console.WriteLine("\t11. chickentamdori \t\t\t Rs.200.00/-");
            Console.WriteLine("\t12. chickentikka \t\t\t Rs.120.00/-");
            Console.WriteLine("\t13. seekhkabab \t\t\t\t Rs.80.00/-");
            Console.WriteLine("\t14. fishtikka \t\t\t\t Rs.100.00/-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                   BEVERAGES                      ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t15. 7up \t\t\t\t Rs.25.00/-");
            Console.WriteLine("\t16. Dew \t\t\t\t Rs.25.00/-");
            Console.WriteLine("\t17. string \t\t\t\t Rs.30.00/-");
            Console.WriteLine("\t18. fanta \t\t\t\t Rs.25.00/-");
            Console.WriteLine("\t19. water(pani) \t\t\t Rs.20.00/-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                   EXTRA'S                      ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t20. ROTI \t\t\t\t Rs.10.00/-");
            Console.WriteLine("\t21. nann \t\t\t\t Rs.15.00/-");
            Console.WriteLine("\t22. paratha \t\t\t\t Rs.20.00/-");
            Console.WriteLine("\t23. alooparatha \t\t\t Rs.40.00/-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.Write("Enter an item number you want to order: ");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    totalprice += mixveg;
                    Console.Write("Enter how many item you want to Add: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = totalprice * a;
                    Console.Write("Total Bill is: " + b);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 2:
                    totalprice += palakpaneer;
                    Console.Write("Enter how many item you want to Add: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    int d = totalprice * c;
                    Console.Write("Total Bill is: " + d);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 3:
                    totalprice += shahianeer;
                    Console.Write("Enter how many item you want to Add: ");
                    int e = Convert.ToInt32(Console.ReadLine());
                    int f = totalprice * e;
                    Console.Write("Total Bill is: " + f);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 4:
                    totalprice += chanamasala;
                    Console.Write("Enter how many item you want to Add: ");
                    int g = Convert.ToInt32(Console.ReadLine());
                    int h = totalprice * g;
                    Console.Write("Total Bill is: " + h);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 5:
                    totalprice += mottonkorma;
                    Console.Write("Enter how many item you want to Add: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    int j = totalprice * i;
                    Console.Write("Total Bill is: " + j);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 6:
                    totalprice += mughlaimotton;
                    Console.Write("Enter how many item you want to Add: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    int l = totalprice * k;
                    Console.Write("Total Bill is: " + l);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 7:
                    totalprice += mottonkarai;
                    Console.Write("Enter how many item you want to Add: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    int n = totalprice * m;
                    Console.Write("Total Bill is: " + n);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 8:
                    totalprice += muttonmalaiboti;
                    Console.Write("Enter how many item you want to Add: ");
                    int o = Convert.ToInt32(Console.ReadLine());
                    int p = totalprice * o;
                    Console.Write("Total Bill is: " + p);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 9:
                    totalprice += chickenkorma;
                    Console.Write("Enter how many item you want to Add: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    int r = totalprice * q;
                    Console.Write("Total Bill is: " + r);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 10:
                    totalprice += chickenkarai;
                    Console.Write("Enter how many item you want to Add: ");
                    int s = Convert.ToInt32(Console.ReadLine());
                    int t = totalprice * s;
                    Console.Write("Total Bill is: " + t);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 11:
                    totalprice += chickentandori;
                    Console.Write("Enter how many item you want to Add: ");
                    int u = Convert.ToInt32(Console.ReadLine());
                    int v = totalprice * u;
                    Console.Write("Total Bill is: " + v);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 12:
                    totalprice += chickentikka;
                    Console.Write("Enter how many item you want to Add: ");
                    int w = Convert.ToInt32(Console.ReadLine());
                    int x = totalprice * w;
                    Console.Write("Total Bill is: " + x);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 13:
                    totalprice += seekkabab;
                    Console.Write("Enter how many item you want to Add: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int z = totalprice * y;
                    Console.Write("Total Bill is: " + z);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 14:
                    totalprice += fishtikka;
                    Console.Write("Enter how many item you want to Add: ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    int b1 = totalprice * a1;
                    Console.Write("Total Bill is: " + b1);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 15:
                    totalprice += up;
                    Console.Write("Enter how many item you want to Add: ");
                   // Console.Clear();
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    int b2 = totalprice * a2;
                    Console.Write("Total Bill is: " + b2);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 16:
                    totalprice += dew;
                    Console.Write("Enter how many item you want to Add: ");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    int b3 = totalprice * a3;
                    Console.Write("Total Bill is: " + b3);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 17:
                    totalprice += sting;
                    Console.Write("Enter how many item you want to Add: ");
                    int a4 = Convert.ToInt32(Console.ReadLine());
                    int b4 = totalprice * a4;
                    Console.Write("Total Bill is: " + b4);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 18:
                    totalprice += fanta;
                    Console.Write("Enter how many item you want to Add: ");
                    int a5 = Convert.ToInt32(Console.ReadLine());
                    int b5 = totalprice * a5;
                    Console.Write("Total Bill is: " + b5);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 19:
                    totalprice += waterbottle;
                    Console.Write("Enter how many item you want to Add: ");
                    int a6 = Convert.ToInt32(Console.ReadLine());
                    int b6 = totalprice * a6;
                    Console.Write("Total Bill is: " + b6);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 20:
                    totalprice += roti;
                    Console.Write("Enter how many item you want to Add: ");
                    int a7 = Convert.ToInt32(Console.ReadLine());
                    int b7 = totalprice * a7;
                    Console.Write("Total Bill is: " + b7);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 21:
                    totalprice += nan;
                    Console.Write("Enter how many item you want to Add: ");
                    int a8 = Convert.ToInt32(Console.ReadLine());
                    int b8 = totalprice * a8;
                    Console.Write("Total Bill is: " + b8);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 22:
                    totalprice += paratha;
                    Console.Write("Enter how many item you want to Add: ");
                    int a9 = Convert.ToInt32(Console.ReadLine());
                    int b9 = totalprice * a9;
                    Console.Write("Total Bill is: " + b9);
                    Console.WriteLine("\nHave a nice day");
                    break;
                case 23:
                    totalprice += alooaratha;
                    Console.Write("Enter how many item you want to Add: ");
                    int a10 = Convert.ToInt32(Console.ReadLine());
                    int b10 = totalprice * a10;
                    Console.Write("Total Bill is: " + b10);
                    Console.WriteLine("\nHave a nice day");
                    break;
                default:
                    Console.WriteLine("sorry sir: This is not in the manu list");
                    break;
            }
         //   Aftersuccessful();

        }
        static void end()
        {
            Console.WriteLine("\n\n\n\n\n________________________________________________________________________________________________________________________");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t                             THANK YOU                         ");
            Console.WriteLine("\n\n\n\t\t                     FOR USING HOTEL MANAGEMENT                   ");
            Console.WriteLine("\n\n\t\t                         MADE BY MOIZ KHAN               ");
            Console.WriteLine("\t\t\n                                       MADE BY SYED ALI AHMED SHAH               ");
            Console.WriteLine("\t\t\n                                       MADE BY SOHAIB KHALID               ");
            Console.WriteLine("\t\t\n                                      INSTRUCTED BY MISS FIZZA               ");
            Console.WriteLine("\n\n\n________________________________________________________________________________________________________________________");
            Console.ReadKey();
        }

        public void logo()
        {
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("\n\t\t"); //logo
            Console.WriteLine("\t                                 $$  $$   $$$$$   $$$$$$$$  $$$$$$$  $$    ");
            Console.WriteLine("\t                                 $$  $$  $$   $$     $$     $$       $$     ");
            Console.WriteLine("\t                                 $$$$$$  $$   $$     $$     $$$$$    $$     ");
            Console.WriteLine("\t                                 $$  $$  $$   $$     $$     $$       $$     ");
            Console.WriteLine("\t                                 $$  $$   $$$$$      $$     $$$$$$$  $$$$$$ ");
            Console.WriteLine("\n");
            Console.WriteLine("\t      $$    $$  $$$$$$$  $$$$    $$  $$$$$$$   $$$$$$  $$$$$$$  $$    $$  $$$$$$$  $$$$    $$  $$$$$$$$  ");
            Console.WriteLine("\t      $$$  $$$  $$   $$  $$ $$   $$  $$   $$  $$       $$       $$$  $$$  $$       $$ $$   $$     $$     ");
            Console.WriteLine("\t      $$ $$ $$  $$$$$$$  $$  $$  $$  $$$$$$$  $$ $$$$  $$$$$    $$ $$ $$  $$$$$    $$  $$  $$     $$     ");
            Console.WriteLine("\t      $$    $$  $$   $$  $$   $$ $$  $$   $$  $$   $$  $$       $$    $$  $$       $$   $$ $$     $$     ");
            Console.WriteLine("\t      $$    $$  $$   $$  $$    $$$$  $$   $$    $$$$   $$$$$$$  $$    $$  $$$$$$$  $$    $$$$     $$     ");
            Console.WriteLine("\n\n");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tPLEASE PRESS Enter BUTTON....");
            Console.ReadLine();
            Console.Clear();
            login();

        }
        public void login()
        {
            Console.WriteLine("\t\t****************************************  LOGIN  ***********************************************");
            Console.Write("\n\n");
            Console.Write("\t\t\t\t\tPlease enter UserName: ");
            string user = Convert.ToString(Console.ReadLine());
            Console.Write("\t\t\t\t\tPlease enter Password: ");
            string pass = Convert.ToString(Console.ReadLine());
            if ((user == "user" || user == "User" || user == "USER") && (pass == "pass" || pass == "Pass" || pass == "PASS"))
            {
                Aftersuccessful();
            }
            else
            {
                Console.Write("\n");
                Console.WriteLine("\t\t\t\t\t      unsuccessful");
                Console.Clear();
                login();
            }
            Console.ReadLine();
        }
        public void roomno()
        {
            Console.Write("Enter Room Number: ");
            room = Console.ReadLine();
            long room_no_digit;
            bool isNumeric = long.TryParse(room, out room_no_digit);

            if (!isNumeric)
            {
                Console.WriteLine("-----Incorrect value!! Plese enter numeric value-----");
                roomno();
            }
        }
        public void phoneNo()
        {
            Console.Write("\n\nPHONE NO. : ");

            phone = Console.ReadLine();

            long phn_no_digit;
            bool isNumeric = long.TryParse(phone, out phn_no_digit);

            if (!isNumeric)
            {
                Console.WriteLine("\n\n-----Incorrect value!! Plese enter numeric value-----");
                Console.Clear();
                phoneNo();

            }


            if (phone.Length < 11 || phone.Length > 11)
            {
                Console.Write("\n\n-----PLEASE ENTER 11 DIGIT VALUE-----");
                phoneNo();
            }
        }
        public void dataenter()
        {
            Console.WriteLine("\n*************************");
            Console.WriteLine("\n Enter Customer Details:");
            Console.WriteLine("\n*************************");
            string Url = "MyStudent.txt";
            roomno();
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            phoneNo();
            Console.Write("Enter Nationality: ");
            string nationality = Console.ReadLine();
            Console.Write("Enter Email:");
            string email = Console.ReadLine();
            File.AppendAllText(Url, Environment.NewLine +room  + "  " + Name + "  " + address + "  " + phone + 
                "  " + nationality + "  " + email);
            Console.WriteLine("Enter Data Successfully");
            entermain();
        }

        public void Aftersuccessful()
        {
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n Enter 1 => Check In");
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n Enter 2 => Records");
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n Enter 3 => Food And Menu");
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n Enter 4 => Exit");
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\t\t\n\n **Please enter your choice **:");
            Console.WriteLine("\n");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case 1:
                    dataenter();
                    break;
                case 2:
                    Console.WriteLine("\t    -------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t   ********************************* RECORDS ********************************************");
                    Console.WriteLine("\t    -------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\n\t\t");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("\n Enter 1 => Search Records ");
                    Console.WriteLine("\n Enter 2 => Add More Records ");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("\n\t\t");
                    Console.WriteLine("PLEASE ENTER YOUR CHOICE");
                    int record = Convert.ToInt32(Console.ReadLine());
                    switch (record)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\t    -------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\t\t   ********************************* SEARCH RECORDS ********************************************");
                            Console.WriteLine("\t    -------------------------------------------------------------------------------------------------");

                            string[] student = File.ReadAllText("MyStudent.txt").Split(' ');
                            Console.WriteLine("Enter ID To Search");
                            string studenttobesearch = Console.ReadLine();
                            bool condition = false;
                            for (int i = 0; i < student.Length; i++)
                            {
                                if (student[i].Contains(studenttobesearch) == true)
                                {
                                    condition = true;
                                    break;
                                }
                                else
                                {
                                    condition = false;
                                }
                            }
                            if (condition == true)
                            {
                                Console.WriteLine("{0} found in data", studenttobesearch);
                            }
                            else
                            {
                                Console.WriteLine("{0} not found in data", studenttobesearch);
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\t    -------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\t\t   ********************************* ADD RECORDS ********************************************");
                            Console.WriteLine("\t    -------------------------------------------------------------------------------------------------");

                            dataenter();
                            break;
                    }
                    break;
                case 3:
                    choicefood();
                    entermain();
                    break;
                case 4:
                    end();
                    break;
                default:
                    Console.WriteLine("                  You Enter Wrong Choice");
                    Aftersuccessful();
                    break;
            }

        }
    }
}

