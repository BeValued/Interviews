using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace Interviews.Models
{
    public class BadClass
    {
        private string _name;

        public BadClass()
        {
            
        }

        public object MethodA(string i)
        {
            var dependency = new ExampleClass();

            var x = dependency.ExampleMethod(i);

            return x;
        }

        public string GetUserName(string id)
        {
            try
            {
                var db = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=V4_Default;Integrated Security=SSPI;Application Name=BeValued.Validator4");
                db.Open();
                var name = db.Query("select name from users where id=@id", new {id}).SingleOrDefault().Name;
                return name;
            }
            catch (Exception)
            {
                return "An error occurred";
            }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}