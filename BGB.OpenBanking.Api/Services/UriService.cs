using BGB.OpenBanking.Api.Areas.Common.Filters;
using Microsoft.AspNetCore.WebUtilities;
using System;

namespace BGB.OpenBanking.Api.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetPageUri(PaginationFilter filter, string route)
        {
            var _enpointUri = new Uri(string.Concat(_baseUri, route));
            var modifiedUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "pageNumber", filter.Pagina.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", filter.TamanhoPagina.ToString());
            return new Uri(modifiedUri);
        }
    }
}
