//Створіть набір методів:
//■ Метод відображення поточного часу;
//■ Метод відображення поточної дати;
//■ Метод відображення поточного дня тижня;
//■ Метод для підрахунку площі трикутника;
//■ Метод для підрахунку площі прямокутника.
//Для реалізації проєкту використовуйте делегати: Action, Predicate, Func.

using NET_Homework_8_2;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

MyTime myTime = new MyTime();
Action MyAction = () => myTime.CurrentTime();
MyAction += () => myTime.CurrentDate();
MyAction += () => myTime.CurrentDayWeek();

MyAction.Invoke();

Triangle triangle = new Triangle();
Rectangle rectangle = new Rectangle();
Func<double, double, double> MyFunc =(x, y) => triangle.IAreaFigure(x, y);
MyFunc += (x, y) => rectangle.IAreaFigure(x, y);

Predicate<Func<double, double, double>> MyPredicate = (x) => x != null;
bool Result = MyPredicate(MyFunc);
if (Result == true)
{
    MyFunc.Invoke(3, 9);
}
else
{
    Console.WriteLine("Неможливо визначити площу фігури!");
}
