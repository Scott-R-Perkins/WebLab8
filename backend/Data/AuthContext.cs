using Microsoft.EntityFrameworkCore;
using backend.Models;

public class AuthContext : DbContext
{
  public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }

  public DbSet<User> Users { get; set; } = default!;
  public DbSet<Group> Groups { get; set; } = default!;
  public DbSet<UserGroup> UserGroups { get; set; } = default!;
  public DbSet<SuperSecureImage> SuperSecureImages { get; set; } = default!;
  public DbSet<Weapon> Weapon { get; set; } = default!;
  public DbSet<Armour> Armour { get; set; } = default!;
  public DbSet<Potion> Potion { get; set; } = default!;
  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<User>().HasData(new User
    {
      Id = 1,
      Email = "Scott",
      Password = "admin"
    },
    new User
    {
      Id = 2,
      Email = "Jeff",
      Password = "user"
    });

    builder.Entity<Group>().HasData(
        new Group
        {
          GroupId = 1,
          Name = "admin"
        },
        new Group
        {
          GroupId = 2,
          Name = "user"
        }
    );

    builder.Entity<UserGroup>().HasData(
        new UserGroup
        {
          Id = 1,
          UserId = 1,
          GroupId = 1
        },
        new UserGroup
        {
          Id = 2,
          UserId = 2,
          GroupId = 2
        }
    );
    builder.Entity<SuperSecureImage>().HasData(
        new SuperSecureImage
        {
          Id = 1,
          Name = "Image 1",
          Size = 100000,
          Url = "http://localhost:5000/thiswontwork"
        }
    );
    builder.Entity<Weapon>().HasData(
            new Weapon(){
                weaponId = 1,
                name = "Faux sword of the late kings deceit",
                attackValue = 170,
                attackSpeed = 1.65,
                dps = 170 * 1.65,
                abilityDamageModifier = 140,
                flavourText = "Sword forged in imitation of the sword of the late king and traitor, Augustus, VII",
                price = 650,
                imgURL = "HXe6HWw"
            },
            new Weapon(){
                weaponId = 2,
                name = "Mace of sundering",
                attackValue = 220,
                attackSpeed = 1.10,
                dps = 220 * 1.10,
                abilityDamageModifier = 170,
                flavourText = "A monstrous mace with the power to shatter shields and cave in skulls.",
                price = 400,
                imgURL = "DJjnBts"
            },
            new Weapon(){
                weaponId = 3,
                name = "Dagger of the twin serpents",
                attackValue = 75,
                attackSpeed = 2.5,
                dps = 75 * 2.5,
                abilityDamageModifier = 160,
                flavourText = "Twin curved daggers build for attacking quickly from the shadows.",
                price = 250,
                imgURL = "yHx2Lc5"
            },
            new Weapon(){
                weaponId = 8,
                name = "Arcane apprentice staff",
                attackValue = 50,
                attackSpeed = 0.75,
                dps = 50 * 0.75,
                abilityDamageModifier = 290,
                flavourText = "Staff imbued with a medium amount of arcane power, ideal for students studying the magical arts",
                price = 700,
                imgURL = "Y5tHLvN"
            },
            new Weapon(){
                weaponId = 9,
                name = "Staff of destructive oblivion",
                attackValue = 70,
                attackSpeed = 0.50,
                dps = 70 * 0.50,
                abilityDamageModifier = 600,
                flavourText = "Staff imbued with a large amount of destructive fire magic, dangerous in the hands of an unskilled wizard, deadly in the hands of a skilled one.",
                price = 2900,
                imgURL = "mQbqS1A"
            }
        );
        builder.Entity<Armour>().HasData(
            new Armour(){
                armourId = 1,
                name = "Platemail of the Sturdy Soldier", 
                physicalDefenceValue = 690,
                magicalDefenceValue = 230,
                flavourText = "Strong plate armour capable of withstanding strong physical blows.",
                price = 680,
                imgURL = "T3vSkoI"
            },
            new Armour(){
                armourId = 2,
                name = "Robe of the Wizened Wizard", 
                physicalDefenceValue = 190,
                magicalDefenceValue = 550,
                flavourText = "Robes imbued with magical wards to boost both magical offense and defense.",
                price = 700,
                imgURL = "S6MLT0P"
            },
            new Armour(){
                armourId = 3,
                name = "Leather armour of the Dextrous Striker", 
                physicalDefenceValue = 430,
                magicalDefenceValue = 390,
                flavourText = "Flexible armour allowing freedom of movement for quick strikes while providing a balanced defense.",
                price = 650,
                imgURL = "GDE6NHc"
            }
        );
        builder.Entity<Potion>().HasData(
            new Potion(){
                potionId = 1,
                name = "Minor Health Potion",
                potionDescription = "Drink to restore a small amount of health, Heal potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = "BtFkFWn"
            },
            new Potion(){
                potionId = 2,
                name = "Health Potion",
                potionDescription = "Drink to restore a medium amount of health, Heal potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = "hQU0HQG"
            },
            new Potion(){
                potionId = 3,
                name = "Major Health Potion",
                potionDescription = "Drink to restore a large amount of health, Heal potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = "hOL3mew"
            },
            new Potion(){
                potionId = 4,
                name = "Minor Strength Potion",
                potionDescription = "Drink boost your strength a small amount, Boost potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = "OBV95Xr"
            },
            new Potion(){
                potionId = 5,
                name = "Strength Potion",
                potionDescription = "Drink boost your strength a medium amount, Boost potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = "lajwEJd"
            },
            new Potion(){
                potionId = 6,
                name = "Major Strength Potion",
                potionDescription = "Drink boost your strength a large amount, Boost potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = "ZwNIHHE"
            },
            new Potion(){
                potionId = 7,
                name = "Minor Intellect Potion",
                potionDescription = "Drink boost your intelligence a small amount, Boost potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = "RCosYt9"
            },
            new Potion(){
                potionId = 8,
                name = "Intellect Potion",
                potionDescription = "Drink boost your intelligence a medium amount, Boost potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = "MEUkEX7"
            },
            new Potion(){
                potionId = 9,
                name = "Major Intellect Potion",
                potionDescription = "Drink boost your intelligence a large amount, Boost potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = "5JKaqbG"
            },
            new Potion(){
                potionId = 10,
                name = "Minor Dextrous Potion",
                potionDescription = "Drink boost your dexterity a small amount, Boost potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = "TC4TKiW"
            },
            new Potion(){
                potionId = 11,
                name = "Dextrous Potion",
                potionDescription = "Drink boost your dexterity a medium amount, Boost potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = "teGVnVo"
            },
            new Potion(){
                potionId = 12,
                name = "Major Dextrous Potion",
                potionDescription = "Drink boost your dexterity a large amount, Boost potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = "Mu7z0Dq"
            }
        );
  }


}
