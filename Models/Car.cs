using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WlodCar.Models;

public partial class Car
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Make { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Model { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Color { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Fuel { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Gearbox { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Body { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Drive { get; set; } = null!;

    public byte Seats { get; set; }

    public byte Doors { get; set; }

    public byte TrunkCapacity { get; set; }

    public byte EngineCapacity { get; set; }

    public byte Power { get; set; }

    [Column(TypeName = "text")]
    public string Image { get; set; } = null!;

    [Column(TypeName = "text")]
    public string Description { get; set; } = null!;

    public DateOnly Year { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNumber { get; set; } = null!;

    [Column("VIN")]
    [StringLength(17)]
    [Unicode(false)]
    public string Vin { get; set; } = null!;

    public bool IsAvailable { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal PricePerDay { get; set; }

    [Column("GPSLatitude", TypeName = "decimal(18, 0)")]
    public decimal Gpslatitude { get; set; }

    [Column("GPSLongitude", TypeName = "decimal(18, 0)")]
    public decimal Gpslongitude { get; set; }

    [InverseProperty("Car")]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
