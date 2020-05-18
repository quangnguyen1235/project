using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementJson.Common
{
        struct Rank
        {
            public const double XuatSac = 9.0;
            public const double Gioi = 8.0;
            public const double Kha = 7.5;
            public const double TBK = 6.5;
            public const double TB = 5;
            public const double Yeu = 3.5;
        public override string ToString()
        {
            return base.ToString(); 
        }
        public static string ToString(double? rank = 3.4)
        {
            switch (rank)
            {
                case XuatSac:
                    {
                        return "Xuat Sac";
                    }
                case Gioi:
                    {
                        return "Xuat Sac";
                    }
                case TBK:
                    {
                        return "Xuat Sac";
                    }
                case TB:
                    {
                        return "Xuat Sac";
                    }
                case Yeu:
                    {
                        return "Xuat Sac";
                    }
                default:
                    {
                        return "Kem";
                    }
            }
        }
    }
         
}
