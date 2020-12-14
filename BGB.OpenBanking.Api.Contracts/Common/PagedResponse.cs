using BGB.OpenBanking.Api.Common.Models;

namespace BGB.OpenBanking.Api.Contracts.Common
{
    public class PagedResponse<T> : Response<T>
    {
        public Links Links { get; set; }
        public Meta Meta { get; set; }

        public PagedResponse(T data)
        {
            Data = data;
            Message = null;
            Errors = null;
            Succeeded = true;
            Links = new Links();
            Meta = new Meta();
        }
    }
}