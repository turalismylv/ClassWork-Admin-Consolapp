using System;
using System.Collections.Generic;
using System.Threading;


namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<User> users = new List<User>();

            while (true)
            {
                Console.WriteLine("1.Register 2.Login");
                string n = Console.ReadLine();
                bool isInt = int.TryParse(n, out int menu);
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Username daxil edin");
                        string username = Console.ReadLine();
                        foreach (var item in users)
                        {
                            if (username==item.Username)
                            {
                                Console.WriteLine("Bu adli username daxil olunub,zehmet olmasa yeniden daxil edin");
                                goto case 1;
                            }
                        }
                        Console.WriteLine("Parol daxil edin");
                        string parol = Console.ReadLine();
                        Console.WriteLine("Firstname daxil edin");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Lastname daxil edin");
                        string lastname = Console.ReadLine();
                        User user = new User(username, parol, firstname, lastname);
                        Console.WriteLine($"Tebrikler {username} adli istifadeci qeydiyyatdan kecdi");
                        users.Add(user);
                        break;
                    case 2:
                        Console.WriteLine("Username daxil edin");
                        string username1 = Console.ReadLine();
                        Console.WriteLine("Parol daxil edin");
                        string parol1 = Console.ReadLine();
                        foreach (var item in users)
                        {
                            if (item.Username==username1 && item.Parol==parol1)
                            {
                                Print("Xosgeldiniz");
                            }
                            else
                            {
                                Console.WriteLine("Username ve yaxud parol sehvdi");
                                goto case 2;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

        }
        public static void Print(object obj)
        {
            string text = obj as string;
            foreach (var item in text)
            {
                Console.Write(item);
                Thread.Sleep(100);
            }
        }
    }
}
