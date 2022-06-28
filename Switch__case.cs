using System.Diagnostics;
using System.Reflection.Metadata;
using  System.Text;
using System.Threading.Tasks;
namespace ep_kieu_trong_Cshrap
{
    class Program
    {
        static void Main(string[]args)
        {   
            

            int a;
            Console.Write("a = ");
            a = Int32.Parse(Console.ReadLine()); //Int32.Parse ép kiểu a ký tự về kiểu số nguyên
            
            switch (a)
            {
                case 10: 
                Console.Write("thanh");
                break;
                //trong switch--case chỉ có một default.
                default:

                 Console.Write ("Hải");
                 
                    break;
                 
            }

        }
    }
}