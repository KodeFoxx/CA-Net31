using AutoMapper;
using Kf.CANetCore31.Core.Application.Mappings;
using Kf.CANetCore31.Core.Domain.People;

namespace Kf.CANetCore31.Core.Application.Cqs.Queries.GetPeople
{
    public class PersonViewModel : IMapFrom<Person>
    {
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Person, PersonViewModel>()
                .ForMember(vm => vm.Number, m => m.MapFrom(p => p.Number.Value))
                .ForMember(vm => vm.FirstName, m => m.MapFrom(p => p.Name.FirstName))
                .ForMember(vm => vm.LastName, m => m.MapFrom(p => p.Name.LastName));
        }
    }
}