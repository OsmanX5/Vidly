using AutoMapper;
using Vidly.Models;

namespace Vidly.DTOs
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			Mapper.CreateMap<Customer, CustomerDTO>();
			Mapper.CreateMap<CustomerDTO, Customer>();
		}
	}

}
