using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Evaluation_Manager.Repositories
{
    internal class TeacherRepository
    {
        public static Teacher GetTeacher(int id)
        {
            string sqlQuery = $"SELECT * FROM Teachers WHERE Id = {id}";
            return FetchTeacher(sqlQuery);
        }

        public static Teacher GetTeacher(string username)
        {
            string sqlQuery = $"SELECT * FROM Teachers WHERE Username = '{username}'";
            return FetchTeacher(sqlQuery);
        }
        private static Teacher FetchTeacher(string sqlQuery)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sqlQuery);
            Teacher teacher = null;
            if (reader.HasRows)
            {
                reader.Read();
                teacher = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return teacher;
        }

        private static Teacher CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstname = reader["FirstName"].ToString();
            string lastname = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();

            var teacher = new Teacher
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Username = username,
                Password = password
            };
            
            return teacher;
        }
    }
}
