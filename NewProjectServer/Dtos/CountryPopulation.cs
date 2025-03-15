using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NewProjectServer.Dtos
{
    public class CountryPopulation
    {
      
        public int Id { get; set; }

      
        public string Name { get; set; } = null!;

        public string Iso2 { get; set; } = null!;

       
        public string Iso3 { get; set; } = null!;

        public int Population { get; set; }

        public int Citycount { get; set; }
    }
}
