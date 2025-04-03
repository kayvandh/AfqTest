using Framework.Mapping;
using System.Reflection;

namespace Hotel.Application.Mapping
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            AutoMapperProfile.LoadMaps(this, Assembly.GetExecutingAssembly());
        }
    }
}
