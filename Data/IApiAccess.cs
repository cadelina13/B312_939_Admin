using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B312_939_Admin.Data
{
    public interface IApiAccess
    {
        [Get("/device/signal")]
        Task<string> GetSignalStatus();

        [Get("/webserver/token")]
        Task<string> GetToken();
    }
}
