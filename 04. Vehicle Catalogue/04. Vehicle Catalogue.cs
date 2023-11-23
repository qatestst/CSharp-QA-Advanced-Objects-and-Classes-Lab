namespace _04._Vehicle_Catalogue
{
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;

        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand= brand;
            Model = model;
            HorsePower = horsePower;
        }
    public string Brand {  set; get; }
    public string Model { get; set; }
    public int HorsePower { get; set; }

    }

    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set;}
    
    }



    public class Program
    {
        static void Main(string[] args)
        {
            
            Catalogue catalogue = new Catalogue();
            string command = Console.ReadLine();
           
            while (command != "end")
            {
                string[] data = command.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(data[3]);
                    Car currentCar = new Car(brand, model, horsePower);
                    catalogue.Cars.Add(currentCar);
                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(data[3]);
                    Truck currentTruck = new Truck(brand, model, weight);
                    catalogue.Trucks.Add(currentTruck);
                }

                

             command = Console.ReadLine();
            }

            if (catalogue.Cars.Count > 0) // == catalogue.Cars.Any
            {
                List<Car> sortedCars = catalogue.Cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars) 
                {
                   
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

                }
            
            }
            if (catalogue.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(truck => truck.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                   
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }

        }
    }
}