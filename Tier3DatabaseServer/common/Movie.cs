using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
namespace Tier3ServerDatabase.common {
    public class Movie {
        private int id;
        private string title;
        private string yearCreation;
        private string releaseDate;
        private double price;
        private string nameStudio;
        private string nameDirector;
        private string description;
        private string nameMainActor;
        private bool rented;

        public Movie (string title) {
            this.Title = title;
        }

        //Can't deserialize without defaulting to this
        [JsonConstructor]
        public Movie (string title, string yearCreation, string releaseDate, double price, string nameStudio,
            string nameDirector, string description, string nameMainActor) {
            this.Title = title;
            this.YearCreation = yearCreation;
            this.ReleaseDate = releaseDate;
            this.Price = price;
            this.NameStudio = nameStudio;
            this.NameDirector = nameDirector;
            this.Description = description;
            this.NameMainActor = nameMainActor;
            this.Rented = false;
        }
        //The ID is ignored in JSON
        [Key]
        [JsonIgnore]
        [Required (ErrorMessage="Id {0} is required")]
        public int Id { get => id; set => id = value; }
        [Required (ErrorMessage="Name {0} is required")]
        [StringLength (20,MinimumLength=2,
        ErrorMessage="Name Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string Title { get => title; set => title = value; }
        [StringLength (20,MinimumLength=2,
        ErrorMessage="year of Creation Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string YearCreation { get => yearCreation; set => yearCreation = value; }
        [StringLength (20,MinimumLength=2,
        ErrorMessage="releaseDate Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string ReleaseDate { get => releaseDate; set => releaseDate = value; }
        [Required (ErrorMessage="Price {0} is required")]
        [Column(TypeName = "decimal(18,2)")]
        public double Price { get => price; set => price = value; }
        [StringLength (20,MinimumLength=2,
        ErrorMessage="Name Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string NameStudio { get => nameStudio; set => nameStudio = value; }
        [StringLength (20,MinimumLength=2,
        ErrorMessage="Name Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string NameDirector { get => nameDirector; set => nameDirector = value; }
        [StringLength (40,MinimumLength=2,
        ErrorMessage="Description Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string Description { get => description; set => description = value; }
        [StringLength (20,MinimumLength=2,
        ErrorMessage="Name Should be minimum 2 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string NameMainActor { get => nameMainActor; set => nameMainActor = value; }
        [Column(TypeName = "bit")]
        public bool Rented { get => rented; set => rented = value; }

        public override String ToString() {
	    return "Movie Title=" + title + ", yearCreation=" + yearCreation + ", releaseDate=" + releaseDate + ", price="
			+ price + ", nameStudio=" + nameStudio + ", nameDirector=" + nameDirector + ", description=" + description
			+ ", nameMainActor=" + nameMainActor + " \n ";
    }
    }
}