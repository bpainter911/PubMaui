using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PubMaui.Pages;

#if IOS
using Security;
#endif
#if ANDROID
using System.Net.Security;
using Xamarin.Android.Net;
#endif
namespace PubMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            

            //Register Services
            

            // Register ViewModels
            

            //Register Pages(views)
            builder.Services.AddTransient<SignUpPage>();
            builder.Services.AddTransient<SignInPage>();

            return builder.Build();
        }

        
        

        


            };

           
        }
    

