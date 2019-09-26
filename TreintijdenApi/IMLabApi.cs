using RestEase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TreintijdenApi.Models.MLabResponse;

namespace TreintijdenApi
{
    public interface IMLabApi
    {
        [Header("Ocp-Apim-Subscription-Key")]
        string ApiKey { get; set; }


        [Get("/virtual-train-api/api/v1/trein/{ritnummer}/{stationscode}")]
        Task<TreinInfoResponse> GetTrainInfo(
            [Path("ritnummer")]string ritnummer,
            [Path("stationscode")]string stationscode,
            [Query("features")]string features = null,
            [Query("dateTime", Format = DateTimeFormat.RFC3339DateFormat)]DateTimeOffset? dateTime = null
        );

        [Get("/virtual-train-api/api/v1/trein/{ritnummer}")]
        Task<TreinInfoResponse> GetTrainInfo(
            [Path("ritnummer")]string ritnummer,
            [Query("features")]string features = null,
            [Query("dateTime", Format = DateTimeFormat.RFC3339DateFormat)]DateTimeOffset? dateTime = null
        );

        [Get("/virtual-train-api/api/v1/prognose/{ritnummer}")]
        Task<List<PrognoseResponseItem>> GetTrainInfoPrognose(
      [Path("ritnummer")]string ritnummer
  );

    }
}
