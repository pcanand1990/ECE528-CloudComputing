namespace WebApplication1
{
    public interface IItemSource
    {
        List<Item> GetItems();

        void AddNewItem(string value);
    }
}
