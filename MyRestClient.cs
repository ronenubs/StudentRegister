

using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    public static class MyRestClient
    {
        public static string GetAllStudents()
        {
            var client = new RestClient("https://localhost/samplerest/displaystudents.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string DeleteStudent(int id)
        {
            var client = new RestClient("https://localhost/samplerest/deletestudent.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("studentID", id);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string InsertStudent(Student student)
        {
            var client = new RestClient("https://localhost/samplerest/insertstudent.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("firstname", student.Firstname);
            request.AddParameter("lastname", student.Lastname);
            request.AddParameter("middlename", student.Middlename);
            request.AddParameter("age", student.Age);
            request.AddParameter("address", student.Address);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
