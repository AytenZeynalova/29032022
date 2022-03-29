using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022
{
    class User
    {
       

        public User(string username)
        {
            this.UserName = username;
          
        }
        public string UserName;
        private string _passWord;
        public string PassWord
        {
            get
            {
                return _passWord;
            }

            set
            {
                if (HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    _passWord = value;
                }
                else
                {
                    Console.WriteLine("password daxil ederken reqemden, boyuk ve balaca herflerden istifade edin:");
                }
            }
        }


        //  - HasDigit - parametr olaraq string dəyər qəbul edib o dəyərdə rəqəm varsa geriyə true yoxdusa false qaytaran metod
        // - HasUpper -  parametr olaraq string dəyər qəbul edib o dəyərdə uppercase varsa geriyə true yoxdursa false qaytaran metod
        // - HasLower - parametr olaraq string dəyər qəbul edib o dəyərdə lowercase varsa geriyə true yoxdursa false qaytaran metod
        
        public bool HasDigit(string exm)
        {
            for (int i = 0; i < exm.Length; i++)
            {
                if (char.IsDigit(exm[i]))
                {
                    return true;
                }
            }
            return false;

        }

        public bool HasUpper(string exm)
        {
            for (int i = 0; i < exm.Length; i++)
            {
                if (char.IsUpper(exm[i]))
                {
                    return true;
                }
            }
            return false;

        }

        public bool HasLower(string exm)
        {
            for (int i = 0; i < exm.Length; i++)
            {
                if (char.IsLower(exm[i]))
                {
                    return true;
                }
            }
            return false;

        }


    }
}
