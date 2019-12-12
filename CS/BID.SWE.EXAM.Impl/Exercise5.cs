using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using BID.SWE1.Exam.Interfaces;


namespace BID.SWE.EXAM.Impl
{
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {

            var client = new TcpClient();
            client.Connect(str, i);

            var stream = client.GetStream();
            var reader = new StreamReader(stream);

            List<string> results = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                results.Add(line);
            }

            return results;
        }
    }
}