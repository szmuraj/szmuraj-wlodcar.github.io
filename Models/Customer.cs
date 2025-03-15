// Ignore Spelling: REGON PESEL Ballance

namespace WlodCar.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public string Email { get; set; } = null!;

    public short? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? ZipCode { get; set; }

    public string? Country { get; set; }

    public long? PESEL { get; set; }

    public long? NIP { get; set; }

    public string? CompanyName { get; set; }

    public long? REGON { get; set; }

    public int Points { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? IdCardNumber { get; set; }

    public string? DrivingLicenseNumber { get; set; }

    public DateOnly? DrivingLicenseIssueDate { get; set; }

    public DateOnly? DrivingLicenseExpirationDate { get; set; }

    public bool IsCustomer { get; set; } // 1 = customer, 0 = company

    public string? ProfilePicture { get; set; }

    public string? IdCardPicture { get; set; }

    public string? DrivingLicensePicture { get; set; }

    public string Password { get; set; } = null!;

    public decimal Ballance { get; set; }

    public bool IsBlocked { get; set; } // 1 = blocked, 0 = active

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
