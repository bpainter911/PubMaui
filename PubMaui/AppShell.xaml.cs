using PubMaui.Pages;

namespace PubMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private readonly static Type[] _routablePageTypes =
            [
                typeof(SignInPage),
                typeof(SignUpPage),
                typeof(MyOrdersPage),
                typeof(OrdersDetailPage),
                typeof(DetailsPage),
            ];

        private static void RegisterRoutes()
        {
            foreach (var pagetype in _routablePageTypes)
            {
                Routing.RegisterRoute(pagetype.Name, pagetype);
            }

            
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.DisplayAlert("Copyright", "For more information on this or other " +
                "Apps or if you are in need of App development, " +
                "please contact us at 705-796-2834", "ok");
        }

        private async void SignoutClicked(object sender, EventArgs e)
        {
            await Shell.Current.DisplayAlert("In Works", "Will figure this out later", "ok");
        }
    }
}
