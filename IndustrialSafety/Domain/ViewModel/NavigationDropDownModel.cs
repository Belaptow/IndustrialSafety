namespace IndustrialSafety.Domain.ViewModel
{
    public class NavigationDropDownModel : NavigationPageModel
    {
        
        public List<NavigationPageModel> Items { get; set; }
        public NavigationDropDownModel(string title, string path, List<NavigationPageModel> items) : base(title, path)
        {
            Items = items;
        }

    }
}
