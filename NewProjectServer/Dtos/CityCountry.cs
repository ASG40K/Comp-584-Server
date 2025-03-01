using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NewProjectServer.Dtos
{
    public class CityCountry
    {
        public int Id { get; set; }


        public string Name { get; set; } = null!;

        public int Populatoion { get; set; }

        public string CountryName { get; set; } = null!;
    }
}
