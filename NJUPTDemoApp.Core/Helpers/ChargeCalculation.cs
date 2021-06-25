using System;
using System.Collections.Generic;
using System.Text;

namespace NJUPTDemoApp.Core.Helpers
{
    public class ChargeCalculation
    {
        public static double ChargeCalculate(int time, bool isLocal, double ratio)
        {
            double localCharge, longDistanceCharge;
            int minutes = (int)Math.Ceiling((double)time / 60);
            if (isLocal)
            {
                longDistanceCharge = 0;
            }
            else
            {
                longDistanceCharge = ratio * minutes;
            }
            if (minutes <= 3)
            {
                localCharge = 0.5;
            }
            else
            {
                localCharge = 0.5 + 0.2 * (minutes - 3);
            }
            return localCharge + longDistanceCharge;
        }
    }
}
