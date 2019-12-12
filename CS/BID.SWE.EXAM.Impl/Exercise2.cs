using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            Cell cell1 = new MyCell();
            return cell1;
        }

        public int Method2()
        {
            Cell cell2 = new MyCell();
            return cell2.Grow();
        }

        public bool Method3(int o1)
        {
            Cell cell3 = new MyCell();
            return cell3.IsAlive();
        }
    }


    public class MyCell : Cell {
        public override int Grow() {
            this._size *= 2;
            return _size;
        }
        public bool IsAlive(int neighbours) {
            if (neighbours % 2 == 0) {
                return true;
            }
            return false;
        }
    }

}