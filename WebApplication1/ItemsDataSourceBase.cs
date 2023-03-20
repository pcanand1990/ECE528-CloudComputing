namespace WebApplication1
{
    public abstract class ItemsDataSourceBase : IItemSource
    {
        protected List<Item> Items { get; set; }
        public abstract void AddNewItem(string value);

        public abstract List<Item> GetItems();
    }
}
