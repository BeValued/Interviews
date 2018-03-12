using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interviews.Models;

namespace Interviews.Controllers.API
{
    public class PersonsController : ApiController
    {
        public IEnumerable<Person> Get()
        {
            return SampleData.Persons;
        }

        public IHttpActionResult Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
