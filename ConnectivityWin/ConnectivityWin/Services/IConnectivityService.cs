using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityWin.Services
{
    public interface IConnectivityService
    {
        public void InitialiseConnectivity();
        public void StopConnectivity();
    }
}
