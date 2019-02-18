//-----------------------------------------------------------------------
// <copyright file="UserController.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UserRegistrationApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using UserRegistrationApi.Model;
    using UserRegistrationApi.Repository;

    /// <summary>
    /// User controller class is the specific controller class of our application
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// The retrieval is the object of our repository class
        /// </summary>
       private UserRetrieval retrieval = new UserRetrieval();

        /// <summary>
        /// get method will return all the data of the database
        /// </summary>
        /// <returns>list of user</returns>
        //// GET: api/User
        [HttpGet]
        public IList<UserModel> Get()
        {
            try
            {
                ////list will store all the data from the get all user method
                IList<UserModel> movies = this.retrieval.GetAllUser().Result;
                return movies;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// returns the specific data from the database
        /// </summary>
        /// <param name="id">integer id</param>
        /// <returns>list of specific user</returns>
        //// GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public IList<UserModel> Get(int id)
        {
            try
            {
                IList<UserModel> user = this.retrieval.GetAllUser(id).Result;
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// post method will add the data into the database
        /// </summary>
        /// <param name="model">User model class</param>
        /// <returns>boolean true false</returns>
        //// POST: api/User
        [HttpPost]
        public bool Post([FromBody] UserModel model)
        {
            try
            {
                this.retrieval.AddUser(model);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// put method will update the data of the database
        /// </summary>
        /// <param name="id">integer id</param>
        /// <param name="model"> user model</param>
        /// <returns>action result</returns>
        //// PUT: api/User/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] UserModel model)
        {
            try
            {
                bool response = this.retrieval.EditUser(model);
                return this.Ok(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// delete method will delete the specific data
        /// </summary>
        /// <param name="id">integer id</param>
        /// <returns>boolean true false</returns>
        //// DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                this.retrieval.DeleteUser(id);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
