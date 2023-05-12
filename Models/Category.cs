using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDotNet.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Displayorder { get; set; }
        public DateTime CreateDateTime {set; get;} = DateTime.Now;
    }
}
//private const string connectionString = "Data Source = localhost,1433;Initial Catalog =appmvc; User ID=sa; Password=Password123; TrustServerCertificate=True";