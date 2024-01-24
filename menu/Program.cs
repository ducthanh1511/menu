using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luaChon;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Quan ly cua hang dien thoai ");
                Console.WriteLine("------------------------");
                Console.WriteLine("Moi ban chon tu 1 - 4");
                Console.WriteLine("1. Them dien thoai");
                Console.WriteLine("2. Them dien thoai chi tiet");
                Console.WriteLine("3. Tim dien thoai");
                Console.WriteLine("4. Dang/Ngung kinh doanh");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("------------------------");

                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("1. Them dien thoai");
                        break;
                    case 2:
                        Console.WriteLine("2.Them dien thoai chi tiet");
                        break;
                    case 3:
                        Console.WriteLine("3. Tim dien thoai");
                        break;
                    case 4:
                        Console.WriteLine("4. Dang/Ngung kinh doanh");
                        break;
                    case 5:
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Moi ban nhap lai");
                        break;
                }

            } while (luaChon != 5);




            Console.ReadLine();
        }
    }
}
