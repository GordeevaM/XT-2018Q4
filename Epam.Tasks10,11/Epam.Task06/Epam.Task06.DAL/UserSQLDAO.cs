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
    public class UserSQLDAO : IUserDAO
    {
        private string _connectionString;

        public UserSQLDAO()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public void Add(User user)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter firstName = new SqlParameter("@first_name", user.FirstName);
                command.Parameters.Add(firstName);
                SqlParameter lastName = new SqlParameter("@last_name", user.LastName);
                command.Parameters.Add(lastName);
                SqlParameter DateOfBirth = new SqlParameter("@date_of_birth", user.DateOfBirth);
                command.Parameters.Add(DateOfBirth);
                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }

        public void AddAward(int userId, int awardId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddAwardToUser";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter user = new SqlParameter("@user_id", userId);
                command.Parameters.Add(user);
                SqlParameter award = new SqlParameter("@award_id", awardId);
                command.Parameters.Add(award);
                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }
        public bool Delete(int userId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@id", userId);
                command.Parameters.Add(id);
                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
                return true;
            }
        }

        public IEnumerable<User> GetAll()
        {
            var result = new List<User>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAllUsers";
                command.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(
                        new User
                        {
                            Id = (int)reader["id"],
                            FirstName = (string)reader["first_name"],
                            LastName = (string)reader["last_name"],
                            DateOfBirth = (DateTime)reader["date_of_birth"]
                        });
                }
            }

            return result;
        }

        public IEnumerable<Award> GetAwards(int userId)
        {
            var result = new List<Award>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetUsersAwards";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@user_id", userId);
                command.Parameters.Add(id);
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

        public User GetById(int userId)
        {
            var result = new User();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetUser";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@id", userId);
                command.Parameters.Add(id);
                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = (
                        new User
                        {
                            Id = (int)reader["id"],
                            FirstName = (string)reader["first_name"],
                            LastName = (string)reader["last_name"],
                            DateOfBirth = (DateTime)reader["date_of_birth"]
                        });
                }
            }

            return result;
        }
    }
}
