using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chuong1.Models
{
    public class TL_GaiPT_B1
    {
        public double HeSoA { get; set; }
        public double HeSoB { get; set; }
        public TL_GaiPT_B1()
        {
        }
        public TL_GaiPT_B1(double a, double b)
        {
            HeSoA = a;
            HeSoB = b;
        }
        public string GiaiPTBac1()
        {
            if (HeSoA == 0)
            {
                if (HeSoB == 0)
                {
                    return "Phương trình vô số nghiệm.";
                }
                else
                {
                    return "Phương trình vô nghiệm.";
                }
            }
            else
            {
                double nghiem = -HeSoB / HeSoA;
                return "Phương trình có nghiệm x = " + nghiem;
            }
        }
    }
}