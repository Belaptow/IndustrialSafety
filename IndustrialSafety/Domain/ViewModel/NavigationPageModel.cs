namespace IndustrialSafety.Domain.ViewModel
{
    public class NavigationPageModel
    {
        public string Title { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public NavigationPageModel(string title, string path)
        {
            Title = title;
            Path = path;
        }
    }
}
