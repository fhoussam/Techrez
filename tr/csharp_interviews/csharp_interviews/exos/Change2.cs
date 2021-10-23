﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace csharp_interviews.exos
{
    using System;

    // Do not modify Change
    class ChangeOld
    {
        public long coin2 = 0;
        public long bill5 = 0;
        public long bill10 = 0;

        public static ChangeOld OptimalChange(long s)
        {
            List<ChangeOld> changes = new List<ChangeOld>();
            changes.Add(GetChange(s));
            changes.Add(GetChange(s, 10));
            changes.Add(GetChange(s, 5));
            changes.Add(GetChange(s, 2));
            return changes.Where(x => x.coin2 * 2 + x.bill5 * 5 + x.bill10 * 10 == s).OrderBy(x => x.coin2 + x.bill5 + x.bill10).FirstOrDefault();
        }

        public static ChangeOld GetChange(long s, int? d = null)
        {
            if (d.HasValue)
            {
                ChangeOld c = new ChangeOld();
                c.coin2 = long.Parse((s / d).ToString().Split('.')[0]);
                return c;
            }
            else 
            {
                ChangeOld c = new ChangeOld();
                c.bill10 = long.Parse((s / 10).ToString().Split('.')[0]);
                c.bill5 = long.Parse(((s - c.bill10 * 10) / 5).ToString().Split('.')[0]);
                c.coin2 = (int)(s - (c.bill10 * 10 + c.bill5 * 5)) / 2;
                return c;
            }
        }

        public static void MainMethod()
        {
            long s = 6; // Change this value to perform other tests
            ChangeOld m = ChangeOld.OptimalChange(s);

            Console.WriteLine("Coin(s)  2€: " + m.coin2);
            Console.WriteLine("Bill(s)  5€: " + m.bill5);
            Console.WriteLine("Bill(s) 10€: " + m.bill10);

            long result = m.coin2 * 2 + m.bill5 * 5 + m.bill10 * 10;
            Console.WriteLine("\nChange given = " + result);
        }
    }
}
