using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Photon.Pun;
using Photon.Realtime;
using Zenject;

namespace ConnectionLayer
{
    public class Connection : IInitializable, IConnectionCallbacks, IDisposable
    {
        public bool IsConnected => PhotonNetwork.IsConnected;
        
        public void Initialize()
        {
            PhotonNetwork.AddCallbackTarget(this);
            PhotonNetwork.ConnectUsingSettings();
        }

        public async Task WaitUntilConnected()
        {
            while (PhotonNetwork.IsConnected == false) 
                await Task.Yield();
        }

        public void OnConnected()
        {
            
        }

        public void OnConnectedToMaster()
        {
        }

        public void OnDisconnected(DisconnectCause cause)
        {
        }

        public void OnRegionListReceived(RegionHandler regionHandler)
        {
        }

        public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
        {
        }

        public void OnCustomAuthenticationFailed(string debugMessage)
        {
        }

        public void Dispose()
        {
            PhotonNetwork.RemoveCallbackTarget(this);
        }
    }
}