// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Data;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Data Source=DESKTOP-MA7TJ0N;Initial Catalog=DevSkillTest;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=3p3200170";

    // Main Method
    static public void Main(String[] args)	{
        while (true)
        {
            Console.Write("Please Enter Title:");
            string title = Console.ReadLine();
            Console.Write("Please Enter Fees:");
            double fees = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Class Start Date:");
            DateTime classStartDate = Convert.ToDateTime(Console.ReadLine());
            int isCreate = SaveCourse(title, fees, classStartDate);
            if (isCreate > 0)
                Console.Write("Course Successfully Created!\n\n\n");
            else
                Console.Write("Course Create Failed!");
        }
		
        //Console.ReadKey();
    }

    

    public static int SaveCourse(string title,double fees,DateTime classStartDate)
    {
        int isCreate = 0;
       SqlCommand cmd = new SqlCommand();
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            cmd = new SqlCommand("INSERT INTO Courses VALUES(@title,@fees,@classStartDate)", con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@fees", fees);
            cmd.Parameters.AddWithValue("@classStartDate", classStartDate);
            cmd.CommandType = CommandType.Text;
            con.Open();
            isCreate=cmd.ExecuteNonQuery();
            con.Close();

        }
        return isCreate;

    }

}


