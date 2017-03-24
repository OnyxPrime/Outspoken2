using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Outspoken.Model;

namespace Outspoken.Data
{
	public class OutspokenContext : DbContext
	{
		public DbSet<ApplicationInformationHeader> ApplicationInformationHeaders { get; set; }
		public DbSet<ApplicationFeatureRequest> ApplicationFeatureRequests { get; set; }

		public OutspokenContext(DbContextOptions options) : base(options)
        {

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
			{
				relationship.DeleteBehavior = DeleteBehavior.Restrict;
			}

			modelBuilder.Entity<ApplicationInformationHeader>().ToTable("ApplicationInformationHeader").Ignore(e => e.NumberOfRequests);
			modelBuilder.Entity<ApplicationInformationHeader>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");
				entity.Property(e => e.ApplicationName).HasColumnName("APPNAME");
				entity.Property(e => e.ApplicationDescription).HasColumnName("APPDESCRIPTION");
			});
			modelBuilder.Entity<ApplicationInformationHeader>()
						.HasMany(a => a.FeatureRequests)
						.WithOne();
			
			modelBuilder.Entity<ApplicationFeatureRequest>().ToTable("ApplicationFeatureRequests");
			modelBuilder.Entity<ApplicationFeatureRequest>()
						.HasOne(af => af.ApplicationInformationHeader)
						.WithMany(a => a.FeatureRequests)
						.HasForeignKey(a => a.ApplicationId);
		}
	}
}
