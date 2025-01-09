using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDMC5MiniChallengeEightToTen_Endpoint.Services
{
    public class RestaurantPickerServices
    {
        public string RestaurantPicker(string restaurantCategory)
        {
            Random rng = new Random();
            int selection = rng.Next(10);
            string[][] restaurants = {
                ["Las Palmas | Mexican Restaurant & Bar", "Taco House Mexican Grill", "Fuego Taqueria", "La Mesa Mexican Kitchen", "El Chilango Chido", "Taqueria El Azteca", "El Grullito", "Tonantzin \"Taco Goddess\"", "Miguel\'s Mexican Dining", "Tu Pueblito Taqueria"],
                ["China Palace Restaurant", "Prosperity Szechuan Cuisine", "Beijing Buffet", "Oriental Chef", "China Village Restaurant", "Tsing Tao Restaurant", "Dynasty Seafood Restaurant", "Bonchon North Stockton", "Dave Wong\'s Restaurant & Deli", "China Express by Food4Less"],
                ["Jack in the Box", "Wendy\'s", "A&W Restaurant", "Raising Cane\'s Chicken Fingers", "Wingstop", "Taco Bell", "McDonald\'s", "Burger King", "Popeyes Louisiana Kitchen", "Krazy Burger & Chicken"]
            };

            switch(restaurantCategory){
                case "Mexican":
                    return $"How about: {restaurants[0][selection]}";       
                case "Asian":
                    return $"How about: {restaurants[1][selection]}";
                case "Fast Food":
                    return $"How about: {restaurants[2][selection]}";
                default:
                    return $"Invalid Input: Type either \"Mexican\", \"Asian\" or \"Fast Food\" exactly as they appear in the quotation marks.";
            }
        }
    }
}