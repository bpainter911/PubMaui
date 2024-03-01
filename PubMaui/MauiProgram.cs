using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PubMaui.Pages;
using PubMaui.Services;
using PubMaui.ViewModels;
using Refit;

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
            builder.Services.AddTransient<AuthViewModel>();

            //Register Pages(views)
            builder.Services.AddTransient<SignUpPage>();
            builder.Services.AddTransient<SignInPage>();

            ConfigureRefit(builder.Services);

            return builder.Build();
        }



        private static void ConfigureRefit(IServiceCollection services)
        {
            var refitSettings = new RefitSettings
            {
                HttpMessageHandlerFactory = () =>
                {
#if ANDROID
                    return new AndroidMessageHandler
                    {

                        ServerCertificateCustomValidationCallback = (httpRequestMessage, certificate, chain, sslPolicyErrors) =>
                        {
                            return certificate?.Issuer == "CN=localhost" || sslPolicyErrors == SslPolicyErrors.None;
                            
                        }
                    };
#elif IOS
                    return new NSUrlSessionHandler
                    {
                        TrustOverrideForUrl = (NSUrlSessionHandler sender, string url, SecTrust trust) =>
                            url.StartsWith("https://localhost")
                    };
#endif
                    return null;
                }
            };

            services.AddRefitClient<IAuthApi>(refitSettings)
                .ConfigureHttpClient(httpClient =>
                {
                    var baseUrl = DeviceInfo.Platform == DevicePlatform.Android
                                    ? "https://10.0.2.2:7293"
                                    : "https://localhost:7293";
                    httpClient.BaseAddress = new Uri(baseUrl);
                }
                );
        }



    };
}

           
        
    

