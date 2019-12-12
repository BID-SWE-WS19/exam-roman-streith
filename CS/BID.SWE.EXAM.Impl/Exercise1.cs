using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise1 : IExercise1
    {
        public object Method1()
        {
            ICellPrinter printer = new Printer();
            return printer;
        }

    }
    public class Printer : ICellPrinter {
        public string PrintState(bool alive, DateTime date, string color) {
            if (alive) {
                return "Cell " + color + " born on " + date + " is alive";
            }
            return "Cell " + color + " born on " + date + " is not alive";
        }

        public string PrintPostion(int x, int y) {
            return "Cell is on Position X:" + x + " Y:" + y;
        }
    }
}
