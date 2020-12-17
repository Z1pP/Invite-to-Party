using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Project.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>(); // Коллекция
        public static IEnumerable<GuestResponse> Responses { get { return responses; } } 
        public static void AddResponce(GuestResponse response) // Добавление информации о гостях в коллекцию
        {
            responses.Add(response);
        }
    }
}
