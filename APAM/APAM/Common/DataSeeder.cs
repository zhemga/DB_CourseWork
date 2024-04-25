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
            if (UserData.IsAdmin)
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
                var nickNames = new string[] {
    "ut"
    ,
    "erat"
    ,
    "magna."
    ,
    "lectus"
    ,
    "turpis"
    ,
    "dolor"
    ,
    "nonummy"
    ,
    "dis"
    ,
    "arcu."
    ,
    "sit"
    ,
    "a,"
    ,
    "mi"
    ,
    "Fusce"
    ,
    "auctor"
    ,
    "ligula."
    ,
    "sed"
    ,
    "tincidunt"
    ,
    "cursus"
    ,
    "Donec"
    ,
    "Mauris"
    ,
    "pretium"
    ,
    "nec"
    ,
    "dignissim"
    ,
    "Sed"
    ,
    "sapien"
    ,
    "semper"
    ,
    "lobortis"
    ,
    "erat"
    ,
    "bibendum"
    ,
    "quam"
    ,
    "leo"
    ,
    "eu"
    ,
    "ante"
    ,
    "porttitor"
    ,
    "purus"
    ,
    "ornare,"
    ,
    "augue"
    ,
    "tellus."
    ,
    "euismod"
    ,
    "Aliquam"
    ,
    "nec"
    ,
    "scelerisque,"
    ,
    "pellentesque"
    ,
    "Aliquam"
    ,
    "iaculis"
    ,
    "risus."
    ,
    "Fusce"
    ,
    "mauris"
    ,
    "aliquet,"
    ,
    "Integer"
    ,
    "nisl"
    ,
    "dignissim."
    ,
    "per"
    ,
    "posuere"
    ,
    "nunc"
    ,
    "quis"
    ,
    "ligula"
    ,
    "et"
    ,
    "iaculis"
    ,
    "euismod"
    ,
    "diam"
    ,
    "sodales"
    ,
    "rutrum"
    ,
    "a,"
    ,
    "purus"
    ,
    "cursus"
    ,
    "Aliquam"
    ,
    "dignissim"
    ,
    "sagittis"
    ,
    "arcu."
    ,
    "euismod"
    ,
    "massa"
    ,
    "fames"
    ,
    "quam."
    ,
    "nibh."
    ,
    "penatibus"
    ,
    "nec,"
    ,
    "semper"
    ,
    "ullamcorper."
    ,
    "tortor,"
    ,
    "odio."
    ,
    "scelerisque"
    ,
    "fermentum"
    ,
    "volutpat"
    ,
    "est"
    ,
    "et,"
    ,
    "Maecenas"
    ,
    "tincidunt,"
    ,
    "lorem"
    ,
    "Integer"
    ,
    "luctus"
    ,
    "luctus"
    ,
    "tempus,"
    ,
    "iaculis,"
    ,
    "ut"
    ,
    "eget,"
    ,
    "In"
    ,
    "auctor"
    ,
    "diam"
    ,
    "consectetuer"
};
                var phones = new string[] {
    "(068) 16161120"
    ,
    "(052) 59655137"
    ,
    "(026) 81676115"
    ,
    "(012) 78567763"
    ,
    "(026) 55166649"
    ,
    "(083) 46978212"
    ,
    "(039) 66426055"
    ,
    "(063) 23717224"
    ,
    "(098) 15775315"
    ,
    "(094) 32786415"
    ,
    "(007) 12837604"
    ,
    "(029) 65010689"
    ,
    "(068) 85186316"
    ,
    "(047) 30350583"
    ,
    "(066) 12714434"
    ,
    "(041) 16103393"
    ,
    "(016) 82951848"
    ,
    "(050) 03808167"
    ,
    "(074) 75200796"
    ,
    "(075) 25006241"
    ,
    "(087) 36741829"
    ,
    "(005) 15482462"
    ,
    "(053) 35846848"
    ,
    "(041) 15352869"
    ,
    "(042) 44626882"
    ,
    "(096) 78683326"
    ,
    "(012) 05783783"
    ,
    "(072) 34270247"
    ,
    "(030) 04621790"
    ,
    "(013) 27111508"
    ,
    "(078) 13122977"
    ,
    "(062) 29576970"
    ,
    "(063) 64219224"
    ,
    "(052) 82755544"
    ,
    "(065) 66188274"
    ,
    "(071) 92751247"
    ,
    "(062) 27335144"
    ,
    "(060) 54944475"
    ,
    "(037) 82713355"
    ,
    "(026) 87769701"
    ,
    "(090) 44788344"
    ,
    "(075) 48106679"
    ,
    "(023) 98485863"
    ,
    "(089) 23765212"
    ,
    "(071) 62263989"
    ,
    "(068) 12646624"
    ,
    "(076) 56141300"
    ,
    "(083) 27698912"
    ,
    "(063) 00598984"
    ,
    "(030) 63034322"
    ,
    "(039) 21615263"
    ,
    "(076) 08193162"
    ,
    "(054) 85411021"
    ,
    "(043) 44415393"
    ,
    "(074) 62957531"
    ,
    "(076) 11800171"
    ,
    "(068) 58894954"
    ,
    "(044) 12342187"
    ,
    "(084) 67854567"
    ,
    "(028) 46079521"
    ,
    "(048) 52164875"
    ,
    "(062) 56134228"
    ,
    "(046) 72642194"
    ,
    "(083) 15644716"
    ,
    "(072) 80292781"
    ,
    "(064) 24575550"
    ,
    "(077) 50074388"
    ,
    "(072) 24660365"
    ,
    "(085) 44444295"
    ,
    "(087) 55854339"
    ,
    "(022) 17797407"
    ,
    "(057) 04143514"
    ,
    "(093) 44298522"
    ,
    "(047) 66542373"
    ,
    "(097) 56059455"
    ,
    "(086) 33634937"
    ,
    "(046) 73014675"
    ,
    "(031) 04892274"
    ,
    "(080) 38487646"
    ,
    "(046) 92155783"
    ,
    "(034) 63071663"
    ,
    "(027) 57487477"
    ,
    "(039) 45147534"
    ,
    "(028) 85788842"
    ,
    "(052) 37723690"
    ,
    "(025) 40475869"
    ,
    "(073) 35383816"
    ,
    "(068) 23554068"
    ,
    "(062) 27321551"
    ,
    "(036) 87165348"
    ,
    "(016) 51737305"
    ,
    "(074) 57529487"
    ,
    "(041) 25510992"
    ,
    "(064) 56665899"
    ,
    "(056) 44387574"
    ,
    "(052) 51573083"
    ,
    "(013) 58051227"
    ,
    "(011) 60273074"
    ,
    "(094) 90602982"
    ,
    "(022) 50284870"
};
                var emails = new string[] {
    "eu.eleifend@outlook.org"
    ,
    "dictum@yahoo.com"
    ,
    "et@yahoo.couk"
    ,
    "faucibus.ut@google.couk"
    ,
    "libero@aol.couk"
    ,
    "amet@aol.ca"
    ,
    "libero@icloud.net"
    ,
    "id.magna@aol.ca"
    ,
    "proin@outlook.net"
    ,
    "turpis.aliquam.adipiscing@yahoo.couk"
    ,
    "nec.metus.facilisis@hotmail.com"
    ,
    "lorem.fringilla@outlook.couk"
    ,
    "ridiculus.mus.proin@yahoo.net"
    ,
    "rutrum.eu@aol.com"
    ,
    "auctor.non@aol.ca"
    ,
    "et.pede.nunc@aol.com"
    ,
    "eu.dolor@outlook.edu"
    ,
    "nunc@aol.com"
    ,
    "vivamus.non@icloud.couk"
    ,
    "leo.elementum@hotmail.org"
    ,
    "lobortis.quis@hotmail.edu"
    ,
    "ullamcorper.eu@yahoo.couk"
    ,
    "dui.nec@protonmail.org"
    ,
    "eu.enim@protonmail.org"
    ,
    "orci@outlook.org"
    ,
    "sem@hotmail.couk"
    ,
    "sed.malesuada@protonmail.couk"
    ,
    "tincidunt@yahoo.net"
    ,
    "vel.convallis.in@protonmail.com"
    ,
    "risus.nulla@google.couk"
    ,
    "cursus@protonmail.net"
    ,
    "mollis@outlook.edu"
    ,
    "leo@outlook.ca"
    ,
    "dui.cras.pellentesque@outlook.ca"
    ,
    "est.arcu.ac@google.com"
    ,
    "ut.nec@icloud.couk"
    ,
    "nisl@outlook.edu"
    ,
    "morbi.metus@outlook.couk"
    ,
    "et.ultrices.posuere@google.edu"
    ,
    "tempus.scelerisque.lorem@hotmail.net"
    ,
    "ipsum@protonmail.com"
    ,
    "mattis.ornare.lectus@outlook.couk"
    ,
    "est@yahoo.com"
    ,
    "risus.nunc.ac@outlook.net"
    ,
    "montes.nascetur@aol.com"
    ,
    "tellus@yahoo.ca"
    ,
    "est.ac.facilisis@yahoo.com"
    ,
    "praesent.eu@aol.couk"
    ,
    "amet.consectetuer@google.couk"
    ,
    "consectetuer.adipiscing@outlook.edu"
    ,
    "etiam.ligula@google.com"
    ,
    "ultrices.sit@outlook.com"
    ,
    "ad@aol.com"
    ,
    "metus.in.nec@google.edu"
    ,
    "tellus.faucibus@aol.ca"
    ,
    "felis.nulla@outlook.org"
    ,
    "ornare.tortor.at@google.org"
    ,
    "sit.amet.consectetuer@hotmail.edu"
    ,
    "massa.suspendisse@outlook.org"
    ,
    "quis.pede@aol.edu"
    ,
    "dictum.eleifend@icloud.couk"
    ,
    "nec.malesuada.ut@aol.couk"
    ,
    "lobortis@protonmail.edu"
    ,
    "suspendisse@hotmail.ca"
    ,
    "odio@outlook.edu"
    ,
    "pulvinar@icloud.net"
    ,
    "tellus@yahoo.com"
    ,
    "est@outlook.edu"
    ,
    "non@aol.ca"
    ,
    "erat@yahoo.edu"
    ,
    "fermentum.risus.at@hotmail.edu"
    ,
    "lacinia@icloud.com"
    ,
    "dis.parturient.montes@protonmail.edu"
    ,
    "libero@icloud.com"
    ,
    "volutpat@icloud.org"
    ,
    "urna.ut@outlook.ca"
    ,
    "egestas.aliquam.nec@protonmail.couk"
    ,
    "facilisis.magna@google.com"
    ,
    "eget.ipsum@yahoo.ca"
    ,
    "eu.metus@protonmail.org"
    ,
    "justo@icloud.net"
    ,
    "penatibus@hotmail.ca"
    ,
    "nonummy.ac@hotmail.couk"
    ,
    "phasellus.at.augue@yahoo.edu"
    ,
    "gravida.non@protonmail.com"
    ,
    "rutrum.non.hendrerit@hotmail.com"
    ,
    "ullamcorper.duis@icloud.ca"
    ,
    "libero@icloud.edu"
    ,
    "ac.urna.ut@outlook.couk"
    ,
    "sed@hotmail.org"
    ,
    "tempus.eu@hotmail.net"
    ,
    "magnis@hotmail.org"
    ,
    "magna.tellus@outlook.com"
    ,
    "ut@protonmail.edu"
    ,
    "ultricies.sem@aol.net"
    ,
    "lorem.lorem.luctus@icloud.net"
    ,
    "semper.egestas@google.couk"
    ,
    "arcu.morbi@icloud.org"
    ,
    "cras.eu@hotmail.ca"
    ,
    "at.fringilla.purus@hotmail.edu"
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

                if (!context.AdministratorContacts.Any())
                {
                    var ppl = context.Administrators.ToList();

                    foreach (var item in ppl)
                    {
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.AdministratorContacts.Add(new AdministratorContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Phone").First().ContactTypeId,
                                    AdministratorId = item.AdministratorId,
                                    Value = phones[random.Next(phones.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.AdministratorContacts.Add(new AdministratorContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Email").First().ContactTypeId,
                                    AdministratorId = item.AdministratorId,
                                    Value = emails[random.Next(emails.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.AdministratorContacts.Add(new AdministratorContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Telegram").First().ContactTypeId,
                                    AdministratorId = item.AdministratorId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.AdministratorContacts.Add(new AdministratorContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Viber").First().ContactTypeId,
                                    AdministratorId = item.AdministratorId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                    }

                }

                if (!context.BookkeeperContacts.Any())
                {
                    var ppl = context.Bookkeepers.ToList();

                    foreach (var item in ppl)
                    {
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.BookkeeperContacts.Add(new BookkeeperContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Phone").First().ContactTypeId,
                                    BookkeeperId = item.BookkeeperId,
                                    Value = phones[random.Next(phones.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.BookkeeperContacts.Add(new BookkeeperContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Email").First().ContactTypeId,
                                    BookkeeperId = item.BookkeeperId,
                                    Value = emails[random.Next(emails.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.BookkeeperContacts.Add(new BookkeeperContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Telegram").First().ContactTypeId,
                                    BookkeeperId = item.BookkeeperId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.BookkeeperContacts.Add(new BookkeeperContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Viber").First().ContactTypeId,
                                    BookkeeperId = item.BookkeeperId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                    }

                }

                if (!context.CustomerContacts.Any())
                {
                    var ppl = context.Customers.ToList();

                    foreach (var item in ppl)
                    {
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.CustomerContacts.Add(new CustomerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Phone").First().ContactTypeId,
                                    CustomerId = item.CustomerId,
                                    Value = phones[random.Next(phones.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.CustomerContacts.Add(new CustomerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Email").First().ContactTypeId,
                                    CustomerId = item.CustomerId,
                                    Value = emails[random.Next(emails.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.CustomerContacts.Add(new CustomerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Telegram").First().ContactTypeId,
                                    CustomerId = item.CustomerId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.CustomerContacts.Add(new CustomerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Viber").First().ContactTypeId,
                                    CustomerId = item.CustomerId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                    }

                }

                if (!context.SellerContacts.Any())
                {
                    var ppl = context.Sellers.ToList();

                    foreach (var item in ppl)
                    {
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.SellerContacts.Add(new SellerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Phone").First().ContactTypeId,
                                    SellerId = item.SellerId,
                                    Value = phones[random.Next(phones.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.SellerContacts.Add(new SellerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Email").First().ContactTypeId,
                                    SellerId = item.SellerId,
                                    Value = emails[random.Next(emails.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.SellerContacts.Add(new SellerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Telegram").First().ContactTypeId,
                                    SellerId = item.SellerId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                        if (random.Next(2) == 1)
                        {
                            try
                            {
                                context.SellerContacts.Add(new SellerContact
                                {
                                    ContactTypeId = context.ContactTypes.Where(x => x.Type == "Viber").First().ContactTypeId,
                                    SellerId = item.SellerId,
                                    Value = '@' + nickNames[random.Next(nickNames.Length)]

                                });
                                context.SaveChanges();
                            }
                            catch (Exception) { }
                        }
                    }

                }

                if (!context.AdministratorSalaries.Any())
                {
                    var ppl = context.Administrators.ToList();

                    foreach (var item in ppl)
                    {
                        for (int i = 0; i < 20; ++i)
                        {
                            try
                            {
                                context.AdministratorSalaries.Add(new AdministratorSalary
                                {
                                    Salary = random.Next(1500, 7000),
                                    IssueDate = DateTime.Now.AddDays(-i * 30),
                                    AdministratorId = item.AdministratorId
                                });
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }

                if (!context.BookkeeperSalaries.Any())
                {
                    var ppl = context.Bookkeepers.ToList();

                    foreach (var item in ppl)
                    {
                        for (int i = 0; i < 20; ++i)
                        {
                            try
                            {
                                context.BookkeeperSalaries.Add(new BookkeeperSalary
                                {
                                    Salary = random.Next(1700, 3000),
                                    IssueDate = DateTime.Now.AddDays(-i * 30),
                                    BookkeeperId = item.BookkeeperId
                                });
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }

                if (!context.SellerSalaries.Any())
                {
                    var ppl = context.Sellers.ToList();

                    foreach (var item in ppl)
                    {
                        for (int i = 0; i < 20; ++i)
                        {
                            try
                            {
                                context.SellerSalaries.Add(new SellerSalary
                                {
                                    Salary = random.Next(2000, 9000),
                                    IssueDate = DateTime.Now.AddDays(-i * 30),
                                    SellerId = item.SellerId
                                });
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }

                if (!context.Orders.Any())
                {
                    for (int i = 0; i < 3000; i++)
                    {
                        var newItem = new Order
                        {
                            OrderStatusId = context.OrderStatus.ToList().ElementAt(random.Next(context.OrderStatus.Count())).OrderStatusId,
                            AutoPartId = context.AutoParts.ToList().ElementAt(random.Next(context.AutoParts.Count())).AutoPartId,
                            SellerId = context.Sellers.ToList().ElementAt(random.Next(context.Sellers.Count())).SellerId,
                            CustomerId = context.Customers.ToList().ElementAt(random.Next(context.Customers.Count())).CustomerId,
                            From_AdressId = context.Addresses.ToList().ElementAt(random.Next(context.Addresses.Count())).AdressId,
                            To_AdressId = context.Addresses.ToList().ElementAt(random.Next(context.Addresses.Count())).AdressId,
                            OrderCreatedDateTime = DateTime.Now.AddDays(-i - 2),
                            OrderFinishedDateTime = DateTime.Now.AddDays(-i - 1)
                        };

                        try
                        {
                            context.Orders.Add(newItem);
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {

                        }
                    }
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
