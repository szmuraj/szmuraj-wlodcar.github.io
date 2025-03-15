using WlodCar.Data;
using WlodCar.Models;

using WlodCarContext context = new WlodCarContext();


Console.WriteLine("""
        
        Wybierz opcję
        1. Wypisz wszystkich klientów
        2. Wypisz wszystkie samochody
        3. Wypisz wszystkie rezerwacje
        4. Dodaj nowego klienta
        5. Dodaj nowy samochód
        6. Dodaj nową rezerwację
        """);
if (int.TryParse(Console.ReadLine(), out int option))
{
    switch (option)
    {
        case 1:
            PrintCustomers();
            break;
        case 2:
            PrintCars();
            break;
        case 3:
            PrintReservations();
            break;
        case 4:
            AddCustomer();
            break;
        case 5:
            AddCar();
            break;
        case 6:
            AddReservation();
            break;
        default:
            Console.WriteLine("Niepoprawna opcja");
            break;
    }
}
else
{
    Console.WriteLine("Niepoprawna opcja");
}


void AddReservation()
{
    throw new NotImplementedException();
}

void AddCustomer()
{
    throw new NotImplementedException();
}

void AddCar()
{
    Car car = new Car
    {
        Make = Make.Skoda,
        Model = "Fabia",
        Color = "Czerwony",
        Fuel = FuelType.Benzyna,
        Year = new DateOnly(2021, 1, 1),
        Gearbox = GearboxType.Manualna,
        Body = BodyType.Hatchback,
        RegistrationNumber = "WLO12345",
        PricePerDay = 100.00M,
        Drive = DriveType.FWD,
        Seats = 5,
        Doors = 5,
        TrunkCapacity = 330,
        EngineCapacity = 4.5m,
        Power = 90,
        Image = "image_url_here",
        Description = "Compact city car with good fuel economy.",
        VIN = "VF123456789012345",
        Status = Status.Dostępny,
        GPSLatitude = 52.2298f,
        GPSLongitude = 21.0122f,
    }; // Tworzy nowe auto

    context.Cars.Add(car);
    context.SaveChanges();
}

void PrintReservations()
{
    throw new NotImplementedException();
}

void PrintCars()
{
    foreach (Car car in context.Cars)
    {
        Console.WriteLine($"Name: {car.Make} {car.Model}");
        Console.WriteLine($"Localization: {car.GPSLatitude} x {car.GPSLongitude}");
    }
}

void PrintCustomers()
{
    foreach (Customer customer in context.Customers)
    {
        Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
    }
}