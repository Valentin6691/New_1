Console.WriteLine("Ведите ваше число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите ваше число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber < secondNumber)
      {
        Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber + "`");
      }
      else if(firstNumber > secondNumber)
      {
        Console.WriteLine("Первое число `" + firstNumber + "` больше чем второе число `" + secondNumber + "`");
      }
        else if(firstNumber == secondNumber)
      {
        Console.WriteLine("Введенные числа равны `" + secondNumber + "`");
      }