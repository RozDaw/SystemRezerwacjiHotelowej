using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SystemRezerwacjiHotelowej.Components;

namespace SystemRezerwacjiHotelowej.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<SystemRezerwacjiHotelowej.Components.Room> Room { get; set; } = default!;
        public DbSet<SystemRezerwacjiHotelowej.Components.Reservation> Reservation { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Room>().HasData(
            //    new Room
            //    {
            //        Id = -100,
            //        Numer = 1,
            //        Pietro = 1,
            //        IloscOsob = 1,
            //        CenaZaDobe = 1,
            //        Standard = "tak"
            //    });

            {
                int roomId = 1;
                var rooms = new List<Room>();

                // Dodawanie pokoi zgodnie ze specyfikacją
                for (int pietro = 1; pietro <= 8; pietro++)
                {
                    for (int numer = 1; numer <= 30; numer++)
                    {
                        int fullRoomNumber = pietro * 100 + numer;
                        switch (pietro)
                        {
                            case 8:
                                rooms.Add(new Room
                                {
                                    Id = roomId++,
                                    Numer = fullRoomNumber,
                                    Pietro = pietro,
                                    IloscOsob = 1,
                                    CenaZaDobe = 500,
                                    Standard = "deluxe"
                                });
                                break;

                            case 7:
                                rooms.Add(new Room
                                {
                                    Id = roomId++,
                                    Numer = fullRoomNumber,
                                    Pietro = pietro,
                                    IloscOsob = 1,
                                    CenaZaDobe = 400,
                                    Standard = "superior"
                                });
                                break;

                            case 5:
                                rooms.Add(new Room
                                {
                                    Id = roomId++,
                                    Numer = fullRoomNumber,
                                    Pietro = pietro,
                                    IloscOsob = 1,
                                    CenaZaDobe = 300,
                                    Standard = "ekonomiczny"
                                });
                                break;

                            case 6:
                                rooms.Add(new Room
                                {
                                    Id = roomId++,
                                    Numer = fullRoomNumber,
                                    Pietro = pietro,
                                    IloscOsob = 2,
                                    CenaZaDobe = 700,
                                    Standard = "superior"
                                });
                                break;

                            case 4:
                                rooms.Add(new Room
                                {
                                    Id = roomId++,
                                    Numer = fullRoomNumber,
                                    Pietro = pietro,
                                    IloscOsob = 2,
                                    CenaZaDobe = 500,
                                    Standard = "ekonomiczny"
                                });
                                break;

                            case 3:
                                rooms.Add(new Room
                                {
                                    Id = roomId++,
                                    Numer = fullRoomNumber,
                                    Pietro = pietro,
                                    IloscOsob = 3,
                                    CenaZaDobe = 800,
                                    Standard = "ekonomiczny"
                                });
                                break;

                            case 1:
                            case 2:
                                rooms.Add(new Room
                                {
                                    Id = roomId++,
                                    Numer = fullRoomNumber,
                                    Pietro = pietro,
                                    IloscOsob = 4,
                                    CenaZaDobe = 1000,
                                    Standard = "ekonomiczny"
                                });
                                break;
                        }
                    }
                }

                // Dodanie pokoi do modelu
                modelBuilder.Entity<Room>().HasData(rooms);
            }


        }
    }
}
