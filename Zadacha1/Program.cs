 Console.WriteLine("Введите пятизначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int originalNumber = number;
 int reverseNumber = 0;
  if (number < 10000 || number >= 100000)
  {
      Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз");
      return;
  }
 while (number > 0)
 {
     int lastDigit = number % 10;
     reverseNumber = reverseNumber * 10 + lastDigit;
     number /=10;
 }
 if ( originalNumber == reverseNumber)
 {
     Console.WriteLine (originalNumber + " - является полиндромом  " );
 }
 else
 {
     Console.WriteLine (originalNumber +  " - не является полиндромом  " );
 }

