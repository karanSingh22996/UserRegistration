//-----------------------------------------------------------------------
// <copyright file="ValuesController.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UserRegistrationApi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// values controller class provide the routing to run the application on web
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// get method will retrieve all the data from the database
        /// </summary>
        /// <returns>action result</returns>
        //// GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// get method returns the specific user details
        /// </summary>
        /// <param name="id">integer id</param>
        /// <returns>action result</returns>
        //// GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// post method will add new data to the database
        /// </summary>
        /// <param name="value">string value</param>
        //// POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// put method will update the data of the specific column
        /// </summary>
        /// <param name="id">integer id</param>
        /// <param name="value">string value</param>
        //// PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// delete method will delete the specific data from the database
        /// </summary>
        /// <param name="id">integer id</param>
        //// DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
