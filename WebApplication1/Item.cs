namespace WebApplication1
{
    public class Item
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public class UserItems
    {
        public List<Item> ItemsCollection { get; set; }
    }
}
