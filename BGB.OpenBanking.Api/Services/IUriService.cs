using BGB.OpenBanking.Api.Areas.Common.Filters;
using System;

namespace BGB.OpenBanking.Api.Services
{
    public interface IUriService
    {
        Uri GetPageUri(PaginationFilter filter, string route);
    }
}
