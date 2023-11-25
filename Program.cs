using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cars.honda;

namespace Cars
{
    public class cars
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "" || value.Length >= 32)
                {
                    throw new Exception("Invalid name");
                }
                _name = value;
            }
        }
        private int _yearModel;
        public int YearModel
        {
            get { return _yearModel; }
            set
            {
                if (value < 1970 || value > 2023)
                {
                    throw new Exception("Invalid Year");
                }
                _yearModel = value;
            }
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new Exception("Invalid id");
                }
                _id = value;
            }
        }
        public string Color { get; set; }
        private double _price;
        public double price
        {
            get { return _price; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new Exception("Invalid price");
                }
                _price = value;
            }
        }
        public void Add_data() { }
        public void Show_data() { }
    }
    public class Marc : cars
    {
        public void Add_data()
        {
            File.AppendAllText("marc.txt", Id + " " + Name + " " + YearModel + " " + Color + " " + price + "$" + "*");
        }
        public string[] Show_data()
        {
            string s = File.ReadAllText("marc.txt");
            return s.Split('*');
        }

    }
    public class Lancer : cars
    {
        public void Add_data()
        {
            File.AppendAllText("lancer.txt", Id + " " + Name + " " + YearModel + " " + Color + " " + price + "$" + "*");
        }
        public string[] Show_data()
        {
            string s = File.ReadAllText("lancer.txt");
            return s.Split('*');
        }
    }
    public class honda : cars
    {
        public void Add_data()
        {
            File.AppendAllText("h.txt", Id + " " + Name + " " + YearModel + " " + Color + " " + price + "$" + "*");
        }
        public string[] Show_data()
        {
            string s = File.ReadAllText("h.txt");
            return s.Split('*');
        }
    }
    public class BMW : cars
    {

        public void Add_data()
        {
            File.AppendAllText("bmw.txt", Id + " " + Name + " " + YearModel + " " + Color + " " + price + "$" + "*");
        }
        public string[] Show_data()
        {
            string s = File.ReadAllText("bmw.txt");
            return s.Split('*');
        }
    }
    public class KIA : cars
    {
        public void Add_data()
        {
            File.AppendAllText("kia.txt", Id + " " + Name + " " + YearModel + " " + Color + " " + price + "$" + "*");
        }
        public string[] Show_data()
        {
            string s = File.ReadAllText("kia.txt");
            return s.Split('*');
        }
    }
        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    string c = "";
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********* Menu of cars *********");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n-----------------------------------\n\n 1- Adding item to list");
                    Console.WriteLine("\n 2- Show item from list");
                    Console.WriteLine("\n 3- Searching of item in list by Id");
                    Console.WriteLine("\n 4- Searching from list by item\n\n-----------------------------------\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Choose number of menu\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Option : ");
                    int te = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Clear();
                    if (te == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Please enter the password : ");
                        string pass = Console.ReadLine();
                        Console.WriteLine();
                        if (pass == "Sherlock")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------------\nCorrect Password\n----------------\n");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            int ch;
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("----------------------\n 1- Add car to Marc\n----------------------\n 2- Add car to Lancer\n----------------------\n 3- Add car to Honda\n" +
                                    "----------------------\n 4- Add car to BMW\n----------------------\n 5- Add car to KIA\n----------------------\n 6- Exit\n----------------------\n");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("Enter number of choice from Menu : ");
                                ch = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                int id = 0;
                                string name = "", color = "";
                                int model = 0; double price = 0;
                                if (ch == 1 || ch == 2 || ch == 3 || ch == 4 || ch == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(" Please enter id of car : ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("\n Please enter name of car : ");
                                    name = Console.ReadLine();
                                    Console.Write("\n Please enter year model : ");
                                    model = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("\n Please enter color of car : ");
                                    color = Console.ReadLine();
                                    Console.Write("\n Please enter price of car : ");
                                    price = Convert.ToDouble(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    switch (ch)
                                    {
                                        case 1:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Marc marc = new Marc();
                                            marc.Name = name; marc.Id = id; marc.YearModel = model; marc.Color = color; marc.price = price;
                                            marc.Add_data();
                                            Console.WriteLine("\nDone\nYour data is stored\n");
                                            break;
                                        case 2:

                                            Lancer lancer = new Lancer();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            lancer.Name = name; lancer.Id = id; lancer.YearModel = model; lancer.Color = color; lancer.price = price;
                                            lancer.Add_data();
                                            Console.WriteLine("\nDone\nYour data is stored\n");
                                            break;
                                        case 3:
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            honda h = new honda();
                                            h.Name = name; h.Id = id; h.YearModel = model; h.Color = color; h.price = price;
                                            h.Add_data();
                                            Console.WriteLine("\nDone\nYour data is stored\n");
                                            break;
                                        case 4:
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            BMW bm = new BMW();
                                            bm.Name = name; bm.Id = id; bm.YearModel = model; bm.Color = color; bm.price = price;
                                            bm.Add_data();
                                            Console.WriteLine("\nDone\nYour data is stored\n");
                                            break;
                                        case 5:
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            KIA ki = new KIA();
                                            ki.Name = name; ki.Id = id; ki.YearModel = model; ki.Color = color; ki.price = price;
                                            ki.Add_data();
                                            Console.WriteLine("\nDone\nYour data is stored\n");
                                            break;
                                    }
                                }
                                else if (ch!=1&&ch!=2&&ch!=3&&ch!=4&&ch!=5&&ch!=6)
                                {
                                    Console.WriteLine("\n* PLease select only 1 , 2 , 3 , 4 , 5 or 6 !\n");
                                }
                            } while (ch != 6);
                        }
                        else
                        { Console.WriteLine("\n---------------------------------\nWrong passward , Please try again\n---------------------------------\n"); }
                    }
                    else if (te == 2)
                    {
                        Console.WriteLine("--------------------------------\n 1- Show car from Marc\n--------------------------------\n 2- Show car from Lancer\n--------------------------------\n 3- Show car from Honda\n" +
                            "--------------------------------\n 4- Show car from BMW\n--------------------------------\n 5- Show car from KIA\n--------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter number of choice from Menu : ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (ch1)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Marc M = new Marc();
                                string[] arr = M.Show_data();
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    try
                                    {
                                        string[] mm = arr[i].Split(' ');
                                        Console.WriteLine("Id : " + mm[0] + " " + " , Name : " + mm[1] + " , Model year : " + mm[2] +
                                        " , Color : " + mm[3] + " , Price : " + mm[4]);
                                    }
                                    catch { }
                                }
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Lancer l = new Lancer();
                                string[] arr1 = l.Show_data();
                                for (int i = 0; i < arr1.Length; i++)
                                {
                                    try
                                    {
                                        string[] LL = arr1[i].Split(' ');
                                        Console.WriteLine("Id : " + LL[0] + " " + " , Name : " + LL[1] + " , Model year : " + LL[2] +
                                        " , Color : " + LL[3] + " , Price : " + LL[4]);
                                    }
                                    catch { }
                                }
                                break;
                            case 3:
                                honda H = new honda();
                                Console.ForegroundColor = ConsoleColor.Green;
                                string[] arr2 = H.Show_data();
                                for (int i = 0; i < arr2.Length; i++)
                                {
                                    try
                                    {
                                        string[] hh = arr2[i].Split(' ');
                                        Console.WriteLine("Id : " + hh[0] + " " + " , Name : " + hh[1] + " , Model year : " + hh[2] +
                                        " , Color : " + hh[3] + " , Price : " + hh[4]);
                                    }
                                    catch { }
                                }
                                break;
                            case 4:
                                BMW Bm = new BMW();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                string[] arr3 = Bm.Show_data();
                                for (int i = 0; i < arr3.Length; i++)
                                {
                                    try
                                    {
                                        string[] bM = arr3[i].Split(' ');
                                        Console.WriteLine("Id : " + bM[0] + " " + " , Name : " + bM[1] + " , Model year : " + bM[2] +
                                        " , Color : " + bM[3] + " , Price : " + bM[4]);
                                    }
                                    catch { }
                                }
                                break;
                            case 5:
                                KIA kI = new KIA();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                string[] arr4 = kI.Show_data();
                                for (int i = 0; i < arr4.Length; i++)
                                {
                                    try
                                    {
                                        string[] Ki = arr4[i].Split(' ');
                                        Console.WriteLine("Id : " + Ki[0] + " " + " , Name : " + Ki[1] + " , Model year : " + Ki[2] +
                                        " , Color : " + Ki[3] + " , Price : " + Ki[4]);
                                    }
                                    catch { }
                                }
                                break;
                            default:
                                Console.WriteLine("\n* Please Return to Menu and select only 1 , 2 , 3 , 4 , or 5 !");
                                break;
                        }
                    }
                    else if (te == 3)
                    {
                        Console.WriteLine("\n--------------------\n 1- Search of Marc\n--------------------\n 2- Search of Lancer\n--------------------\n 3- Search of Hondai\n" +
                            "--------------------\n 4- Search of BMW\n--------------------\n 5- Search of KIA\n--------------------\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Enter number of choice from Menu : ");
                        int ch2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (ch2)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("enter id of Marc : ");
                                int new_id = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Marc mm1 = new Marc();
                                string[] MM = mm1.Show_data();
                                for (int i = 0; i < MM.Length; i++)
                                {
                                    if (MM[i].StartsWith(new_id.ToString()))
                                    {
                                        Console.WriteLine(MM[i]);
                                    }
                                }
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("enter id of Lancer : ");
                                int new_id1 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Lancer LL1 = new Lancer();
                                string[] LL = LL1.Show_data();
                                for (int i = 0; i < LL.Length; i++)
                                {
                                    if (LL[i].StartsWith(new_id1.ToString()))
                                    {
                                        Console.WriteLine(LL[i]);
                                    }
                                }
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("enter id of Lancer : ");
                                int new_id2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                honda hh1 = new honda();
                                string[] hh = hh1.Show_data();
                                for (int i = 0; i < hh.Length; i++)
                                {
                                    if (hh[i].StartsWith(new_id2.ToString()))
                                    {
                                        Console.WriteLine(hh[i]);
                                    }
                                }
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("enter id of BMW : ");
                                int new_id3 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                BMW Bm = new BMW();
                                string[] bM = Bm.Show_data();
                                for (int i = 0; i < bM.Length; i++)
                                {
                                    if (bM[i].StartsWith(new_id3.ToString()))
                                    {
                                        Console.WriteLine(bM[i]);
                                    }
                                }
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("enter id of KIA : ");
                                int new_id4 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                KIA Ki = new KIA();
                                string[] kI = Ki.Show_data();
                                for (int i = 0; i < kI.Length; i++)
                                {
                                    if (kI[i].StartsWith(new_id4.ToString()))
                                    {
                                        Console.WriteLine(kI[i]);
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("\n* Please Return to Menu and select only 1 , 2 , 3 , 4 , or 5 !\n");
                                break;
                        }
                    }
                    else if (te == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" 1- Search of Marc\n 2- Search of Lancer\n 3- Search of Hondai\n 4- Search of BMW\n 5- Search of KIA\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("enter number of choice : ");
                        int ch3 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        switch (ch3)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter type of car : ");
                                string iD = Console.ReadLine();
                                Console.Clear();
                                Marc mm1 = new Marc();
                                string[] MM = mm1.Show_data();
                                for (int i = 0; i < MM.Length; i++)
                                {

                                    if (MM[i].Contains(iD))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(MM[i]);
                                    }
                                }
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter type of car : ");
                                string iD2 = Console.ReadLine();
                                Console.Clear();
                                Lancer LL1 = new Lancer();
                                string[] LL = LL1.Show_data();
                                for (int i = 0; i < LL.Length; i++)
                                {
                                    if (LL[i].Contains(iD2))
                                    {
                                        Console.WriteLine(LL[i]);
                                    }
                                }
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter type of car : ");
                                string iD3 = Console.ReadLine();
                                Console.Clear();
                                honda hh1 = new honda();
                                string[] hH = hh1.Show_data();
                                for (int i = 0; i < hH.Length; i++)
                                {
                                    if (hH[i].Contains(iD3))
                                    {
                                        Console.WriteLine(hH[i]);
                                    }
                                }
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter type of car : ");
                                string iD4 = Console.ReadLine();
                                Console.Clear();
                                BMW bM = new BMW();
                                string[] Bm = bM.Show_data();
                                for (int i = 0; i < Bm.Length; i++)
                                {
                                    if (Bm[i].Contains(iD4))
                                    {
                                        Console.WriteLine(Bm[i]);
                                    }
                                }
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("Enter type of car : ");
                                string iD5 = Console.ReadLine();
                                Console.Clear();
                                KIA Ki = new KIA();
                                string[] kI = Ki.Show_data();
                                for (int i = 0; i < kI.Length; i++)
                                {
                                    if (kI[i].Contains(iD5))
                                    {
                                        Console.WriteLine(kI[i]);
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("\n* Please Return to Menu and select only 1 , 2 , 3 , 4 , or 5 !");
                                break;
                        }
                    }
                    else { Console.WriteLine("\n* Please Return to Menu and select only 1 , 2 , 3 or 4 !"); }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Do you want to return to menu ?  ");
                        c = Console.ReadLine();
                        Console.WriteLine();
                    
                } while (c == "y" || c == "yes");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}\n");
                }
            }
        }
}

