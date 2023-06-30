using ADOExercice;
using System.Data;
using System.Data.SqlClient;

string connectionString = @"Data Source=STEVEBSTORM\MSSQLSERVER01;Initial Catalog=CyberSecuExoADO;Integrated Security=True;";


#region Select Mode connecté (SqlDataReader)

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    using (SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "SELECT ID, Firstname, Lastname FROM V_Student";
//        connection.Open();
//        using (SqlDataReader reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                Console.WriteLine(
//                    $"{reader["ID"]} - {reader["firstname"]} {reader["lastname"]}"
//                    );
//            }
//        }
//        connection.Close();
//    }
//}


#endregion

#region Select mode déconnecté (SqlDataAdapter)
//using(SqlConnection conn = new SqlConnection(connectionString))
//{
//    using(SqlCommand cmd = conn.CreateCommand())
//    {
//        cmd.CommandText = "SELECT * FROM section";

//        SqlDataAdapter adapter = new SqlDataAdapter();
//        adapter.SelectCommand = cmd;

//        DataTable dt = new DataTable();

//        adapter.Fill(dt);

//        foreach(DataRow dr in dt.Rows)
//        {
//            Console.WriteLine($"{dr["ID"]} - {dr["SectionName"]}");
//        }
//    }
//}


#endregion

//using(SqlConnection conn = new SqlConnection(connectionString))
//{
//    using(SqlCommand cmd = conn.CreateCommand())
//    {
//        cmd.CommandText = "SELECT AVG(yearResult) FROM student";
//        conn.Open();
//        int moyenne = (int)cmd.ExecuteScalar();
//        conn.Close();
//        Console.WriteLine(moyenne);
//    }
//}

#region Insertion avec requête Parametrée
//Student moi = new Student
//{
//    Firstname = "Steve",
//    Lastname = "Lorent",
//    BirthDate = new DateTime(1983, 06, 28),
//    SectionId = 1010,
//    YearResult = 20
//};

//using (SqlConnection conn = new SqlConnection(connectionString))
//{
//    using (SqlCommand cmd = conn.CreateCommand())
//    {
//        cmd.CommandText =
//            "INSERT INTO Student (FirstName, LastName, BirthDate, YearResult, SectionId)" +
//            " OUTPUT inserted.ID " +
//            "VALUES (@first, @last, @bd, @yr, @sid)";

//        cmd.Parameters.AddWithValue("first", moi.Firstname);
//        cmd.Parameters.AddWithValue("last", moi.Lastname);
//        cmd.Parameters.AddWithValue("bd", moi.BirthDate);
//        cmd.Parameters.AddWithValue("yr", moi.YearResult);
//        cmd.Parameters.AddWithValue("sid", moi.SectionId);

//        conn.Open();
//        int newId = (int)cmd.ExecuteScalar();
//        conn.Close();
//        Console.WriteLine(newId);
//    }
//} 
#endregion