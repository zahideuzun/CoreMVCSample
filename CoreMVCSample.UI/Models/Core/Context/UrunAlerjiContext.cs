using CoreMVCSample.UI.Models.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCSample.UI.Models.Core.Context
{
	public class UrunAlerjiContext : DbContext
	{
		public UrunAlerjiContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//product tablosu
			modelBuilder.Entity<Product>().ToTable("Product");
			modelBuilder.Entity<Product>()
				.HasKey(a => a.ProductId);
			modelBuilder.Entity<Product>()
				.Property(a => a.ProductName)
				.IsRequired().HasMaxLength(50);
			//category tablosu
			modelBuilder.Entity<Category>().ToTable("Category");
			modelBuilder.Entity<Category>()
				.HasKey(a => a.CategoryId);
			modelBuilder.Entity<Category>()
				.Property(a => a.CategoryName)
				.IsRequired().HasMaxLength(50);
			//content tablosu
			modelBuilder.Entity<Content>().ToTable("Content");
			modelBuilder.Entity<Content>()
				.HasKey(a => a.ContentId);
			modelBuilder.Entity<Content>()
				.Property(a => a.ContentName)
				.IsRequired().HasMaxLength(50);
			//user tablosu
			modelBuilder.Entity<User>().ToTable("User");
			modelBuilder.Entity<User>()
				.HasKey(a => a.UserId);
			modelBuilder.Entity<User>()
				.Property(a => a.UserName)
				.IsRequired().HasMaxLength(50);


			modelBuilder.Entity<ProductCategory>()
				.ToTable("ProductCategory")
				.HasKey(a => new
				{
					a.ProductId,
					a.CategoryId
				});
			modelBuilder.Entity<ProductCategory>()
				.HasOne<Product>(a => a.Product)
				.WithMany(a => a.ProductCategories)
				.HasForeignKey(a => a.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<ProductCategory>()
				.HasOne<Category>(a => a.Category)
				.WithMany(a => a.ProductCategories)
				.HasForeignKey(a => a.CategoryId)
				.OnDelete(DeleteBehavior.Cascade);
			
			modelBuilder.Entity<ProductContent>()
				.ToTable("ProductContent")
				.HasKey(a => new
				{
					a.ProductId,
					a.ContentId
				});
			modelBuilder.Entity<ProductContent>()
				.HasOne<Product>(a => a.Product)
				.WithMany(a => a.ProductContents)
				.HasForeignKey(a => a.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<ProductContent>()
				.HasOne<Content>(a => a.Content)
				.WithMany(a => a.ProductContents)
				.HasForeignKey(a => a.ContentId)
				.OnDelete(DeleteBehavior.Cascade);


			modelBuilder.Entity<UserAllergy>()
				.ToTable("UserAllergy")
				.HasKey(a => new
				{
					a.UserId,
					a.ProductId
				});
			modelBuilder.Entity<UserAllergy>()
				.HasOne<User>(a => a.User)
				.WithMany(a => a.UserAllergies)
				.HasForeignKey(a => a.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<UserAllergy>()
				.HasOne<Product>(a => a.Product)
				.WithMany(a => a.UserAllergies)
				.HasForeignKey(a => a.ProductId)
				.OnDelete(DeleteBehavior.Cascade);


			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<ProductContent> ProductContents { get; set; }
		public DbSet<UserAllergy> UserAllergies { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Content> Contents { get; set; }
	}
}
