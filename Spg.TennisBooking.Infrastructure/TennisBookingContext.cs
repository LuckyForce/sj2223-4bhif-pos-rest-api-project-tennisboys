﻿using Microsoft.EntityFrameworkCore;
using Spg.TennisBooking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.TennisBooking.Infrastructure
{
    public class TennisBookingContext : DbContext
    {
        public DbSet<Club> Clubs => Set<Club>();
        public DbSet<ClubEvent> ClubEvents => Set<ClubEvent>();
        public DbSet<ClubNews> Club_News => Set<ClubNews>();
        public DbSet<Court> Courts => Set<Court>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<SocialHub> SocialHubs => Set<SocialHub>();
        public DbSet<Trainer> Trainers => Set<Trainer>();


        protected TennisBookingContext() : this(new DbContextOptions<DbContext>())
        {
        }

        public TennisBookingContext(DbContextOptions options) : base(options)
        {
        }
    }
}