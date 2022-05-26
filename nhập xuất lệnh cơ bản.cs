using System;
  class nhap_xuat_co_ban
{
  static void Main (string[] args)
  {
    Console.WriteLine ("Hello World");
    Console.Write("Họ và Tên;");
    Console.WriteLine("nhập: " + Console.ReadLine());
    // Quy tắc chung là chạy lệnh bên trong trc rồi đến lệnh bên ngoài chứa nó.
    // Do đó chạy đến đây chương trình sẽ thực hiện Console.ReadLine().
    // Sau đó thực hiện lệnh cộng chuỗi và cuối cùng in chuỗi ra màn hình.
    Console.Write("ngày sinh;");
    Console.WriteLine("nhập:" + Console.ReadLine());
    Console.Write("Địa chỉ;");
    Console.ReadLine("nhập: " + Console.ReadLine());
    Console.ReadKey(); 
  }
}