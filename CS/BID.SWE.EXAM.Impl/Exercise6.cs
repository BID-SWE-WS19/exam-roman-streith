using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {

            int i = 1;
            int day = 12;
            int month = 12;
            int year = 2019;
            int hour = 16;
            int minut = 50;
            string name = "Roman Streith";

            SqlCommand cmd = new SqlCommand("INSERT into TestAbgabe (Id, Tag, Monat, Jahr, Stunde, Minute, Name) VALUES(@i, @day, @month , @year, @hour, @minute, @name )");
            cmd.CommandType = CommandType.Text;
           
            cmd.Parameters.AddWithValue("@i", i);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@minute", minut);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            
            return cmd; 
        }
        
    }
}