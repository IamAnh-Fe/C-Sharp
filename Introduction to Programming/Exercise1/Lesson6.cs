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
        s += 1 / i * (i + 1);
        i++;
      }    
        Console.WriteLine(s);
        // S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)
}
  }
}
