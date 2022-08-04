﻿namespace ECommerce
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameSecondLanguage { get; set; }
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}