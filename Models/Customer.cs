// Ignore Spelling: PESEL REGON Ballance

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WlodCar.Models;

public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastLoginDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    public short? PhoneNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Country { get; set; }

    [Column("PESEL")]
    public short? PESEL { get; set; }

    [Column("NIP")]
    public short? NIP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [Column("REGON")]
    public short? REGON { get; set; }

    public int Points { get; set; }

    public int? BankAccountNumber { get; set; }

    [StringLength(10)]
    public string? IdCardNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DrivingLicenseNumber { get; set; }

    public DateOnly? DrivingLicenseIssueDate { get; set; }

    public DateOnly? DrivingLicenseExpirationDate { get; set; }

    public bool CustomerType { get; set; } // 0 - individual, 1 - company

    [StringLength(50)]
    [Unicode(false)]
    public string? ProfilePicture { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IdCardPicture { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DrivingLicensePicture { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Ballance { get; set; }

    public bool IsBlocked { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
