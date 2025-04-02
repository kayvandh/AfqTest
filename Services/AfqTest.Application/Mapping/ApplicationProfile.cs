using Framework.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AfqTest.Application.Mapping
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            AutoMapperProfile.LoadMaps(this, Assembly.GetExecutingAssembly());
        }
    }
}
