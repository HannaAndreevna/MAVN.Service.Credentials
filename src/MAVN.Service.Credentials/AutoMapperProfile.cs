using AutoMapper;
using MAVN.Service.Credentials.MsSqlRepositories.Entities;
using MAVN.Service.Credentials.Client.Models.Responses;
using MAVN.Service.Credentials.Domain.Enums;
using MAVN.Service.Credentials.Domain.Models;

namespace MAVN.Service.Credentials
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PasswordResetEntity, PasswordResetModel>()
                .ForMember(x => x.ErrorCode, p => p.Ignore());
            CreateMap<PasswordResetModel, PasswordResetResponseModel>();
            CreateMap<PasswordResetErrorCodes, PasswordResetErrorResponse >()
                .ForMember(x => x.Error, c => c.MapFrom(s => s));
            CreateMap<ValidateIdentifierErrorCodes, ResetIdentifierValidationResponse>()
                .ForMember(x => x.Error, c => c.MapFrom(s => s));

            CreateMap<AdminCredentialsEntity, AdminCredentials>(MemberList.Destination);
            CreateMap<AdminCredentials, AdminCredentialsEntity>(MemberList.Source);
            CreateMap<PartnerCredentialsEntity, PartnerCredentials>(MemberList.Destination);
            CreateMap<PartnerCredentials, PartnerCredentialsEntity>(MemberList.Source);
        }
    }
}
