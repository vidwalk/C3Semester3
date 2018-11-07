using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Client {
    public class Product {
        public class Order {
            private int id;
            private DateTime orderDate;
            private string orderNumber;
            private ICollection items;

            public ICollection Items { get => items; set => items = value; }

            public string OrderNumber { get => orderNumber; set => orderNumber = value; }

            public DateTime OrderDate { get => orderDate; set => orderDate = value; }

            public int Id { get => id; set => id = value; }
        }
        public class Cat {

            public Cat () {

            }
            private int id;
            private string name;

            private string color;
            private decimal price;
            private DateTime birthdate;
            private string favoriteDish;
            public int Id { get => id; set => id = value; }

            public string Name { get => name; set => name = value; }

            public string Color { get => color; set => color = value; }

            public decimal Price { get => price; set => price = value; }
            public DateTime Birthdate { get => birthdate; set => birthdate = value; }
            public string FavoriteDish { get => favoriteDish; set => favoriteDish = value; }
        }
        public class OrderItem {
            private int id;
            private Cat cat;
            private int quantity;
            private Order order;

            public int Id { get => id; set => id = value; }
            public Cat Cat { get => cat; set => cat = value; }
            public int Quantity { get => quantity; set => quantity = value; }
            public Order Order { get => order; set => order = value; }
        }
        class Program {
            static async Task<Uri> CreateCatAsync () {
                Cat cat = new Cat { Name = "MeowMeow4", Color = "Hugabuga", Price = 600, FavoriteDish = "Beef", Birthdate = DateTime.Today };
                using (var httpClientHandler = new HttpClientHandler ()) {
                    httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
                    using (var client = new HttpClient (httpClientHandler)) {
                        HttpResponseMessage response = await client.PostAsJsonAsync (
                            "https://localhost:5001/api/cat", cat);
                        return response.Headers.Location;
                    }
                }
            }

            static async Task<Cat> GetCatAsync (string path) {
                Cat cat = null;
                using (var httpClientHandler = new HttpClientHandler ()) {
                    httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
                    using (var client = new HttpClient (httpClientHandler)) {
                        HttpResponseMessage response = await client.GetAsync (path);
                        if (response.IsSuccessStatusCode) {
                            cat = await response.Content.ReadAsAsync<Cat> ();
                        }
                    }

                }
                return cat;
            }

            static async Task<List<Cat>> GetCatsAsync (string path) {
                List<Cat> cats = null;
                using (var httpClientHandler = new HttpClientHandler ()) {
                    httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
                    using (var client = new HttpClient (httpClientHandler)) {
                        HttpResponseMessage response = await client.GetAsync (path);
                        if (response.IsSuccessStatusCode) {
                            cats = await response.Content.ReadAsAsync<List<Cat>> ();
                        }
                    }

                }
                return cats;
            }

            static void Main () {
                RunAsync ().GetAwaiter ().GetResult ();

            }

            static async Task RunAsync () {
                using (var httpClientHandler = new HttpClientHandler ()) {
                    httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
                    using (var client = new HttpClient (httpClientHandler)) {
                        client.BaseAddress = new Uri ("https://localhost:5001");
                        client.DefaultRequestHeaders.Accept.Clear ();
                        client.DefaultRequestHeaders.Accept.Add (
                            new MediaTypeWithQualityHeaderValue ("application/json"));
                    }

                }
                // Update port # in the following line.
                System.Console.WriteLine ("What to do?");
                System.Console.WriteLine ("1) A cat");
                System.Console.WriteLine ("2) All cats");
                System.Console.WriteLine ("3) Save a cat and show all cats");
                switch (int.Parse (Console.ReadLine ())) {
                    case 1:

                        System.Console.WriteLine ("Which cat?");
                        Cat cat = await GetCatAsync ("https://localhost:5001/api/cat/" + int.Parse (Console.ReadLine ()));
                        System.Console.WriteLine (cat.Name);
                        break;
                    case 2:
                        List<Cat> cats = null;
                        cats = await GetCatsAsync ("https://localhost:5001/api/cat");
                        foreach (Cat c in cats)
                        {
                            System.Console.WriteLine(c.Name);
                        }
                        break;
                    case 3:

                        var url = await CreateCatAsync ();
                        List<Cat> cats2 = await GetCatsAsync ("https://localhost:5001/api/cat");
                          foreach (Cat c in cats2)
                        {
                            System.Console.WriteLine(c.Name);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}