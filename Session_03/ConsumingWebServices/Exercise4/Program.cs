using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exercise1 {
    class User {

        int id;
        string name;
        string username;
        string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
    }
    class Program {
        static void Main (string[] args) {
            HttpClient client = new HttpClient ();
            Task<string> getStringTask = client.GetStringAsync ("https://jsonplaceholder.typicode.com/users/1");
            string s = getStringTask.Result;
            User user = JsonConvert.DeserializeObject<User>(s);
            System.Console.WriteLine(user.Name);
        }
    }
}