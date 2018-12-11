using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Models.Components;
using System;

namespace Web.Models.Home
{
    public class Index : PageModel
    {
        public Breads Breads { get; set; }
        public Category Category { get; set; }
        public Footer Footer { get; set; }
        public Header Header { get; set; }
        public Navbar Navbar { get; set; }
        public Pagination Pagination { get; set; }
        public Product Product { get; set; }
        public Slider Slider { get; set; }
        public Tab Tab { get; set; }

        public Index()
        {
            Breads = new Breads
            {
                Kerata = "Index Kerata",
                Naber = "Index Naber"
            };

            Category = new Category
            {
                Kerata = "Category Kerata",
                Naber = "Category Naber"
            };

            Footer = new Footer
            {
              Kerata = "Footer Kerata",
              Naber = "Footer Naber"  
            };

            Header = new Header
            {
                Kerata = "Header Kerata",
                Naber = "Header Naber"
            };

            Navbar = new Navbar
            {
                Kerata = "Navbar Kerata",
                Naber = "Navbar Naber"
            };

            Pagination = new Pagination
            {
                Kerata = "Pagination Kerata",
                Naber = "Pagination Naber"
            };

            Product = new Product
            {
                Kerata = "Product Kerata",
                Naber = "Product Naber"
            };

            Slider = new Slider
            {
                Kerata = "Slider Kerata",
                Naber = "Slider Naber"
            };

            Tab = new Tab
            {
                Kerata = "Tab Kerata",
                Naber = "Tab Naber"
            };
        }
    }
}