using System;
  class Bien_Csharp
{
  static void Main (string[] args)
  {
   // Biến có thể thay đổi.
   /* biến:
      - là một giá trị có thể thay đổi được.
      - là tên gọi tham chiếu đến 1 vùng nhớ của bộ nhớ
      - là thành phần cốt lỗi của một ngôn ngữ lập trình.
      - có thể lưu trữ và tái sử dụng.
      - thao tác với bộ nhớ dẽ dàng.
      <kiểu dữ liệu>< tên biến>
      =============///============
      *Quy tắc đặt tên biến;
      - tên biến là chuỗi ký tự liên kết (không có khoảng trắng) và không chứ ký tự đặc biệt.
      - không được có dấu và không được bắt đầu bằng số.
      - Và không được trùng nhau và không được trùng với từ khóa.
      =============///=============
    
    */
    int SoNguyen = 5;
    float SoThuc = 5.5f;
    string KieuChuoi = "Vũ Thanh Hải";
    bool luanlydungsai = true;
    char KyTu = 'K';
    Console.WriteLine(SoNguyen);
    int a = 6,b = 9,c = a+b;
    
    Console.Write("a + b = c:\n{0} + {1} = {2} ",a,b,c);
    
    
    Console.ReadKey();
   
    
  }
}