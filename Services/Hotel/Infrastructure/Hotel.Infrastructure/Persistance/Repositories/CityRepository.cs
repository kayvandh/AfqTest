using Hotel.Application.Common.Repositories;
using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Persistance.Repositories
{
    public class CityRepository : ICityRepository
    {
        public async Task<List<City>> GetAllAsync(bool includeDetail = true)
        {
            var result = new List<City>() 
            { 
                new City(){Id=1,CountryId=1, TitleFa="تهران", TitleEn="Tehran",IataCode="THR",
                    ProviderCities = new List<ProviderCity>()
                        { 
                        new ProviderCity() { CityId=1,ProviderId=1,Code= "THR" } ,
                        new ProviderCity() { CityId=1,ProviderId=2,Code= "69" }
                        } 
                    },
                new City(){ Id=2,CountryId=1, TitleFa="اصفهان", TitleEn="Isfahan",IataCode="IFN",
                    ProviderCities = new List<ProviderCity>()
                        {
                        new ProviderCity() { CityId=1,ProviderId=1,Code= "IFN" } ,
                        new ProviderCity() { CityId=1,ProviderId=2,Code= "72" }
                        }  },
                new City(){ Id=3,CountryId=1, TitleFa="تبریز", TitleEn="Tabriz",IataCode="TBZ",
                    ProviderCities = new List<ProviderCity>()
                        {
                        new ProviderCity() { CityId=1,ProviderId=1,Code= "TBZ" } ,
                        new ProviderCity() { CityId=1,ProviderId=2,Code= "121" }
                        }  },
                new City(){ Id=4,CountryId=1, TitleFa="شیراز", TitleEn="Shiraz",IataCode="SYZ",
                    ProviderCities = new List<ProviderCity>()
                        {
                        new ProviderCity() { CityId=1,ProviderId=1,Code= "SYZ" } ,
                        new ProviderCity() { CityId=1,ProviderId=2,Code= "99" }
                        }  },
                new City(){ Id=5,CountryId=1, TitleFa="مشهد", TitleEn="Mashad",IataCode="MHD",
                    ProviderCities = new List<ProviderCity>()
                        {
                        new ProviderCity() { CityId=1,ProviderId=1,Code= "MHD" } ,
                        new ProviderCity() { CityId=1,ProviderId=2,Code= "37" }
                        }  },
                new City(){ Id=6,CountryId=1, TitleFa="کیش", TitleEn="Kish",IataCode="KIH",
                    ProviderCities = new List<ProviderCity>()
                        {
                        new ProviderCity() { CityId=1,ProviderId=1,Code= "KIH" } ,
                        new ProviderCity() { CityId=1,ProviderId=2,Code= "82" }
                        }  },
                new City(){ Id=7,CountryId=1, TitleFa="قشم", TitleEn="Qeshm",IataCode="GSM" ,
                    ProviderCities = new List<ProviderCity>()
                        {
                        new ProviderCity() { CityId=1,ProviderId=1,Code= "GSM" } ,
                        new ProviderCity() { CityId=1,ProviderId=2,Code= "183" }
                        } },
            };
            if (!includeDetail) result.ForEach(c => c.ProviderCities = null);

            return await Task.Run(() => result );            
        }

        public async Task<City?> GetById(int id, bool includeDetail = true)
        {
            return (await GetAllAsync(includeDetail)).FirstOrDefault(p=> p.Id==id);
        }

        public async Task<List<City>> GetByTitle(string title, bool includeDetail = true)
        {
            return (await GetAllAsync(includeDetail)).Where(p => p.TitleEn.Contains(title) || p.TitleFa.Contains(title)).ToList(); ;
        }
    }
}
