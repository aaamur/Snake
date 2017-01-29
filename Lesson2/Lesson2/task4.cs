/*
 * Ивашкевич Артём
 * 4.	Реализовать метод проверки логина и пароля. 
 * На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел.
 *  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 *  С помощью цикла do while ограничить ввод пароля тремя попытками;
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class task4
    {
        int tryCount;

        Dictionary<string, string> dict;

        public task4()
        {
            this.tryCount = 0;
            this.dict = new Dictionary<string, string>();
            this.dict.Add("abdulova", "One");
            this.dict.Add("lukov", "Tw.o");
            this.dict.Add("gogi", "Three!");
        }

        public void imitateUserAction()
        {
            string login;
            string password;

            while (this.tryCount < 3) 
            {
                Console.WriteLine("Введите логин:");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();

                this.login(login,password);            
            }
            
        }
        
        public bool login(string login, string password)
        {
            if (this.tryCount > 2)
            {
                Console.WriteLine("Превышен лимит попыток");
                return false;
            }

            foreach (KeyValuePair<string, string> kvp in this.dict)
            {
                if (kvp.Key == login && kvp.Value == password)
                {
                    return true;
                }
            }

            tryCount++;
            Console.WriteLine("Неверный пароль");
            return false;
        }

    }
}
