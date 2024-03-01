using PubMaui.Models;

namespace PubMaui
{
    public partial class App : Application
    {
        public static User? user;

       

        //public static UserService _pproapiService;

        public static int year0 = DateTime.Now.Year;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
