using System;
using System.Threading;
using System.Threading.Tasks;
using ConnectionLayer;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using Zenject;

namespace LobbyLayer
{
    public class Matchmaking : IInitializable, IInRoomCallbacks
    {
        private readonly Connection _connection;
        
        private CancellationTokenSource _currentRoomAlive = null;
        
        public Matchmaking(Connection connection)
        {
            _connection = connection;
        }

        public void Initialize()
        {
            Init();
        }

        private async Task Init()
        {
            await _connection.WaitUntilConnected();
            PhotonNetwork.JoinRandomOrCreateRoom();
        }

        public async Task<CancellationToken> WaitUntilConnected()
        {
            while (_currentRoomAlive == null)
            {
                await Task.Yield();
                
                if(!_connection.IsConnected)
                    throw new Exception("Disconnected");
            }

            return (_currentRoomAlive = new CancellationTokenSource()).Token;
        }

        public void OnPlayerEnteredRoom(Player newPlayer)
        {
            
        }

        public void OnPlayerLeftRoom(Player otherPlayer)
        {
        }

        public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
        {
        }

        public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
        {
        }

        public void OnMasterClientSwitched(Player newMasterClient)
        {
        }
    }
}