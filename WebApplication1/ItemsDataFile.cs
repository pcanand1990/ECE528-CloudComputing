using System.Text.Json;

namespace WebApplication1
{
    public class ItemsDataFile : ItemsDataSourceBase
    {
        
        public ItemsDataFile() 
        {

        }
        public override List<Item> GetItems()
        {
            return ReadData();
        }

        public override void AddNewItem(string value)
        {
            Items = ReadData();

            int newID = Items.Count() + 1;

            Items.Add(new Item() { ID = newID, Name = value });

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize<List<Item>>(Items, options);
            string fileName = @"D:\Temp\Items.json";

            File.WriteAllText(fileName, jsonString);
        }

        private List<Item> ReadData()
        {
            string fileName = @"D:\Temp\Items.json";
            string jsonString = File.ReadAllText(fileName);
            Items = JsonSerializer.Deserialize<List<Item>>(jsonString)!;

            return Items;
        }
    }
}
