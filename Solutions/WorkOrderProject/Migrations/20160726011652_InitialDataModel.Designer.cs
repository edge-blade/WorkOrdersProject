using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DomainProject;

namespace WorkOrderProject.Migrations
{
    [DbContext(typeof(WorkOrderDbContext))]
    [Migration("20160726011652_InitialDataModel")]
    partial class InitialDataModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainProject.DomainObjects.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("DomainProject.DomainObjects.ClientLocation", b =>
                {
                    b.Property<int>("ClientLocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressOne");

                    b.Property<string>("AddressTwo");

                    b.Property<string>("City");

                    b.Property<int?>("ClientId");

                    b.Property<string>("State");

                    b.Property<string>("ZipCode");

                    b.HasKey("ClientLocationId");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientLocations");
                });

            modelBuilder.Entity("DomainProject.DomainObjects.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DomainProject.DomainObjects.ClientLocation", b =>
                {
                    b.HasOne("DomainProject.DomainObjects.Client", "Client")
                        .WithMany("ClientLocations")
                        .HasForeignKey("ClientId");
                });
        }
    }
}
