/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами. 
Примеры: 
["hello", "2", "world", ":-)"] > "2", ":-)"] 
["1234", "1567", "-2", "сотаршет зс1епсе"] -> ["-2"] 
["Визза", "Рептагк", "Кагап"] -> []
*/

int GitNumer(string messege)
{int number = 0;
  while (true)
  {
    Console.WriteLine(messege+" ");
    if (int.TryParse(Console.ReadLine() ?? "",out number))
    break;
    else Console.WriteLine("Введено не корректное число ");

  } 
    return number;

}

string []InitArr()
{
      // Ввод строк с клавиатуры
      // и образование нового массива

      // 1. Объявление переменных
      string[] arr; // ссылка на массив строк
      int count; // текущее количество строк в массиве
      string s;
      string[] arr2; // дополнительная переменная-ссылка - сохраняет старый массив строк

      // 2. Цикл ввода строк
      

      count = 0; // обнулить количество строк
      arr = new string[count]; // выделить память для 0 строк

      do
      {
        // Ввести строку
        Console.WriteLine($"Введите {count+1}элемент массива (окончание ввода - введение пустой строки ''):");
        s = Console.ReadLine();

        // Проверка, пустая ли строка
        if (s!="")
        {
          // если строка не пустая, то добавить строку в массив
          count++;

          // предварительно выделить память для нового массива
          // в котором на 1 элемент больше
          arr2 = new string[count];

          // скопировать старый массив в новый
          for (int i = 0; i < arr2.Length - 1; i++)
            arr2[i] = arr[i];

          // добавить последнюю введенную строку в массив AS2
          arr2[count - 1] = s;

          

          // перенаправить ссылку AS на AS2
          arr = arr2;
        }
      } while (s != "");

      
      return arr;
    }
/*{ string []array = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива. ");
        array[i] = Console.ReadLine();

    }

    return arr;
}
*/
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"'{arr[i]}', ");
    }
}

string []SortArr(string []arr)
{ string []array = new string[arr.Length];
  int index =  0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива. ");
        array[i] = Console.ReadLine();

    }

    return arr;
}

