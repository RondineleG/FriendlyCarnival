namespace FriendlyCarnival.Client.Pages
{
    public partial class Index
    {
        public Dictionary<string, object> AdditionalAttributes { get; set; } = new Dictionary<string, object>
    {
        { "src", "/assets/products.png" },
        { "alt", "products image for the Home component" }
    };

        private int currentCount = 0;
        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
