using IndustrialSafetyDataSeed.DTO.Domain;
using IndustrialSafetyLib.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyDataSeed
{
    public static class DataSeedService
    {
        public static IEnumerable<T> GetAll<T>() where T : EntityDTO
        {
            var path = typeof(T).FullName.Replace(".DTO.", ".Data.").Replace("DTO", "") + ".json";
            var jsonStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            using (var streamReader = new StreamReader(jsonStream))
            {
                var jsonString = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<T>>(jsonString);
            }
        }
    }
}
