using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseToyToyToy
{
    interface ISpeed
    {
        int IncSpeed();
        int DecSpeed();
        int GetCurrentSpeed();
        int ChangeSpeed(int change);
    }

    interface IAltitute
    {
        int IncAltitute();
        int DecAltitute();
        int GetCurrentAltitute();
        int ChangeAltitute(int change);
    }

    interface IDepth
    {
        int IncDepth();
        int DecDepth();
        int GetCurrentDepth();
        int ChangeDepth(int change);
    }
}
