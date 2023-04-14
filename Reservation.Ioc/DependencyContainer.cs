using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Ioc
{
    public static class DependencyContainer
    {
            public static void AddDependencies(this IServiceCollection services)
            {
                //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                //services.AddScoped<IUserRepository, UserRepository>();
                //services.AddScoped<IArtistRepository, ArtistRepository>();
                //services.AddScoped<IUserService, UserService>();
                //services.AddScoped<IMovieService, MovieService>();
                //services.AddScoped<IArtistService, ArtistService>();
                //services.AddScoped<IMovieRepository, MovieRepository>();
                //services.AddScoped<IMovieService, MovieService>();
                //services.AddScoped<IPasswordHasher, PasswordHasher>();
                //services.AddScoped<IMailSender, MailSender>();

            }
        }
}
