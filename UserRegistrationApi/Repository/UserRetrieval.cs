//-----------------------------------------------------------------------
// <copyright file="UserRetrieval.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UserRegistrationApi.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using Dapper;
    using UserRegistrationApi.Model;

    /// <summary>
    /// User Retrieval is repository class which retrieve data from database
    /// </summary>
    public class UserRetrieval
    {
        /// <summary>
        /// Gets all user.
        /// </summary>
        /// <returns>list of user</returns>
        /// <exception cref="System.Exception">system exception</exception>
        public async Task<IList<UserModel>> GetAllUser()
        {
            try
            {
                ////connection between application and databse
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=UserRegistrationdb;Integrated Security=True"))
                {
                    ////var user stores the data of the stored procedure
                    var user = await connection.QueryAsync<UserModel>("spGetUser", commandType: CommandType.StoredProcedure).ConfigureAwait(false);
                    connection.Close();
                    ////return data of database in list 
                    return user.AsList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets all user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>list of user</returns>
        /// <exception cref="System.Exception">system exception</exception>
        public async Task<IList<UserModel>> GetAllUser(int id)
        {
            try
            {
                ////connection between application and databse
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=UserRegistrationdb;Integrated Security=True"))
                {
                    ////var user stores the data of the stored procedure by passing id
                    var user = await connection.QueryAsync<UserModel>("spGetUserById", new { id }, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
                    connection.Close();
                    ////return data of database in list 
                    return user.AsList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="System.Exception">system exception</exception>
        public void DeleteUser(int id)
        {
            ////try is initilized to execute ignore the error and continue normal flow of the execution
            try
            {
                ////connection is established between databse and application
                using (var connection = new SqlConnection("Data Source=.;Initial Catalog=UserRegistrationdb;Integrated Security=True"))
                {
                    ////var user stores the data of the stored procedure by passing id
                    var user = connection.Execute("spDeleteUser", new { id }, commandType: CommandType.StoredProcedure);
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Edits the user.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>boolean true false</returns>
        /// <exception cref="System.Exception">system exception</exception>
        public bool EditUser(UserModel model)
        {
            ////try is initilized to execute ignore the error and continue normal flow of the execution
            try
            {
                ////connection is established between databse and application
                using (var connection = new SqlConnection("Data Source=.;Initial Catalog=UserRegistrationdb;Integrated Security=True"))
                {
                    int rowsAffected = connection.Execute("Edit", new { model.Id, model.FirstName, model.LastName, model.Email, model.Pass, model.MobleNo }, commandType: CommandType.StoredProcedure);
                    connection.Close();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>boolean true false</returns>
        /// <exception cref="System.Exception">system exception</exception>
        public bool AddUser(UserModel model)
        {
            ////try is initilized to execute ignore the error and continue normal flow of the execution
            try
            {
                ////connection is established between databse and application
                using (var connection = new SqlConnection("Data Source=.;Initial Catalog=UserRegistrationdb;Integrated Security=True"))
                {
                    int rowsAffected = connection.Execute("addMovies", new { model.FirstName, model.LastName, model.Email, model.Pass, model.MobleNo }, commandType: CommandType.StoredProcedure);
                    if (rowsAffected > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
