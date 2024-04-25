using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace APAM.Common
{
    public static class DataSeeder
    {
        public static readonly string ADDRESSES_RESOURCES_PATH = "APAM.Resources";

        public static void Seed(APAM_DBEntities context)
        {
            var random = new Random();

            var names = new string[] {
    "Rachel"
    ,
    "Vernon"
    ,
    "Libby"
    ,
    "Anastasia"
    ,
    "Marny"
    ,
    "Katell"
    ,
    "Sawyer"
    ,
    "Carolyn"
    ,
    "Amal"
    ,
    "Josiah"
    ,
    "Uriah"
    ,
    "Ira"
    ,
    "Venus"
    ,
    "Dennis"
    ,
    "Nero"
    ,
    "Garrett"
    ,
    "Aimee"
    ,
    "Travis"
    ,
    "Indira"
    ,
    "Angela"
    ,
    "Whilemina"
    ,
    "Vielka"
    ,
    "Madeson"
    ,
    "Camille"
    ,
    "Reece"
    ,
    "Vera"
    ,
    "Robin"
    ,
    "Christian"
    ,
    "Francis"
    ,
    "Yoshi"
    ,
    "Price"
    ,
    "Rina"
    ,
    "Wade"
    ,
    "Amethyst"
    ,
    "Dominique"
    ,
    "Demetria"
    ,
    "Cassidy"
    ,
    "Jade"
    ,
    "Keaton"
    ,
    "Lee"
    ,
    "Preston"
    ,
    "Celeste"
    ,
    "Jacob"
    ,
    "Claire"
    ,
    "Aquila"
    ,
    "Kasper"
    ,
    "Xander"
    ,
    "Illana"
    ,
    "Guinevere"
    ,
    "Meredith"
    ,
    "Bernard"
    ,
    "Martin"
    ,
    "Jolie"
    ,
    "Gabriel"
    ,
    "Mason"
    ,
    "Harlan"
    ,
    "Susan"
    ,
    "Catherine"
    ,
    "Flynn"
    ,
    "Orson"
    ,
    "Rhea"
    ,
    "Naida"
    ,
    "Alfreda"
    ,
    "Salvador"
    ,
    "Ina"
    ,
    "Jared"
    ,
    "Rosalyn"
    ,
    "Alfonso"
    ,
    "Tallulah"
    ,
    "Brody"
    ,
    "Christopher"
    ,
    "Dieter"
    ,
    "Ira"
    ,
    "Alec"
    ,
    "Solomon"
    ,
    "Colleen"
    ,
    "Kylan"
    ,
    "Shellie"
    ,
    "Xantha"
    ,
    "Elmo"
    ,
    "Harlan"
    ,
    "Lael"
    ,
    "Elliott"
    ,
    "Benedict"
    ,
    "Halla"
    ,
    "Baxter"
    ,
    "Hilel"
    ,
    "Oliver"
    ,
    "Zachery"
    ,
    "Galena"
    ,
    "Daphne"
    ,
    "Jacob"
    ,
    "Cassady"
    ,
    "Jasmine"
    ,
    "Ian"
    ,
    "Quin"
    ,
    "Simon"
    ,
    "McKenzie"
    ,
    "George"
    ,
    "Destiny"
};
            var surnames = new string[] {
    "Dorsey"
    ,
    "Moran"
    ,
    "Hood"
    ,
    "Hobbs"
    ,
    "Terry"
    ,
    "Flowers"
    ,
    "Castro"
    ,
    "Strong"
    ,
    "Goodman"
    ,
    "Blankenship"
    ,
    "Rutledge"
    ,
    "Gates"
    ,
    "Ballard"
    ,
    "Crosby"
    ,
    "Flowers"
    ,
    "Kaufman"
    ,
    "Hickman"
    ,
    "Saunders"
    ,
    "Rasmussen"
    ,
    "Jackson"
    ,
    "Cain"
    ,
    "Lester"
    ,
    "Cannon"
    ,
    "Pugh"
    ,
    "Conrad"
    ,
    "Bonner"
    ,
    "Evans"
    ,
    "Terry"
    ,
    "Ferrell"
    ,
    "Scott"
    ,
    "Glover"
    ,
    "Fowler"
    ,
    "George"
    ,
    "Holland"
    ,
    "Fernandez"
    ,
    "Hopkins"
    ,
    "Conley"
    ,
    "Slater"
    ,
    "Cervantes"
    ,
    "Osborne"
    ,
    "Shaffer"
    ,
    "Murphy"
    ,
    "Reed"
    ,
    "Sutton"
    ,
    "Peters"
    ,
    "Pratt"
    ,
    "Lambert"
    ,
    "Aguirre"
    ,
    "Hurst"
    ,
    "Price"
    ,
    "Mills"
    ,
    "Downs"
    ,
    "Landry"
    ,
    "Holt"
    ,
    "Gardner"
    ,
    "Whitney"
    ,
    "Brewer"
    ,
    "Blankenship"
    ,
    "Crosby"
    ,
    "Terry"
    ,
    "Forbes"
    ,
    "Delaney"
    ,
    "Mcmahon"
    ,
    "Whitaker"
    ,
    "Cooley"
    ,
    "Mercado"
    ,
    "Cannon"
    ,
    "Bailey"
    ,
    "Briggs"
    ,
    "Dale"
    ,
    "Maddox"
    ,
    "Vargas"
    ,
    "Finch"
    ,
    "Holder"
    ,
    "Coleman"
    ,
    "Klein"
    ,
    "Flowers"
    ,
    "Gentry"
    ,
    "Harvey"
    ,
    "Adams"
    ,
    "Garcia"
    ,
    "Buck"
    ,
    "Norris"
    ,
    "Stafford"
    ,
    "Cole"
    ,
    "Wong"
    ,
    "Bean"
    ,
    "Lindsey"
    ,
    "Ruiz"
    ,
    "Terry"
    ,
    "Johnson"
    ,
    "Alvarez"
    ,
    "Livingston"
    ,
    "Fletcher"
    ,
    "Ortega"
    ,
    "Knight"
    ,
    "Justice"
    ,
    "Cannon"
    ,
    "Patterson"
    ,
    "Neal"
};
            var middleNames = new string[] {
    "Elliott"
    ,
    "Carson"
    ,
    "Colt"
    ,
    "Brody"
    ,
    "Kasimir"
    ,
    "Ethan"
    ,
    "Arsenio"
    ,
    "Cameron"
    ,
    "Reece"
    ,
    "Amir"
    ,
    "Acton"
    ,
    "Jasper"
    ,
    "Tobias"
    ,
    "Ray"
    ,
    "William"
    ,
    "Charles"
    ,
    "Bradley"
    ,
    "Martin"
    ,
    "Burton"
    ,
    "Daquan"
    ,
    "Vance"
    ,
    "Drew"
    ,
    "Norman"
    ,
    "Myles"
    ,
    "Walter"
    ,
    "Hilel"
    ,
    "Wayne"
    ,
    "Xander"
    ,
    "Thor"
    ,
    "Ali"
    ,
    "Quentin"
    ,
    "Basil"
    ,
    "Vernon"
    ,
    "Jason"
    ,
    "Reed"
    ,
    "Brock"
    ,
    "Joshua"
    ,
    "Simon"
    ,
    "Evan"
    ,
    "Vance"
    ,
    "Jackson"
    ,
    "Keith"
    ,
    "Lee"
    ,
    "Colin"
    ,
    "Preston"
    ,
    "Steven"
    ,
    "Cullen"
    ,
    "Christian"
    ,
    "Ferdinand"
    ,
    "Kelly"
    ,
    "Brandon"
    ,
    "Kenyon"
    ,
    "Jin"
    ,
    "Cyrus"
    ,
    "Grant"
    ,
    "Aaron"
    ,
    "Kermit"
    ,
    "Asher"
    ,
    "Alvin"
    ,
    "Alan"
    ,
    "Phelan"
    ,
    "Tanner"
    ,
    "Boris"
    ,
    "Maxwell"
    ,
    "Timothy"
    ,
    "Chaim"
    ,
    "Caldwell"
    ,
    "Tanek"
    ,
    "Forrest"
    ,
    "Uriah"
    ,
    "Dale"
    ,
    "Howard"
    ,
    "Hector"
    ,
    "Randall"
    ,
    "Evan"
    ,
    "Ciaran"
    ,
    "Sylvester"
    ,
    "Gregory"
    ,
    "Chadwick"
    ,
    "Zahir"
    ,
    "Cooper"
    ,
    "Lester"
    ,
    "Ralph"
    ,
    "Nathan"
    ,
    "Carter"
    ,
    "Gray"
    ,
    "Nolan"
    ,
    "Josiah"
    ,
    "Ulysses"
    ,
    "Prescott"
    ,
    "Austin"
    ,
    "Porter"
    ,
    "Malik"
    ,
    "Price"
    ,
    "Adrian"
    ,
    "Micah"
    ,
    "Stephen"
    ,
    "Addison"
    ,
    "Daniel"
    ,
    "Bradley"
};

            if (!context.Addresses.Any())
            {
                var list = JsonConvert.DeserializeObject<List<Address>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "Addresses.json"));

                foreach (var newItem in list)
                {
                    try
                    {
                        context.Addresses.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception) { }
                }
            }

            if (!context.AutoPartCarModels.Any())
            {
                var list = JsonConvert.DeserializeObject<List<AutoPartCarModel>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "AutoPartCarModels.json"));

                foreach (var newItem in list)
                {
                    try
                    {
                        context.AutoPartCarModels.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception) { }
                }
            }

            if (!context.AutoPartCategories.Any())
            {
                var list = JsonConvert.DeserializeObject<List<AutoPartCategory>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "AutoPartCategories.json"));

                foreach (var newItem in list)
                {
                    try
                    {
                        context.AutoPartCategories.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception) { }
                }
            }

            if (!context.AutoPartManufacturers.Any())
            {
                var list = JsonConvert.DeserializeObject<List<AutoPartManufacturer>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "AutoPartManufacturers.json"));

                foreach (var newItem in list)
                {
                    try
                    {
                        context.AutoPartManufacturers.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception) { }
                }
            }

            if (!context.AutoParts.Any())
            {
                for (int i = 0; i < 1000; ++i)
                {
                    var newItem = new AutoPart
                    {
                        AutoPartCarModelId = context.AutoPartCarModels.ToList().ElementAt(random.Next(context.AutoPartCarModels.Count())).AutoPartCarModelId,
                        AutoPartCategoryId = context.AutoPartCategories.ToList().ElementAt(random.Next(context.AutoPartCategories.Count())).AutoPartCategoryId,
                        AutoPartManufacturerId = context.AutoPartManufacturers.ToList().ElementAt(random.Next(context.AutoPartManufacturers.Count())).AutoPartManufacturerId,
                        Article = (Math.Abs(Guid.NewGuid().GetHashCode())).ToString(),
                        ManufacturerPartCode = (Math.Abs(Guid.NewGuid().GetHashCode())).ToString(),
                        Cost = random.Next(100, 1000000)
                    };

                    try
                    {
                        context.AutoParts.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        --i;
                    }
                }

            }

            if (!context.ContactTypes.Any())
            {
                var list = new List<ContactType>
                {
                    new ContactType {Type = "Phone"},
                    new ContactType {Type = "Email"},
                    new ContactType {Type = "Telegram"},
                    new ContactType {Type = "Viber"},
                };

                context.ContactTypes.AddRange(list);
                context.SaveChanges();
            }

            if (!context.AdministratorTypes.Any())
            {
                var list = new List<AdministratorType>
                {
                    new AdministratorType {Type = "Database Admin"},
                    new AdministratorType {Type = "System Admin"},
                    new AdministratorType {Type = "Manager Admin"},
                };

                context.AdministratorTypes.AddRange(list);
                context.SaveChanges();
            }

            if (!context.OrderStatus.Any())
            {
                var list = new List<OrderStatu>
                {
                    new OrderStatu {Status = "Created"},
                    new OrderStatu {Status = "Сonfirmed"},
                    new OrderStatu {Status = "Denied"},
                    new OrderStatu {Status = "Shipping"},
                    new OrderStatu {Status = "Finished"},
                };

                context.OrderStatus.AddRange(list);
                context.SaveChanges();
            }

            if (!context.Administrators.Any())
            {
                for (int i = 0; i < 10; ++i)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < context.AdministratorTypes.ToList().Count; ++j)
                        {
                            var newItem = new Administrator
                            {
                                Name = names[random.Next(names.Length)],
                                Surname = surnames[random.Next(surnames.Length)],
                                MiddleName = middleNames[random.Next(surnames.Length)],
                                AdministratorTypeId = context.AdministratorTypes.ToList().ElementAt(j).AdministratorTypeId,
                            };

                            try
                            {
                                context.Administrators.Add(newItem);
                                context.SaveChanges();
                            }
                            catch (Exception) { }

                            Thread.Sleep(5);
                        }
                    }
                    else
                    {

                        var newItem = new Administrator
                        {
                            Name = names[random.Next(names.Length)],
                            Surname = surnames[random.Next(surnames.Length)],
                            MiddleName = middleNames[random.Next(surnames.Length)],
                            AdministratorTypeId = context.AdministratorTypes.ToList().ElementAt(random.Next(context.AdministratorTypes.Count())).AdministratorTypeId,
                        };

                        try
                        {
                            context.Administrators.Add(newItem);
                            context.SaveChanges();
                        }
                        catch (Exception) { }

                        Thread.Sleep(5);
                    }
                }
            }

            if (!context.Bookkeepers.Any())
            {
                for (int i = 0; i < 20; ++i)
                {
                    var newItem = new Bookkeeper
                    {
                        Name = names[random.Next(names.Length)],
                        Surname = surnames[random.Next(surnames.Length)],
                        MiddleName = middleNames[random.Next(surnames.Length)],
                    };

                    try
                    {
                        context.Bookkeepers.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception) { }

                    Thread.Sleep(5);
                }
            }

            if (!context.Sellers.Any())
            {
                for (int i = 0; i < 40; ++i)
                {
                    var newItem = new Seller
                    {
                        Name = names[random.Next(names.Length)],
                        Surname = surnames[random.Next(surnames.Length)],
                        MiddleName = middleNames[random.Next(surnames.Length)],
                    };

                    try
                    {
                        context.Sellers.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception) { }

                    Thread.Sleep(5);
                }
            }

            if (!context.Customers.Any())
            {
                for (int i = 0; i < 100; ++i)
                {
                    var newItem = new Customer
                    {
                        Name = names[random.Next(names.Length)],
                        Surname = surnames[random.Next(surnames.Length)],
                        MiddleName = middleNames[random.Next(surnames.Length)],
                        BirthDate = GetRandomDay(10000)
                    };

                    try
                    {
                        context.Customers.Add(newItem);
                        context.SaveChanges();
                    }
                    catch (Exception) { }

                    Thread.Sleep(5);
                }
            }


        }

        private static string GetEmbeddedResource(string namespacename, string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = namespacename + "." + filename;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return result;
            }
        }

        private static DateTime GetRandomDay(int dayMinusRange)
        {
            var random = new Random();
            DateTime start = DateTime.Now;
            return start.AddDays(-random.Next(dayMinusRange));
        }
    }
}
