namespace _03._Store_Boxes
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }

    public class Box
    {
        public Box(string serialnumber, Item item, int itemQuantity)
        {
            SerialNumber = serialnumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForBox = item.Price * itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxList = new List<Box>();
            List<Item> itemList = new List<Item>();

            while (command != "end")
            {
                string[] itemProperties = command.Split(" ");

                string serialNumber = itemProperties[0];
                string itemName = itemProperties[1];
                int itemQuantity = int.Parse(itemProperties[2]);
                decimal itemPrice = decimal.Parse(itemProperties[3]);
                
                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

                boxList.Add(currentBox);
                
                command = Console.ReadLine();
            }
            boxList = boxList.OrderByDescending(box => box.PriceForBox).ToList();

            foreach(Box box in boxList) 
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity} ");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
           
        }
    }
}