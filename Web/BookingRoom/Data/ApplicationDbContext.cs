﻿using BookingRoom.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingRoom.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}

		public DbSet<Room> Rooms { get; set; }
		public DbSet<Ivent> Ivents { get; set; }
		public DbSet<IventReport> Reports { get; set; }
		public DbSet<IventType> IvenTypes { get; set; }
		public DbSet<Booking> Bookings { get; set; }
	}
}
