using Microsoft.EntityFrameworkCore;
using Spg.TennisBooking.Domain.Model;
using Spg.TennisBooking.Infrastructure;
using System;
using System.Linq;
using Xunit;

namespace Spg.TennisBooking.Domain.Test
{
    public class EntityTests : Tests
    {
        //TESTS
        //All creation of Entities should be tested here. One should work another should fail.

        //Club
        [Fact]
        public void DomainModel_Create_Club_Success_Test()
        {
            TennisBookingContext db = GetContext();

            Club newClub = CreateClub();

            db.Clubs.Add(newClub);
            db.SaveChanges();

            Assert.Equal(1, db.Clubs.Count());

            db.Database.EnsureDeleted();
        }

        //ClubEvent
        [Fact]
        public void DomainModel_Create_ClubEvent_Success_Test()
        {
            TennisBookingContext db = GetContext();

            Club newClub = CreateClub();

            ClubEvent newClubEvent = new ClubEvent(newClub, "Club Event 1", DateTime.Now, "Club Event 1 Info");

            db.ClubEvents.Add(newClubEvent);
            db.SaveChanges();

            Assert.Equal(1, db.ClubEvents.Count());

            db.Database.EnsureDeleted();
        }

        //ClubNews
        [Fact]
        public void DomainModel_Create_ClubNews_Success_Test()
        {
            TennisBookingContext db = GetContext();

            ClubNews newClubNews = new ClubNews("Club News 1", "Club News 1 Info", CreateClub());

            db.ClubNews.Add(newClubNews);
            db.SaveChanges();

            Assert.Equal(1, db.ClubNews.Count());
            
            db.Database.EnsureDeleted();
        }

        //Court
        [Fact]
        public void DomainModel_Create_Court_Success_Test()
        {
            TennisBookingContext db = GetContext();

            Court newCourt = new Court(CourtType.Hard, "Court 1", CreateClub(),
            20, 20, 5, 15, 12);

            db.Courts.Add(newCourt);
            db.SaveChanges();

            Assert.Equal(1, db.Courts.Count());

            db.Database.EnsureDeleted();
        }

        //Customer
        [Fact]
        public void DomainModel_Create_Customer_Success_Test()
        {
            TennisBookingContext db = GetContext();

            Customer newCustomer = CreateCustomer();

            db.Customers.Add(newCustomer);
            db.SaveChanges();

            Assert.Equal(1, db.Customers.Count());

            db.Database.EnsureDeleted();
        }

        //Reservation
        [Fact]
        public void DomainModel_Create_Reservation_Success_Test()
        {
            TennisBookingContext db = GetContext();

            Reservation newReservation = new Reservation(CreateClub(),
            DateTime.Now, 22, 23,
            new Court(CourtType.Hard, "Court 1", CreateClub(),
            20, 20, 5, 15, 12),
            CreateCustomer());

            db.Reservations.Add(newReservation);
            db.SaveChanges();

            Assert.Equal(1, db.Reservations.Count());

            db.Database.EnsureDeleted();
        }
        //SocialHub
        [Fact]
        public void DomainModel_Create_SocialHub_Success_Test()
        {
            TennisBookingContext db = GetContext();

            SocialHub newSocialHub = new SocialHub();

            db.SocialHubs.Add(newSocialHub);
            db.SaveChanges();

            Assert.Equal(1, db.SocialHubs.Count());

            db.Database.EnsureDeleted();
        }

        //Trainer        
        [Fact]
        public void DomainModel_Create_Trainer_Success_Test()
        {
            TennisBookingContext db = GetContext();

            Trainer newTrainer = new Trainer(
                CreateClub(), "Trainer Firstname", "Trainer Lastname", GenderTypes.Male, "Trainer Musterstrasse 1", 1321, "SomeImage");

            db.Trainers.Add(newTrainer);
            db.SaveChanges();

            Assert.Equal(1, db.Trainers.Count());

            db.Database.EnsureDeleted();
        }
    }
}