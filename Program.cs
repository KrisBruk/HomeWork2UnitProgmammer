﻿// проверка кратности на 7 и 23

//using System;

//class Program
//{



//static void Main()
//{
//Console.Write("Введите число a: ");
//int a = Convert.ToInt32(Console.ReadLine());

//if (a % 7 == 0 && a % 23 == 0)

//{ Console.WriteLine("да"); }
//else
//{
//Console.WriteLine("нет");
//}
//}
//}


//Задача 2. Определение четверти заданной координаты
//using System;

  //class Program 
//{
  //    static void Main()
    //   {
      //    Console.Write("Введите координаты точки X и Y через пробел: "); 
        //  
          //string[] coordinates = Console.ReadLine().Split(' ');
          
          //int x = Convert.ToInt32(coordinates[0]);
          //int y = Convert.ToInt32(coordinates[1]);


          //if (x > 0 && y > 0) 
            // Console.WriteLine("1");
            //else if (x < 0 && y > 0) 
              // Console.WriteLine("2");
            //else if (x < 0 && y < 0) 
              // Console.WriteLine("3");
            //else if (x > 0 && y < 0)
              //  Console.WriteLine("4");
           //else
             //Console.WriteLine("Точка на оси координат");
       //}
//}

// Задача 3. Показать наибольшую цифру числа


   
using System;
    class Program {
       static void Main() {
              Console.Write("Введите число от [10, 99]: "); 
              
              int number = Convert.ToInt32(Console.ReadLine());
               
                int first  = number / 10;
                int second = number % 10;
                int max = first> second ? first : second;
              
              Console.WriteLine(max);
               }
}
