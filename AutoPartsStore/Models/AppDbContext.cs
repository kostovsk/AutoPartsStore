using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
   public class AppDbContext : DbContext
   {
      public AppDbContext(DbContextOptions<AppDbContext> options) :
         base(options)
      {

      }

      public DbSet<Part> Parts { get; set; }
      public DbSet<Category> Categories { get; set; }
      public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);

         modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Brakes" });
         modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Engine" });
         modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Suspension" });
         modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Exhaust" });
         modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Air Conditioning" });

         modelBuilder.Entity<Part>().HasData(new Part { 
            PartId = 1,
            Name = "POWER STOP 16537 Z16",
            Price = 18.22M,
            Description = "Z16 Evolution Ceramic brake pads are the affordable stock replacement for your daily driven vehicle. The low dust Ceramic formula is validated through on-vehicle 3rd party tests in the USA to keep your wheels looking like new.",
            CategoryId = 1,
            ImageUrl = "https://www.rockauto.com/info/568/16-537__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/568/16-537__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 2,
            Name = "WAGNER BD126055E Black",
            Price = 32.79M,
            Description = "Wagner® E-Coat Brake rotors are engineered for maximum performance with an E-Shield® protective electro-coating applied to all non-braking surfaces. This black-colored coating prevents corrosion, makes removal for service fast and simple, and is visually attractive for open spoke wheels.",
            CategoryId = 1,
            ImageUrl = "https://www.rockauto.com/info/5/MWG_BD126055E_P04_ANG__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/5/MWG_BD126055E_P04_ANG__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 3,
            Name = "ACDELCO 18FR2479C Gold",
            Price = 137.79M,
            Description = "ACDelco Gold (Professional) Remanufactured Coated Brake Calipers feature a robotic-applied, baked-on zinc plated coating that provides superior rust prevention against harsh environmental elements such as rain, snow, and corrosive road sprays.",
            CategoryId = 1,
            ImageUrl = "https://www.rockauto.com/info/314/18FR2479C_Primary__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/314/18FR2479C_Primary__ra_p.jpg",
            IsInStock = true,
            IsOnSale = true
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 4,
            Name = "BECK/ARNLEY 1041999",
            Price = 60.79M,
            Description = "Beck/Arnley parts meet foreign nameplate OE specifications for form, fit and function. Their product specialists work with a network of global sourcing partners so you can install the right part with confidence.",
            CategoryId = 2,
            ImageUrl = "https://www.rockauto.com/info/31/BA1041999-1__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/31/BA1041999-1__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 5,
            Name = "MELLING 31035S",
            Price = 125.79M,
            Description = "Melling is a leader in engineering design, development, prototype, testing and assembly of fluid delivery products and related items for the automotive OEM industry as well as the aftermarket industry.",
            CategoryId = 2,
            ImageUrl = "https://www.rockauto.com/info/583/3-1035S-1-KIT__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/583/3-1035S-1-KIT__ra_p.jpg",
            IsInStock = true,
            IsOnSale = true
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 6,
            Name = "MELLING M532",
            Price = 180.79M,
            Description = "Melling is a leader in engineering design, development, prototype, testing and assembly of fluid delivery products and related items for the automotive OEM industry as well as the aftermarket industry.",
            CategoryId = 2,
            ImageUrl = "https://www.rockauto.com/info/583/M532-1-FRO__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/583/M532-1-FRO__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 7,
            Name = "MOOG K500069",
            Price = 28.99M,
            Description = "MOOG® products incorporate proven design and engineering features for like new steering, ease of installation and longer life. MOOG is the preferred steering and suspension brand of professional technicians and NASCAR crew chiefs.",
            CategoryId = 3,
            ImageUrl = "https://www.rockauto.com/info/11/AMG_K500069_P04_ANG__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/11/AMG_K500069_P04_ANG__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 8,
            Name = "ACDELCO 45G0452",
            Price = 19.99M,
            Description = "The ACDelco Professional Suspension Stabilizer Bar Link Kit comes with everything you need to easily install new suspension stabilizer bar links, and is a high quality replacement for many vehicles on the road today.",
            CategoryId = 3,
            ImageUrl = "https://www.rockauto.com/info/345/45G0452_Primary__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/345/45G0452_Primary__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 9,
            Name = "MONROE 172286",
            Price = 110.99M,
            Description = "Precisely calibrated to meet the OE design, each application-specific coil spring type is engineered to restore ride height and support the vehicle’s weight. Protective coating resists rust and corrosion while salt spray testing ensures it’s ready for the elements",
            CategoryId = 3,
            ImageUrl = "https://www.rockauto.com/info/904/172287__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/904/172287__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 10,
            Name = "WALKER 16448 Ultra",
            Price = 540.79M,
            Description = "Walker Ultra® Catalytic Converters are design-validated for assured fit, and provide EPA-compliant performance. Premium substrate material and a high-technology washcoat ensure exceptional oxygen storage capacity while OE expertise.",
            CategoryId = 4,
            ImageUrl = "https://www.rockauto.com/info/9/BDCN_16448_P04_FRO__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/9/BDCN_16448_P04_FRO__ra_p.jpg",
            IsInStock = true,
            IsOnSale = true
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 11,
            Name = "DELPHI EG10499",
            Price = 85.79M,
            Description = "Delphi exhaust gas recirculation (EGR) valves are a 100 percent OE line, providing an exact fit without the need for orifice washers or clocking for fast, easy installation.",
            CategoryId = 4,
            ImageUrl = "https://www.rockauto.com/info/43/EG10499K__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/43/EG10499K__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 12,
            Name = "WALKER 54668",
            Price = 92.89M,
            Description = "Walker Quiet-Flow Mufflers feature 100% Structural Stainless Steel construction to resist rust-out three times longer than competitors' premium aluminized mufflers.",
            CategoryId = 4,
            ImageUrl = "https://www.rockauto.com/info/9/BDCN_54668_P04_FRO__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/9/BDCN_54668_P04_FRO__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 13,
            Name = "DENSO 4717054",
            Price = 259.99M,
            Description = "Manufactured and tested to the strictest OE standards for unparalleled performance. OE - specified O - rings & seals are compatible with both R12 and R134a refrigerants",
            CategoryId = 5,
            ImageUrl = "https://www.rockauto.com/info/14/471-7054__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/14/471-7054__ra_p.jpg",
            IsInStock = true,
            IsOnSale = true
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 14,
            Name = "CSF 10484",
            Price = 61.79M,
            Description = "Old Refrigerant must be removed from the system in accordance with local, state, and federal laws. Replace the A / C Line O - Rings connected to the A / C Condenser to prevent a Refrigerant leak.",
            CategoryId = 5,
            ImageUrl = "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
         modelBuilder.Entity<Part>().HasData(new Part
         {
            PartId = 15,
            Name = "GPD 1411667",
            Price = 10.17M,
            Description = "Accumulators and receiver driers play an important part in the automotive air conditioning system. They are designed to hold a little extra refrigerant for hot days as well as having desiccant inside.",
            CategoryId = 5,
            ImageUrl = "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg",
            ImageThumbnailUrl = "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg",
            IsInStock = true,
            IsOnSale = false
         });
      }
   }
}
