﻿// <auto-generated />
using System;
using BankAppSample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankAppSample.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20190909160044_BankDb1")]
    partial class BankDb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankAppSample.UserRegistration", b =>
                {
                    b.Property<int>("RegistrationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RegistrationID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AccountNumber")
                        .HasColumnName("AccountNumber");

                    b.Property<int>("Age")
                        .HasColumnName("Age")
                        .HasMaxLength(4);

                    b.Property<decimal>("Balance")
                        .HasColumnName("Balance");

                    b.Property<string>("Dateofbirth")
                        .IsRequired()
                        .HasColumnName("Dateofbirth");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnName("FatherName")
                        .HasMaxLength(35);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("FullName")
                        .HasMaxLength(35);

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnName("MobileNumber")
                        .HasMaxLength(10);

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnName("MotherName")
                        .HasMaxLength(35);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasMaxLength(16);

                    b.Property<string>("PermanentAddress")
                        .IsRequired()
                        .HasColumnName("PermanemtAddress")
                        .HasMaxLength(150);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("UserName")
                        .HasMaxLength(20);

                    b.HasKey("RegistrationID");

                    b.ToTable("UserRegistrations");
                });

            modelBuilder.Entity("BankAppSample.UserTransactions", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolderName");

                    b.Property<long>("AccountNumber");

                    b.Property<decimal>("AvailBal");

                    b.Property<DateTime>("DateofTransaction");

                    b.Property<decimal>("DepositAmount");

                    b.Property<int>("RegistrationID");

                    b.Property<decimal>("WithdrawAmount");

                    b.HasKey("TransactionId");

                    b.HasIndex("RegistrationID");

                    b.ToTable("UserTransaction");
                });

            modelBuilder.Entity("BankAppSample.UserTransactions", b =>
                {
                    b.HasOne("BankAppSample.UserRegistration", "RegistrationInfo")
                        .WithMany()
                        .HasForeignKey("RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
