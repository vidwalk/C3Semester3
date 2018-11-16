using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Entities
{
    public class Cat{

        public Cat()
        {

        }
        private int id;
        private string name;
        
        private string color;
        private decimal price;
        private DateTime birthdate;
        private string favoriteDish;
        [Required (ErrorMessage="Id {0} is required")]
        public int Id { get => id; set => id = value; }
        [Required (ErrorMessage="Name {0} is required")]
        [StringLength (20,MinimumLength=2,
        ErrorMessage="Name Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string Name { get => name; set => name = value; }
        [Required (ErrorMessage="Color {0} is required")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Use letters only please")]
        [DataType(DataType.Text)]
        public string Color { get => color; set => color = value; }
        [Required (ErrorMessage="Price {0} is required")]
        [Column(TypeName = "decimal(18,2)")]
        
        public decimal Price { get => price; set => price = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string FavoriteDish { get => favoriteDish; set => favoriteDish = value; }
    }
}