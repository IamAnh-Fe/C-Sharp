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
        s += 1 / i;
        i++;
      }    
        Console.WriteLine(s);
        // S(n) = 1 + ½ + 1/3 + … + 1/n
}
  }
}
