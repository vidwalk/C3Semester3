using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server.Entities {
    public class Order {
        private int id;
        private DateTime orderDate;
        private string orderNumber;
        private ICollection items;
        
        [NotMapped]
        public ICollection Items { get => items; set => items = value; }

        public string OrderNumber { get => orderNumber; set => orderNumber = value; }

        public DateTime OrderDate { get => orderDate; set => orderDate = value; }

        [Key]
        [Required (ErrorMessage = "Id {0} is required")]
        public int Id { get => id; set => id = value; }
    }
}