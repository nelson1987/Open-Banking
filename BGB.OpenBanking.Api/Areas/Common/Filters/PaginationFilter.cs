namespace BGB.OpenBanking.Api.Areas.Common.Filters
{
    public class PaginationFilter
    {
        public int Pagina { get; set; }
        public int TamanhoPagina { get; set; }

        public PaginationFilter()
        {
            Pagina = 1;
            TamanhoPagina = 1000;
        }

        public PaginationFilter(int pagina, int tamanhoPagina)
        {
            Pagina = pagina < 1 ? 1 : pagina;
            TamanhoPagina = tamanhoPagina > 25 ? 25 : tamanhoPagina;
        }
    }
}