using Dapper;
using System.Data.SqlClient;

namespace ExamLinq;

public class DapperTask
{
    public void dapperGetAll()
    {
        using (SqlConnection _connection = new SqlConnection("Server=LAPTOP-UVN5MKL6\\SQLEXPRESS;Database=StudyThink;Trusted_Connection=True;TrustServerCertificate=true;"))
        {
            _connection.Open();

            string query = "SELECT * FROM x";
            List<Student> result = _connection.Query<Student>(query).ToList();

            _connection.Close();

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
