using System;
using System.Collections.Generic;
using BID.SWE1.Exam.Impl;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            Map map1  = new Map1();
            return map1;
        }

        public object Method2()
        {
            Bewegung jump = new Springen();
            Bewegung run = new Laufen();

            return new List<Bewegung>
            {
                jump,
                run
            };
        }
    }

    public class Map1 : Map {
        public override string GetMapName() {
            return "BID-Map";
        }

        public override float GetMapSize(float amount) {
            return amount * amount;
        }

        public override int AddNewCells(int year) {
            return year;
        }
    }

    public abstract class Bewegung {
        public virtual string Position() {
            return "Position";
        }

        public virtual string Move() {
            return "Move";
        }
    }

    public class Laufen : Bewegung {
        public override string Position() {
            return "Ground";
        }

        public override string Move() {
            return "Right";
        }
    }
    public class Springen : Bewegung {
        public override string Position() {
            return "Air";
        }

        public override string Move() {
            return "Up";
        }
    }
}