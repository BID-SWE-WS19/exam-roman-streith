using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            Cell cell1 = new Cell1();
            return cell1;
        }

        public int Method2()
        {
            Cell cell2 = new Cell2();
            return cell2.Grow();
        }

        public bool Method3(int o1)
        {
            Cell cell3 = new Cell2();
            return cell3.IsAlive();
        }


        class Cell1 : Cell {

        }

        class Cell2 : Cell {
            public override int Grow() {
                this._size *= 2;
                return _size;
            }
        }

        class Cell3 : Cell {

            public bool IsAlive(int neighbours) {
                if (neighbours % 2 == 0) {
                    return true;
                }
                return false;
            }
        }
    }
}