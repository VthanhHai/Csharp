using  System.Text;
using System.Threading.Tasks;
namespace Hang
{
    class Program
    {
        static void Main(string[]args)
        {
            /*
            - Hằng là một biến những giá trị không thay đổi trong suốt chương trình.
            - Bắt buộc phải khởi tạo giá trị khi khai báo
            - để ngăn chặn việc gán giá trị khác vào.
            - Hằng làm cho chương trình dễ nâng cấp, dễ sửa hơn.
            - chia làm ba loại hằng giá trị, biểu tượng và kiểu liệt kê.
            */
            const int a = 10;
            
            const int x = a; // thêm const, x là giá trị hằng 
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}