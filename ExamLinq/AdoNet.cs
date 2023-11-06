using Microsoft.Data.SqlClient;

namespace ExamLinq;

public static class AdoNet
{
    public static void GetAll()
    {
        using (SqlConnection connectiion = new SqlConnection(""))
        {
            connectiion.Open();
            
            connectiion.Close();
        }
    }
}
