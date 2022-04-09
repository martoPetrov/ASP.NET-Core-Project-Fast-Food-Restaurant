﻿namespace FastFoodRestaurant.Services.Food
{
    public class FoodServiceListingModel
    {


        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageFileName { get; set; }


        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }


        public int ItemId { get; set; }

    }
}
