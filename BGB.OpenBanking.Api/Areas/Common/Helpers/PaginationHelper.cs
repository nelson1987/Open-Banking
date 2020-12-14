using BGB.OpenBanking.Api.Areas.Common.Filters;
using BGB.OpenBanking.Api.Contracts.Common;
using BGB.OpenBanking.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BGB.OpenBanking.Api.Areas.Common.Helpers
{
    public class PaginationHelper
    {
        public static PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationFilter validFilter, IUriService uriService, string route)
        {
            var pagedDataFiltered = pagedData
                       .Skip((validFilter.Pagina - 1) * validFilter.TamanhoPagina)
                       .Take(validFilter.TamanhoPagina)
                       .ToList();
            var totalRecords = pagedData.Count();
            var totalPages = ((double)totalRecords / (double)validFilter.TamanhoPagina);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            var respose = new PagedResponse<List<T>>(pagedDataFiltered);

            respose.Links.Next =
                validFilter.Pagina >= 1 && validFilter.Pagina < roundedTotalPages
                ? uriService.GetPageUri(new PaginationFilter(validFilter.Pagina + 1, validFilter.TamanhoPagina), route)
                : null;
            respose.Links.Prev =
                validFilter.Pagina - 1 >= 1 && validFilter.Pagina <= roundedTotalPages
                ? uriService.GetPageUri(new PaginationFilter(validFilter.Pagina - 1, validFilter.TamanhoPagina), route)
                : null;
            respose.Links.First = uriService.GetPageUri(new PaginationFilter(1, validFilter.TamanhoPagina), route);
            respose.Links.Last = uriService.GetPageUri(new PaginationFilter(roundedTotalPages, validFilter.TamanhoPagina), route);
            respose.Meta.TotalPages = roundedTotalPages;
            respose.Meta.TotalRecords = totalRecords;
            return respose;
        }
    }
}