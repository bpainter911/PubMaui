using PubMaui.Api.Services;
using PubMaui.Shared.Dtos;

namespace PubMaui.Api.Endpoints
{
    public static class Endpoints
    {
        public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/signup", async (SignupRequestDto dto, AuthService authService) =>
                TypedResults.Ok(await authService.SignupAsync(dto)));

            app.MapPost("/api/signin", async (SigninRequestDto dto, AuthService authService) =>
                TypedResults.Ok(await authService.SigninAsync(dto)));

            return app;
        }
    }
}
