using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharpLib;
public static class CarsAssemble
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        if (speed <= 4)
            return 1;
        if (speed <= 8)
            return 0.9;
        if (speed == 9)
            return 0.8;

        return 0.77;
    }

    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(speed * 221.0 / 60.0 * SuccessRate(speed));
    }
}
