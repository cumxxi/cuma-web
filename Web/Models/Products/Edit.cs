using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Web.Models.Products
{
    public class Edit : PageModel
    {
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        
        public Edit()
        {
            this.ProductName = "Kırmızı Ayakkabı"; 
            this.UnitsInStock = 23;
        }


    }
}