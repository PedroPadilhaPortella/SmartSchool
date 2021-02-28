using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SmartSchoolAPI.Helpers
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse response, 
            int currentpage, int itemsperpage, int totalitems, int totalpages)
        {
            var paginationHeader = new PaginationHeader(currentpage, itemsperpage, totalitems, totalpages);

            var camelCaseFormater = new JsonSerializerSettings();
            camelCaseFormater.ContractResolver = new CamelCasePropertyNamesContractResolver();

            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormater));
            response.Headers.Add("Access-Control-Header", "Pagination");
        }
    }
}