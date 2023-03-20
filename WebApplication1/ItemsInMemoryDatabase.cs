namespace WebApplication1
{
    public class ItemsInMemoryDatabase : ItemsDataSourceBase
    {
        public ItemsInMemoryDatabase()
        {
            Items = new List<Item>()
            {
                new Item(){ ID=1,Name="Milk"},
                new Item(){ID=2, Name="Yougurt"},
                new Item(){ID=3, Name="Chilli"}
            };
        }

        public override void AddNewItem(string value)
        {
            int newID = Items.Count() + 1;

            Items.Add(new Item() { ID = newID, Name = value });
        }

        public override List<Item> GetItems()
        {
            return Items;
        }
    }
}
