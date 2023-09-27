using System;

namespace Lesson3 {
public class Lesson3 {

  public static void Main() {
  int n;
      Console.WriteLine("Nhap gia tri n:");
      n = int.Parse(Console.ReadLine());
      int s = 0;
      int i = 1;
      while(i <= n){
        s += i / i + 1;
        i++;
      }    
        Console.WriteLine(s);
      //  Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1
}
  }
}
