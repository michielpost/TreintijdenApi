using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi
{
    public interface IBaseNsApi
    {
        [Header("Ocp-Apim-Subscription-Key")]
        string ApiKey { get; set; }
    }
}
