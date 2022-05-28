using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Kiểu dữ liệu trong C");
    /* kiểu dữ liệu là tập hợp các nhóm dữ liệu có cùng đặc tính
      - cách lưu trữ và thao tác trên trường dữ liệu đó.
      - là một tín hiệu để trình biên dịch nhận biết kích thướng của một biến và khả năng của nó 
      - là thành phần cốt lỗi của một ngôn ngữ lập trình.
      - có  2 kiểu dữ liệu.
      - dựng sẵn || kiểu dữ liệu giá trị.
      - và tự định nghĩa.  || kiểu dữ liệu tham chiếu.*/
    // #region
    // // ***KIỂU SỐ NGUYÊN***;
    // byte bienByte = 10; // Có miền giá trị -128 -> 127;
    // short bienShort = 10;
    // int BienInt = 10;
    // long BienLong = 10;
    // // ***KIỂU SỐ THỰC***.
    // float BienFloat = 10.6f; // giá trị biên của float phải có hậu tố f or F.
    // double BienDouble = 10.6; // giá trị biến double ko có hậu tố.
    // decimal bienDecimal = 10.6m; // giá trị biến decimal phải có hậu tô m.
    // // ***KIỂU KÝ TỰ VÀ CHUỖI KỸ TỰ***.
    // char BienChar = 'k'; // kiểu ký tự để trong nháy {'...'}.
    // string BieenString = "Vũ Thanh Hải"; // kiểu chuỗi để trong nháy {"..."}.
    // Console.ReadKey();
    // #endregion
    
    Console.WriteLine("Ví dụ 2: ");
    byte BienByte = 3;
    short bienShort = 9;
    int BienInt = 10;
    long BienLong = 0;
    BienLong = BienByte; //BienLong có kiểu dữ liệu > BienByte nên giá trị BienByte có thể gán qua BienLong
    Console.WriteLine("BienLong = "+ BienLong);
    
    BienLong = BienInt;
    Console.WriteLine("BienLong = " + BienLong);
    
    bienShort = BienByte; // bienShort có kiểu dữ liệu > BienByte nến giá trị BienByte có thể gán qua bienShort
    Console.WriteLine("bienShort = "+ bienShort);
    
    BienInt = bienShort;
    Console.WriteLine("BienInt = "+ BienInt);
    Console.ReadKey();
  }
}