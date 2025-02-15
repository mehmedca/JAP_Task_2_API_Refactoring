﻿// <auto-generated />
using System;
using JAP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JAP.Database.Migrations
{
    [DbContext(typeof(JAPContext))]
    [Migration("20210903155547_SeedActorsToDb")]
    partial class SeedActorsToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("JAP.Core.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedById")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DeletedById")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("DeletedByUserId")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ModifiedById")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("text");

                    b.Property<int?>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("PhotoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("DeletedByUserId");

                    b.HasIndex("ModifiedByUserId");

                    b.HasIndex("MovieId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(767),
                            FirstName = "Johnny",
                            IsDeleted = false,
                            LastName = "Depp",
                            PhotoId = -1
                        },
                        new
                        {
                            Id = -2,
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1901),
                            FirstName = "Angelina",
                            IsDeleted = false,
                            LastName = "Jolie",
                            PhotoId = -2
                        },
                        new
                        {
                            Id = -3,
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1908),
                            FirstName = "Tom",
                            IsDeleted = false,
                            LastName = "Hanks",
                            PhotoId = -3
                        },
                        new
                        {
                            Id = -4,
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1914),
                            FirstName = "Natalie",
                            IsDeleted = false,
                            LastName = "Portman",
                            PhotoId = -4
                        },
                        new
                        {
                            Id = -5,
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1920),
                            FirstName = "Scarlett",
                            IsDeleted = false,
                            LastName = "Johansson",
                            PhotoId = -5
                        },
                        new
                        {
                            Id = -6,
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1925),
                            FirstName = "Brad",
                            IsDeleted = false,
                            LastName = "Pitt",
                            PhotoId = -6
                        });
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("CreatedById")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DeletedById")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedById")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DeletedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                            ConcurrencyStamp = "72c0f2f7-f720-4669-bcce-73dd9ef792dd",
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 553, DateTimeKind.Local).AddTicks(9265),
                            IsDeleted = false,
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                            ConcurrencyStamp = "1b346682-3371-408d-ab71-264bc31a9fac",
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 553, DateTimeKind.Local).AddTicks(9663),
                            IsDeleted = false,
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                            ConcurrencyStamp = "f92bc324-e94c-4455-ba3f-3cdde6417b4f",
                            CreatedById = "rOFHG9xvlRKAdXOjUh3J",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 553, DateTimeKind.Local).AddTicks(9672),
                            IsDeleted = false,
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<DateTime>("LastOnline")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("integer");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("PhotoId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "rOFHG9xvlRKAdXOjUh3J",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "56f2f1a3-e625-4c69-b108-29009eb84195",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 537, DateTimeKind.Local).AddTicks(5925),
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LastOnline = new DateTime(2021, 9, 3, 17, 55, 46, 527, DateTimeKind.Local).AddTicks(5427),
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEIsq/bpvjKt3Q65Bq6GHWiV1m8AZTIpC3VAoazG7EGA6cN/QpvHe2iJS1OiwP8TP9g==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "pQVqvZg7tnJYQv93gme9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "743526d2-0265-4084-85ba-58487c6275dd",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 545, DateTimeKind.Local).AddTicks(2996),
                            EmailConfirmed = false,
                            FirstName = "Moderator",
                            LastName = "Moderator",
                            LastOnline = new DateTime(2021, 9, 3, 17, 55, 46, 537, DateTimeKind.Local).AddTicks(6603),
                            LockoutEnabled = false,
                            NormalizedUserName = "MODERATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEMFgAlTchAoNjKU2iL/DATJBeWTJlS6yIJmCigSfhsBjW1OQETWVsy/h9I60F3Snuw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "moderator"
                        },
                        new
                        {
                            Id = "NsOUTyrRU3CRxdPY06lP",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fa9c5387-28af-42a4-92ac-d30b2f84f310",
                            DateCreated = new DateTime(2021, 9, 3, 17, 55, 46, 552, DateTimeKind.Local).AddTicks(8172),
                            EmailConfirmed = false,
                            FirstName = "User",
                            LastName = "User",
                            LastOnline = new DateTime(2021, 9, 3, 17, 55, 46, 545, DateTimeKind.Local).AddTicks(3010),
                            LockoutEnabled = false,
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEN989qrXHFRuWOFnQMaMHxBnI79HqoIBq8IsbbqCnFLIToi0VWUkE8A0RlLEPCE6Fw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "rOFHG9xvlRKAdXOjUh3J",
                            RoleId = "8cdd8900-b5a2-41ef-bd55-2a4215f04c48"
                        },
                        new
                        {
                            UserId = "pQVqvZg7tnJYQv93gme9",
                            RoleId = "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397"
                        },
                        new
                        {
                            UserId = "NsOUTyrRU3CRxdPY06lP",
                            RoleId = "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0"
                        });
                });

            modelBuilder.Entity("JAP.Core.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedById")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DeletedById")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("DeletedByUserId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedById")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("text");

                    b.Property<int>("PhotoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("DeletedByUserId");

                    b.HasIndex("ModifiedByUserId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("JAP.Core.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            PublicId = "johnnydepp_iora25",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676131/johnnydepp_iora25.jpg"
                        },
                        new
                        {
                            Id = -2,
                            PublicId = "angelinajolie_xjbhe7",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676126/angelinajolie_xjbhe7.jpg"
                        },
                        new
                        {
                            Id = -3,
                            PublicId = "tomhanks_hva0vj",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676130/tomhanks_hva0vj.jpg"
                        },
                        new
                        {
                            Id = -4,
                            PublicId = "natalieportman_i6vuot",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676130/natalieportman_i6vuot.jpg"
                        },
                        new
                        {
                            Id = -5,
                            PublicId = "scarlettjohanson_rkcu5u",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676129/scarlettjohanson_rkcu5u.jpg"
                        },
                        new
                        {
                            Id = -6,
                            PublicId = "bradpitt_zo0pcb",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676129/bradpitt_zo0pcb.jpg"
                        },
                        new
                        {
                            Id = -7,
                            PublicId = "hitandrun_ezk6zp",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675787/hitandrun_ezk6zp.jpg"
                        },
                        new
                        {
                            Id = -8,
                            PublicId = "thegodfather_aumlac",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675787/thegodfather_aumlac.jpg"
                        },
                        new
                        {
                            Id = -9,
                            PublicId = "suicidesquad_eq8mih",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/suicidesquad_eq8mih.jpg"
                        },
                        new
                        {
                            Id = -10,
                            PublicId = "mrandmrssmith_cstx0w",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/mrandmrssmith_cstx0w.jpg"
                        },
                        new
                        {
                            Id = -11,
                            PublicId = "darkknight_uxmvzc",
                            Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/darkknight_uxmvzc.jpg"
                        });
                });

            modelBuilder.Entity("JAP.Core.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<string>("RatedById")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RatedByUserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("RatedByUserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JAP.Core.Entities.Actor", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "DeletedByUser")
                        .WithMany()
                        .HasForeignKey("DeletedByUserId");

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedByUserId");

                    b.HasOne("JAP.Core.Entities.Movie", null)
                        .WithMany("Cast")
                        .HasForeignKey("MovieId");

                    b.HasOne("JAP.Core.Entities.Photo", "ProfileImg")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("DeletedByUser");

                    b.Navigation("ModifiedByUser");

                    b.Navigation("ProfileImg");
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppRole", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "DeletedBy")
                        .WithMany()
                        .HasForeignKey("DeletedById");

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("DeletedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppUser", b =>
                {
                    b.HasOne("JAP.Core.Entities.Photo", "UserPhoto")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.Navigation("UserPhoto");
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppUserRole", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JAP.Core.Entities.Movie", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "DeletedByUser")
                        .WithMany()
                        .HasForeignKey("DeletedByUserId");

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedByUserId");

                    b.HasOne("JAP.Core.Entities.Photo", "CoverImage")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CoverImage");

                    b.Navigation("CreatedByUser");

                    b.Navigation("DeletedByUser");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("JAP.Core.Entities.Rating", b =>
                {
                    b.HasOne("JAP.Core.Entities.Movie", "RatedMovie")
                        .WithMany("MovieRatings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JAP.Core.Entities.Identity.AppUser", "RatedByUser")
                        .WithMany("UserRatings")
                        .HasForeignKey("RatedByUserId");

                    b.Navigation("RatedByUser");

                    b.Navigation("RatedMovie");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JAP.Core.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("JAP.Core.Entities.Identity.AppUser", b =>
                {
                    b.Navigation("UserRatings");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("JAP.Core.Entities.Movie", b =>
                {
                    b.Navigation("Cast");

                    b.Navigation("MovieRatings");
                });
#pragma warning restore 612, 618
        }
    }
}
