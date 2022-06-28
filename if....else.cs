using System.Reflection.Metadata;
using  System.Text;
using System.Threading.Tasks;
namespace ep_kieu_trong_Cshrap
{
    class Program
    {
        static void Main(string[]args)
        {
            string strA ,strB;
            int A,B;
            double nghiem;
           Console.Write("A = ");
           strA = Console.ReadLine();
           Console.Write("B = ");
           strB = Console.ReadLine();
           if(int.TryParse(strA,out A) == false || int.TryParse(strB , out B) == false ){//int.Tryparse là ép kiểu từ kiểu chuỗi về kiểu int.
            Console.WriteLine(" không đúng");
           }
           else
           {
            Console.WriteLine("phương trình của bạn là {0}x+{1}=0",A,B);
                if(A == 0){

                    Console.WriteLine("phương trình vô nghiêm");
                }

                else

                if(B == 0)
                {
                    Console.WriteLine("phương trình có nghiệm = 0");                    
                }
                else
                {
                    nghiem = (double)B/A;
                    Console.WriteLine("phường trình có nghiêm x = {0}",nghiem);
                }
           }
        }
    }
}