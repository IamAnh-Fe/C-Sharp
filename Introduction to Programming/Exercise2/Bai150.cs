using System;

namespace Exersice
{
  class Program
  {
   public int check (float[] arr, int n){
    for(int i = 0; i < n; i++){
      if(arr[i] < 0) {
        return i;
      }
    }
    return -1;
   }
    public float Solve(float[] arr, int n ){
      	
			for (int i = n - 1; i >= 0; i--) {
				if (check(arr[i]) == true) {
          return arr[i];

				}
        return -1;
			}

    }
    static void Main(string[] args)
    {
		Program obj = new Program();
    int n = int.Parse(Console.ReadLine());
			float[] arr = new float[n];

			for (int i = 0; i < n; i++) {
				arr[i] = int.Parse(Console.ReadLine());
			}
      int check = check(arr, n);
      if(check == -1){
              			Console.WriteLine(num); 

      }
      float num = obj.minValue(arr, n);
      			Console.WriteLine(num); 

      //Hãy tìm giá trị âm lớn nhất trong mảng 1 chiều các số thực.
      // Nếu mảng không có giá trị dương thì trả về -1
      
    }
  }
}