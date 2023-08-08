using Business.Models.Request;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Models.Request.Create;
using Business.Models.Request.Update;



namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();

        CreateMap<User, UserProfileDto>();
        CreateMap<UserUpdateDto, User>();


        CreateMap<Tweet, TweetInfoDto>();
        //eklenenler
        CreateMap<TweetCreateDto, Tweet>();
        CreateMap<TweetUpdateDto, Tweet>();

    }
}