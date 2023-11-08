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
    internal interface Figure 
    {
        public double IAreaFigure(double a, double b);
    }
}
