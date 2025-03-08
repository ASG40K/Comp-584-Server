using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewDatabaseModel;

public partial class City
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public decimal Lat { get; set; }

    public decimal Lon { get; set; }

    public int Populatoion { get; set; }

    [Column("CountryID")]
    public int CountryId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("Cities")]
    public virtual Country Country { get; set; } = null!;
}
