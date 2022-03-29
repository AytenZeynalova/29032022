using System;

namespace _29032022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("username daxil edin:");
            string userName = Console.ReadLine();

            User user = new User(userName);
            while (userName.Length < 6 || userName.Length > 25)
            {
                Console.WriteLine("username-in uzunlugu [6-25] olmalidir.yeniden daxil edin:");
                userName = Console.ReadLine();

            }
            string password;
            Console.WriteLine("password daxil edin:");
            password = Console.ReadLine();
            user.PassWord = password;
            while (password.Length < 8 || password.Length> 25)
            {
                Console.WriteLine("passwordun uzunlugu [8-25] olmalidir. yeniden daxil edin:");
                password = Console.ReadLine();
            }

            Console.WriteLine($"username:{userName} --- password:{password}");













            #region qaralama
                //for (int i = 0; i < Username.Length; i++)
                //{
                //    if (Username.Length >= 6 && Username.Length <= 25)
                //    {
                //        Console.WriteLine($"istifadeci adiniz:{Username}");
                //    }
                //    else 
                //    {
                //        Console.WriteLine("istifadeci adinin uzunlugu minimum 6 maksimum 25 olmalidir!");
                //        Console.ReadLine();
                //    }
                //}


                //Console.WriteLine("password daxil edin");
                //string password = Console.ReadLine();
                //for (int i = 0; i < password.Length; i++)
                //{
                //    if (password.Length >= 8 && password.Length <= 25)
                //    {
                //        for (int j = 0; j < password.Length; j++)
                //        {
                //            char c = password[i];
                //            if (char.IsDigit(c) && char.IsUpper(c) && char.IsLower(c))
                //            {
                //                Console.WriteLine("vardir");
                //            }
                //            else
                //            {
                //                Console.WriteLine("yoxdur");
                //            }

                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("yeniden password daxil edin:");
                //        Console.ReadLine();
                //    }

                //}
                #endregion


        }
    }
}
