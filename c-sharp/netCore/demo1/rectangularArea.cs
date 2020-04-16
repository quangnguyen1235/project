using System;
using System.Collections.Generic;
using System.Text;

namespace chuong1
{
    class rectangularArea
    {
        public static void Main(string[] args)
        {         
            Console.WriteLine("DIEN TICH HINH CHU NHAT !");
            Console.Write("Nhap chieu dai: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int area = (width * length);
            Console.WriteLine("Dien tich hinh chu nhat co chieu dai {0} chieu rong {1} la: {2}", (length), (width), (area));

        }
    }
}
