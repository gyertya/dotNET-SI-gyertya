﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class IndexModel : PageModel
    {
        private IRestaurantData _restaurantData;

        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }

        public IndexModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Restaurants = _restaurantData.GetAll();
        }

    }
}