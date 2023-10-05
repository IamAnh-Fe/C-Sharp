using System;

namespace Lesson2 {
class Lesson1 {

  public static void Main() {
  int n;
      Console.WriteLine("Nhap gia tri n:");
      n = int.Parse(Console.ReadLine());
      int s = 0;
      int i = 1;
      while(i <= n){
        s += i * i;
        i++;
      }    
        Console.WriteLine(s);
        // S(n) = 1^2 + 2^2 + … + n^2
  }
}
}