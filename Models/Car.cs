namespace WlodCar.Models;

public partial class Car
{
    public int Id { get; set; }

    public Make Make { get; set; }

    public string Model { get; set; } = null!;

    public string Color { get; set; } = null!;

    public FuelType Fuel { get; set; }

    public GearboxType Gearbox { get; set; }

    public BodyType Body { get; set; }

    public DriveType Drive { get; set; }

    public int Seats { get; set; }

    public int Doors { get; set; }

    public int TrunkCapacity { get; set; }

    public decimal EngineCapacity { get; set; }

    public int Power { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly Year { get; set; }

    public string RegistrationNumber { get; set; } = null!;

    public string VIN { get; set; } = null!;

    public Status Status { get; set; }

    public decimal PricePerDay { get; set; }

    public double GPSLatitude { get; set; }

    public double GPSLongitude { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
