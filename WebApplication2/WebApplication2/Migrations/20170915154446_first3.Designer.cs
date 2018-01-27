﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ClientContext))]
    [Migration("20170915154446_first3")]
    partial class first3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CliNom");

                    b.Property<string>("CliPrenom");

                    b.Property<string>("CliRue");

                    b.Property<string>("CliTelephone");

                    b.Property<string>("CliVille");

                    b.Property<DateTime>("cliDateNaiss");

                    b.Property<bool>("isThere");

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });
#pragma warning restore 612, 618
        }
    }
}