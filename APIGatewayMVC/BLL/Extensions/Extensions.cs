using AutoMapper;
using BLL.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Extensions
{
    public static class AddMapper
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
