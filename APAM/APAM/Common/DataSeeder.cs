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
            if (!context.Addresses.Any())
            {
                context.Addresses
                    .AddRange(JsonConvert.DeserializeObject<List<Address>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "Addresses.json")));
                context.SaveChanges();
            }

            if (!context.AutoPartCarModels.Any())
            {
                context.AutoPartCarModels
                    .AddRange(JsonConvert.DeserializeObject<List<AutoPartCarModel>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "AutoPartCarModels.json")));
                context.SaveChanges();
            }

            if (!context.AutoPartCategories.Any())
            {
                context.AutoPartCategories
                   .AddRange(JsonConvert.DeserializeObject<List<AutoPartCategory>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "AutoPartCategories.json")));
                context.SaveChanges();
            }

            if (!context.AutoPartManufacturers.Any())
            {
                context.AutoPartManufacturers
                   .AddRange(JsonConvert.DeserializeObject<List<AutoPartManufacturer>>(GetEmbeddedResource(ADDRESSES_RESOURCES_PATH, "AutoPartManufacturers.json")));
                context.SaveChanges();
            }

            if (!context.AutoParts.Any())
            {
                for (int i = 0; i < 1000; i++)
                {
                    var ap = new AutoPart
                    {
                        AutoPartCarModelId = context.AutoPartCarModels.ToList().ElementAt(new Random().Next(context.AutoPartCarModels.Count())).AutoPartCarModelId,
                        AutoPartCategoryId = context.AutoPartCategories.ToList().ElementAt(new Random().Next(context.AutoPartCategories.Count())).AutoPartCategoryId,
                        AutoPartManufacturerId = context.AutoPartManufacturers.ToList().ElementAt(new Random().Next(context.AutoPartManufacturers.Count())).AutoPartManufacturerId,
                        Article = new Random().Next(1000000, 9000000).ToString(),
                        ManufacturerPartCode = new Random().Next(10000000, 90000000).ToString(),
                        Cost = new Random().Next(100, 1000000)
                    };

                    try
                    {
                        context.AutoParts.Add(ap);
                        context.SaveChanges();
                    }
                    catch (Exception) {}

                    Thread.Sleep(3);
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
    }
}
