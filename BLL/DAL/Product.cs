#nullable disable //referans tiplerinin yanına böylelikle soru işareti koymak zorunda kalmıyoruz, kategori için de geçerli ama değer tipleri için geçerli değil.


using System.ComponentModel.DataAnnotations;

namespace BLL.DAL;

    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }
        
        public int? StockAmount { get; set; }
        
        public DateTime? ExpirationDate { get; set; }

        public int CategoryId { get; set; }
        
        public Category Category { get; set; }
        
    }
    
