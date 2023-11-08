//Створіть набір методів:
//■ Метод відображення поточного часу;
//■ Метод відображення поточної дати;
//■ Метод відображення поточного дня тижня;
//■ Метод для підрахунку площі трикутника;
//■ Метод для підрахунку площі прямокутника.
//Для реалізації проєкту використовуйте делегати: Action, Predicate, Func.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_8_2
{
    internal class MyTime
    {
        public void CurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Поточний час: {currentTime.ToLongTimeString()}");
        }
        public void CurrentDate()
        {
            DateTime currentDate = DateTime.Today;
            Console.WriteLine($"Поточна дата: {currentDate.ToLongDateString()}");
        }
        public void CurrentDayWeek()
        {
            DateTime currentDayWeek = DateTime.Now;
            Console.WriteLine($"Поточний день тижня: {currentDayWeek.DayOfWeek.ToString()}");
        }
    }
}
