namespace ConnectivityWin.Services
{
    public sealed class ConnectivityService : IConnectivityService
    {
        public void InitialiseConnectivity()
        {
            Connectivity.ConnectivityChanged += ConnectivityChanged;
        }

        private void ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            
        }

        public void StopConnectivity()
        {
            Connectivity.ConnectivityChanged -= ConnectivityChanged;
        }
    }
}