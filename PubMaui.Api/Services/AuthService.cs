using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PubMaui.Api.Data;
using PubMaui.Api.Data.Entities;
using PubMaui.Shared.Dtos;

namespace PubMaui.Api.Services
{
    public class AuthService(DataContext context, TokenService tokenService, PasswordService passwordService)
    {
        private readonly DataContext _context = context;
        private readonly TokenService _tokenService = tokenService;
        private readonly PasswordService _passwordService = passwordService;
        private string loggedInUser;

        public async Task<ResultWithDataDto<AuthResponseDto>> SignupAsync(SignupRequestDto dto)
        {
            if (await _context.Users.AsNoTracking().AnyAsync(u => u.Email == dto.Email))
            {
                return ResultWithDataDto<AuthResponseDto>.Failure("Email Already Exists");


            };

            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                FullName = dto.FullName,
                Email = dto.Email,
                PhNumber = dto.PhNumber,
                Address = dto.Address,
                CityTown =  dto.CityTown,
                PostalCode = dto.PostalCode,
                
            };

            (user.Salt, user.Hash) = _passwordService.GenerateSaltandHash(dto.Password);
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return GenerateAuthResponse(user);

            }
            catch (Exception ex)
            {

                return ResultWithDataDto<AuthResponseDto>.Failure(ex.Message);
            }



        }

        private ResultWithDataDto<AuthResponseDto> GenerateAuthResponse(User user)
        {
            var loggedInUser = new LoggedInUser(user.Id, user.FullName, user.Email);
            var token = _tokenService.GenerateJwt(loggedInUser);

            var authResponse = new AuthResponseDto(loggedInUser, token);

            return ResultWithDataDto<AuthResponseDto>.Success(authResponse);
        }

        public async Task<ResultWithDataDto<AuthResponseDto>> SigninAsync(SigninRequestDto dto)
        {
            var dbUser = await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == dto.Email);

            if(dbUser is null)
                return ResultWithDataDto<AuthResponseDto>.Failure("User does not exist");

            if(!_passwordService.AreEqual(dto.Password, dbUser.Salt, dbUser.Hash))
                return ResultWithDataDto<AuthResponseDto>.Failure("Incorrect Password");

            return GenerateAuthResponse(dbUser);

        }


    }
}
