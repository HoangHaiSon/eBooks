using eTickets.Data;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBook
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Bookstore 1",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIcv-y_d847vlmHmfcSoToEdoAOWFEAkpBw&usqp=CAU",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Bookstore 2",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIcv-y_d847vlmHmfcSoToEdoAOWFEAkpBw&usqp=CAU",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Bookstore 3",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIcv-y_d847vlmHmfcSoToEdoAOWFEAkpBw&usqp=CAU",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Bookstore 4",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIcv-y_d847vlmHmfcSoToEdoAOWFEAkpBw&usqp=CAU",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIcv-y_d847vlmHmfcSoToEdoAOWFEAkpBw&usqp=CAU",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Nguyễn Ngọc Ánh",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRLI8swj4slF-B2ZxcP9N2w01rJq62JqfsSKA&usqp=CAU"

                        },
                        new Actor()
                        {
                            FullName = "Dale Carnegie",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ50qd4rHizBpSonlbug8PbJtMxFZQ0OesBAg&usqp=CAU"
                        },
                        new Actor()
                        {
                            FullName = "Antoine Galland(translate)",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCNzFmvky1Ib2XR5geiRVgi8iMv1VdezYplg&usqp=CAU"
                        },
                        new Actor()
                        {
                            FullName = "J. K. Rowling",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTV-O52orHSu_odvnfDQXn7GQwo4WQhJ0y-QA&usqp=CAU"
                        },
                        new Actor()
                        {
                            FullName = "Hans Christian Andersen",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJNyAyafMMhl-DXljG5dLLvpZ1mmfKThw0Yg&usqp=CAU"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/vi/thumb/f/f8/Toithayhoavangtrencoxanh.jpg/280px-Toithayhoavangtrencoxanh.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://salt.tikicdn.com/media/catalog/product/i/m/img461_5.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://salt.tikicdn.com/media/catalog/product/n/g/nghin-le-mot-dem.u4939.d20170320.t100653.157641.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREFZTFqAP0auJs-SIF-LKvxxHOCOFYqxX_yA&usqp=CAU"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://firstnews.com.vn/public/uploads/products/dac-nhan-tam-biamem2019-76k-bia11.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "thousand and one night",
                            Description = "This is the thousand and one night book description",
                            Price = 39.50,
                            ImageURL = "https://salt.tikicdn.com/media/catalog/product/n/g/nghin-le-mot-dem.u4939.d20170320.t100653.157641.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "win hearts",
                            Description = "This is win hearts description",
                            Price = 29.50,
                            ImageURL = "https://firstnews.com.vn/public/uploads/products/dac-nhan-tam-biamem2019-76k-bia11.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "The Little Match Girl",
                            Description = "This is The Little Match Girl book  description",
                            Price = 39.50,
                            ImageURL = "https://salt.tikicdn.com/media/catalog/product/i/m/img461_5.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Gulliver's Travels",
                            Description = "This is Gulliver's Travels book  description",
                            Price = 39.50,
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREFZTFqAP0auJs-SIF-LKvxxHOCOFYqxX_yA&usqp=CAU",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Harry Poter",
                            Description = "This is Harry Poter book  description",
                            Price = 39.50,
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGSf9BinLdVWnPUm2yjH8VgvNo4ftpiJV3dg&usqp=CAU",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "I See Yellow Flowers In The Green Grass ",
                            Description = "This is I See Yellow Flowers In The Green Grass book description",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/vi/thumb/f/f8/Toithayhoavangtrencoxanh.jpg/280px-Toithayhoavangtrencoxanh.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },


                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },



                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },




                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 6

                        } });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
