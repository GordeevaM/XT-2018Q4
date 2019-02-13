using Epam.Task06.DAL.Interface;
using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.DAL
{
    public class AwardSQLDAO : IAwardDAO
    {
        private string _connectionString;

        public AwardSQLDAO()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public void Add(Award award)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddAward";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter title = new SqlParameter("@title", award.Title);
                command.Parameters.Add(title);
                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }

        public bool Delete(int awardId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteAward";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@id", awardId);
                command.Parameters.Add(id);
                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
                return true;
            }
        }

        public IEnumerable<Award> GetAll()
        {
            var result = new List<Award>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAllAwards";
                command.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(
                        new Award
                        {
                            Id = (int)reader["id"],
                            Title = (string)reader["title"]
                        });
                }
            }
            return result;
        }

        public Award GetById(int awardId)
        {
            var result = new Award();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAward";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@id", awardId);
                command.Parameters.Add(id);
                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = (
                        new Award
                        {
                            Id = (int)reader["id"],
                            Title = (string)reader["title"]
                        });
                }
            }

            return result;
        }
    }
}
