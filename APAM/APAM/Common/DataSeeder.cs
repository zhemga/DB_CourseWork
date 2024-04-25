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
                        AutoPartCarModelId = context.AutoPartCarModels.ToList().ElementAt(new Random().Next(context.AutoPartCarModels.Count())).AutoPartCarModelId,
                        AutoPartCategoryId = context.AutoPartCategories.ToList().ElementAt(new Random().Next(context.AutoPartCategories.Count())).AutoPartCategoryId,
                        AutoPartManufacturerId = context.AutoPartManufacturers.ToList().ElementAt(new Random().Next(context.AutoPartManufacturers.Count())).AutoPartManufacturerId,
                        Article = (Math.Abs(Guid.NewGuid().GetHashCode())).ToString(),
                        ManufacturerPartCode = (Math.Abs(Guid.NewGuid().GetHashCode())).ToString(),
                        Cost = new Random().Next(100, 1000000)
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
