// <auto-generated />
using System;
using MAVN.Service.Credentials.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.Credentials.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CredentialsContext))]
    [Migration("20190730082229_AddPartnerCredentialsEntity")]
    partial class AddPartnerCredentialsEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("credentials")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.Credentials.MsSqlRepositories.Entities.CustomerCredentialsEntity", b =>
                {
                    b.Property<string>("Login")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("login");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("hash");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnName("salt");

                    b.HasKey("Login");

                    b.ToTable("customer_credentials");
                });

            modelBuilder.Entity("MAVN.Service.Credentials.MsSqlRepositories.Entities.PartnerCredentialsEntity", b =>
                {
                    b.Property<string>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("client_id");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("hash");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnName("salt");

                    b.HasKey("ClientId");

                    b.ToTable("partner_credentials");
                });

            modelBuilder.Entity("MAVN.Service.Credentials.MsSqlRepositories.Entities.PasswordResetEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnName("expires_at");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnName("identifier");

                    b.HasKey("CustomerId");

                    b.ToTable("password_reset");
                });
#pragma warning restore 612, 618
        }
    }
}
