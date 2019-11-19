using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreintijdenApi.Models;
using TreintijdenApi.Models.Response;

namespace TreintijdenApi
{
    public interface IPriceApi : IBaseNsApi
    {
        [Get("/public-prijsinformatie/prices")]
        Task<GetPriceResponse> GetPrice([Query("date", Format = "yyyy-MM-dd")]DateTimeOffset date, [Query("fromStation")]string fromStation, [Query("toStation")]string toStation);

    }
}
