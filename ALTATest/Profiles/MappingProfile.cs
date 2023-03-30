using ALTATest.Models;
using ALTATest.ViewModels;
using AutoMapper;

namespace ALTATest.Profiles
{
    public class MappingProfile : Profile    {
        public MappingProfile()
        {
            CreateMap<BangDiemVM_Input, BangDiem>().ReverseMap();
            CreateMap<MonHocVM_Input, MonHoc>().ReverseMap();
            CreateMap<HocVienVM_Input, HocVien>().ReverseMap();

        }
    }
}
