using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WlodCar.Models;

public partial class Reservation
{
    [Key]
    public int Id { get; set; }

    public int CarId { get; set; }

    public int CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [Column(TypeName = "money")]
    public decimal TotalPrice { get; set; }

    [ForeignKey("CarId")]
    [InverseProperty("Reservations")]
    public virtual Car Car { get; set; } = null!;

    [ForeignKey("CustomerId")]
    [InverseProperty("Reservations")]
    public virtual Customer Customer { get; set; } = null!;
}
