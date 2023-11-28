using AimConverter.Models;

namespace AimConverter
{
    public partial class MainPage : ContentPage
    {
        public IReadOnlyList<GameInfo> Games => AppData.Games;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }

}
