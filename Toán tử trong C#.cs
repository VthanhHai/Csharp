using System;
class HelloWorld {
  static void Main() {
  //   Console.WriteLine("***Toán Tử Trong C#***");
  // int H,K,T;
  // H=K=T=10;
  // Console.WriteLine("H = {0},K={1},T={2}",H,K,T);
  // H+=K=T=5;
  // Console.WriteLine("H = {0},K={1},T={2}",H,K,T);
  // Console.ReadKey();
   
   int a,b,c; 
   a=b=(c=9) + 1;// khởi tạo giá trị a=10,b=10,c=9;
   a+=b; // a = a+b;
   b = c++;//gán giá trị cho c cho b => c = c+1;
    --c;//thực hiện c = c-1;
   Console.WriteLine("a={0},b={1},c={2}",a,b,c);
   Console.ReadKey();
  }
}