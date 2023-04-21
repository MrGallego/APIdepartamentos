using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Departamentos
{
    public class ConexionBD
    {
        private string connectionString 
        = "Data Source=.;Initial Catalog=DANE;user=code;password=1234;TrustServerCertificate=true;";

        public List<Department> Get()
        {
            List<Department> result = new List<Department>();
            string query = "SELECT Name FROM Departaments";

            using (SqlConnection connection = new SqlConnection(connectionString) )
            {

                
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Department department = new Department();
                    department.Name = reader.GetString(0);
                    result.Add(department);
                }
                reader.Close();
                connection.Close();
            }

            return result;
        }
    }
}
