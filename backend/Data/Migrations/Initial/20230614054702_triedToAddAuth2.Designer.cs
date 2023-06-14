﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend.Data.Migrations.Initial
{
    [DbContext(typeof(AuthContext))]
    [Migration("20230614054702_triedToAddAuth2")]
    partial class triedToAddAuth2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.Armour", b =>
                {
                    b.Property<int>("armourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("armourId"));

                    b.Property<string>("flavourText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("magicalDefenceValue")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("physicalDefenceValue")
                        .HasColumnType("int");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.HasKey("armourId");

                    b.ToTable("Armour");

                    b.HasData(
                        new
                        {
                            armourId = 1,
                            flavourText = "Strong plate armour capable of withstanding strong physical blows.",
                            imgURL = "T3vSkoI",
                            magicalDefenceValue = 230,
                            name = "Platemail of the Sturdy Soldier",
                            physicalDefenceValue = 690,
                            price = 680
                        },
                        new
                        {
                            armourId = 2,
                            flavourText = "Robes imbued with magical wards to boost both magical offense and defense.",
                            imgURL = "S6MLT0P",
                            magicalDefenceValue = 550,
                            name = "Robe of the Wizened Wizard",
                            physicalDefenceValue = 190,
                            price = 700
                        },
                        new
                        {
                            armourId = 3,
                            flavourText = "Flexible armour allowing freedom of movement for quick strikes while providing a balanced defense.",
                            imgURL = "GDE6NHc",
                            magicalDefenceValue = 390,
                            name = "Leather armour of the Dextrous Striker",
                            physicalDefenceValue = 430,
                            price = 650
                        });
                });

            modelBuilder.Entity("backend.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "admin"
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("backend.Models.Potion", b =>
                {
                    b.Property<int>("potionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("potionId"));

                    b.Property<string>("imgURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("potionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("potionPotencyValue")
                        .HasColumnType("int");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.HasKey("potionId");

                    b.ToTable("Potion");

                    b.HasData(
                        new
                        {
                            potionId = 1,
                            imgURL = "BtFkFWn",
                            name = "Minor Health Potion",
                            potionDescription = "Drink to restore a small amount of health, Heal potency: ",
                            potionPotencyValue = 75,
                            price = 20
                        },
                        new
                        {
                            potionId = 2,
                            imgURL = "hQU0HQG",
                            name = "Health Potion",
                            potionDescription = "Drink to restore a medium amount of health, Heal potency: ",
                            potionPotencyValue = 150,
                            price = 70
                        },
                        new
                        {
                            potionId = 3,
                            imgURL = "hOL3mew",
                            name = "Major Health Potion",
                            potionDescription = "Drink to restore a large amount of health, Heal potency: ",
                            potionPotencyValue = 250,
                            price = 200
                        },
                        new
                        {
                            potionId = 4,
                            imgURL = "OBV95Xr",
                            name = "Minor Strength Potion",
                            potionDescription = "Drink boost your strength a small amount, Boost potency: ",
                            potionPotencyValue = 75,
                            price = 20
                        },
                        new
                        {
                            potionId = 5,
                            imgURL = "lajwEJd",
                            name = "Strength Potion",
                            potionDescription = "Drink boost your strength a medium amount, Boost potency: ",
                            potionPotencyValue = 150,
                            price = 70
                        },
                        new
                        {
                            potionId = 6,
                            imgURL = "ZwNIHHE",
                            name = "Major Strength Potion",
                            potionDescription = "Drink boost your strength a large amount, Boost potency: ",
                            potionPotencyValue = 250,
                            price = 200
                        },
                        new
                        {
                            potionId = 7,
                            imgURL = "RCosYt9",
                            name = "Minor Intellect Potion",
                            potionDescription = "Drink boost your intelligence a small amount, Boost potency: ",
                            potionPotencyValue = 75,
                            price = 20
                        },
                        new
                        {
                            potionId = 8,
                            imgURL = "MEUkEX7",
                            name = "Intellect Potion",
                            potionDescription = "Drink boost your intelligence a medium amount, Boost potency: ",
                            potionPotencyValue = 150,
                            price = 70
                        },
                        new
                        {
                            potionId = 9,
                            imgURL = "5JKaqbG",
                            name = "Major Intellect Potion",
                            potionDescription = "Drink boost your intelligence a large amount, Boost potency: ",
                            potionPotencyValue = 250,
                            price = 200
                        },
                        new
                        {
                            potionId = 10,
                            imgURL = "TC4TKiW",
                            name = "Minor Dextrous Potion",
                            potionDescription = "Drink boost your dexterity a small amount, Boost potency: ",
                            potionPotencyValue = 75,
                            price = 20
                        },
                        new
                        {
                            potionId = 11,
                            imgURL = "teGVnVo",
                            name = "Dextrous Potion",
                            potionDescription = "Drink boost your dexterity a medium amount, Boost potency: ",
                            potionPotencyValue = 150,
                            price = 70
                        },
                        new
                        {
                            potionId = 12,
                            imgURL = "Mu7z0Dq",
                            name = "Major Dextrous Potion",
                            potionDescription = "Drink boost your dexterity a large amount, Boost potency: ",
                            potionPotencyValue = 250,
                            price = 200
                        });
                });

            modelBuilder.Entity("backend.Models.SuperSecureImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SuperSecureImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Image 1",
                            Size = 100000,
                            Url = "http://localhost:5000/thiswontwork"
                        });
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.admin",
                            Password = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user@user.user",
                            Password = "user"
                        });
                });

            modelBuilder.Entity("backend.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GroupId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            GroupId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("backend.Models.Weapon", b =>
                {
                    b.Property<int>("weaponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("weaponId"));

                    b.Property<double?>("abilityDamageModifier")
                        .HasColumnType("float");

                    b.Property<double?>("attackSpeed")
                        .HasColumnType("float");

                    b.Property<int?>("attackValue")
                        .HasColumnType("int");

                    b.Property<double?>("dps")
                        .HasColumnType("float");

                    b.Property<string>("flavourText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.HasKey("weaponId");

                    b.ToTable("Weapon");

                    b.HasData(
                        new
                        {
                            weaponId = 1,
                            abilityDamageModifier = 140.0,
                            attackSpeed = 1.6499999999999999,
                            attackValue = 170,
                            dps = 280.5,
                            flavourText = "Sword forged in imitation of the sword of the late king and traitor, Augustus, VII",
                            imgURL = "HXe6HWw",
                            name = "Faux sword of the late kings deceit",
                            price = 650
                        },
                        new
                        {
                            weaponId = 2,
                            abilityDamageModifier = 170.0,
                            attackSpeed = 1.1000000000000001,
                            attackValue = 220,
                            dps = 242.00000000000003,
                            flavourText = "A monstrous mace with the power to shatter shields and cave in skulls.",
                            imgURL = "DJjnBts",
                            name = "Mace of sundering",
                            price = 400
                        },
                        new
                        {
                            weaponId = 3,
                            abilityDamageModifier = 160.0,
                            attackSpeed = 2.5,
                            attackValue = 75,
                            dps = 187.5,
                            flavourText = "Twin curved daggers build for attacking quickly from the shadows.",
                            imgURL = "yHx2Lc5",
                            name = "Dagger of the twin serpents",
                            price = 250
                        },
                        new
                        {
                            weaponId = 4,
                            abilityDamageModifier = 290.0,
                            attackSpeed = 0.75,
                            attackValue = 50,
                            dps = 37.5,
                            flavourText = "Staff imbued with a medium amount of arcane power, ideal for students studying the magical arts",
                            imgURL = "",
                            name = "Arcane apprentice staff",
                            price = 700
                        },
                        new
                        {
                            weaponId = 5,
                            abilityDamageModifier = 600.0,
                            attackSpeed = 0.5,
                            attackValue = 70,
                            dps = 35.0,
                            flavourText = "Staff imbued with a large amount of destructive fire magic, dangerous in the hands of an unskilled wizard, deadly in the hands of a skilled one.",
                            imgURL = "",
                            name = "Staff of destructive oblivion",
                            price = 2900
                        });
                });

            modelBuilder.Entity("backend.Models.UserGroup", b =>
                {
                    b.HasOne("backend.Models.Group", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("backend.Models.Group", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
