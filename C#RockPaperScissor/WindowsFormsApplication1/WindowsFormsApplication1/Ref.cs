using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum Result{
        Playerwin,
        Computerwin,
        truce
    }
    class Ref
    {
        public static Result Judge(int playerNumber, int cpuNumber)
        {
            if (playerNumber - cpuNumber == -1 || playerNumber - cpuNumber == 2)
            {
                return Result.Playerwin;
            }
            else if (playerNumber - cpuNumber == 0)
            {
                return Result.truce;
            }
            else {
                return Result.Computerwin;
            }
        }
    }
}
