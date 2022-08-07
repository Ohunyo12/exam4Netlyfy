using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data
{
    public class    SeedHandler
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            //Check if the database is populated
            if (!context.Customers.Any())
            {
                //Create Sample Data
                context.Customers.Add(new Customer
                {
                    FirstName = "Alexander",
                    LastName = "Okunrinkoya",
                    Address = "Egbeda, Lagoos",
                    PhoneNumber = "08125758383",
                    Email = "ohunayoalexander@gmail.com",
                    BirthDate = DateTime.Now.AddYears(-2),
                    Gender = GenderEnum.Male,
                    Active = true
                });

                context.Customers.Add(new Customer
                {
                    FirstName = "OluwaSeyi",
                    LastName = "Dipeolu",
                    Address = "Egbeda, Lagoos",
                    PhoneNumber = "08035708281",
                    Email = "christianatokz@gmail.com",
                    BirthDate = DateTime.Now.AddYears(-28),
                    Gender = GenderEnum.Female,
                    Active = false
                });
                await context.SaveChangesAsync();
            }

            if (!context.Countries.Any())
            {
                context.Countries.AddRange(new List<Country>
                {
                 new Country {Names="Afganisthan",IsoCode="AFG",CallCode="004"},
                 new Country {Names="Aland Islands",IsoCode="ALA",CallCode="248"},
                 new Country {Names="Albania",IsoCode="ALB",CallCode="008"}
                });
                await context.SaveChangesAsync();
            }

            if (!context.Languages.Any())
            {
                context.Languages.AddRange(new List<Language>
                {
                 new Language {LanguageName="Yoruba"},
                  new Language {LanguageName="Igbo"},
                  new Language {LanguageName="Hausa"}
                });
                await context.SaveChangesAsync();

            }
        }
    }
}

