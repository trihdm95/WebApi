using AutoMapper;
using WebApiService.Entities.Entity;
using WebApiService.Models.Dealer;

namespace WebApiService.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ActivateOnlineDto, ActivateOnline>();
            CreateMap<ActivateOnlineDetailDto, ActivateOnlineDetail>();
            CreateMap<WalletHistoryDto, WalletHistory>().ForMember(x => x.PointValue, opt => opt.Ignore());
            CreateMap<WalletDto, Wallet>();
        }
    }
}
