using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            Stream stream = new MemoryStream();
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.Write("Frohe Weihnachten");
                writer.Write(42);
                writer.Write(false);
            }
            return stream;
        }

        public object Method2(object obj)
        {
            BinaryReader reader = new BinaryReader((Stream)obj);
            reader.ReadInt32();
            reader.ReadBoolean();
            return reader.ReadString();
        }
    }
}