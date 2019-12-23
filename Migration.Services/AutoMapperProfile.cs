using AutoMapper;
using Migration.Core;
using Migration.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migration.Services
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Core.ContactDetails, Data.ContactDetails>()
                .ForMember(destination => destination.address, map => map.MapFrom(source => JsonConvert.SerializeObject(source.address)))
                .ForMember(destination => destination.name, map => map.MapFrom(source => JsonConvert.SerializeObject(source.name)))
                .ForMember(destination => destination.phone, map => map.MapFrom(source => JsonConvert.SerializeObject(source.phone)));

            CreateMap<Data.ContactDetails, Core.ContactDetails>()
                .ForMember(destination => destination.address, map => map.MapFrom(source => JsonConvert.DeserializeObject<Address>(source.address)))
                .ForMember(destination => destination.name, map => map.MapFrom(source => JsonConvert.DeserializeObject<Name>(source.name)))
                .ForMember(destination => destination.phone, map => map.MapFrom(source => JsonConvert.DeserializeObject<Phone>(source.phone)));
        }
    }
}
