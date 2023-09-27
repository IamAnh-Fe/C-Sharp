using System;

namespace Lesson3 {
public class Lesson3 {

  public static void Main() {
  int n;
  int x;
      Console.WriteLine("Nhap gia tri n:");
      n = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap gia tri x:");
      x = int.Parse(Console.ReadLine());

      int s = x * n;
        
        Console.WriteLine(s);
      //  T(x, n) = x^n
}
  }
}

