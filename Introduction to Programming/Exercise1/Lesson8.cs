using System;

namespace Lesson3 {
public class Lesson3 {

  public static void Main() {
  int n;
      Console.WriteLine("Nhap gia tri n:");
      n = int.Parse(Console.ReadLine());
      int s = 0;
      int i = 0;
      while(i <= n){
        s += (2 * i) + 1 / (2 * i) + 2;
        i++;
      }    
        Console.WriteLine(s);
      //  S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2
}
}
}
