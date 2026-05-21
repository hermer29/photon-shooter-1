using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ConnectionLayer;
using ExitGames.Client.Photon;
using GameplayLayer;
using Photon.Pun;
using Photon.Realtime;
using Zenject;

namespace LobbyLayer
{
    public partial class Matchmaking : IInitializable, IMatchmakingCallbacks, IDisposable
    {
        private readonly Connection _connection;
        private readonly EcsBootstrapper _ecsBootstrapper;

        private CancellationTokenSource _currentRoomAlive = null;
        
        public Matchmaking(Connection connection, EcsBootstrapper ecsBootstrapper)
        {
            _connection = connection;
            _ecsBootstrapper = ecsBootstrapper;
        }

        public void Initialize()
        {
            Init();
        }

        private async Task Init()
        {
            await _connection.WaitUntilConnected();
            PhotonNetwork.AddCallbackTarget(this);
            PhotonNetwork.JoinRandomOrCreateRoom();
        }

        public void OnJoinedRoom()
        {
            _currentRoomAlive = new CancellationTokenSource();
            _ecsBootstrapper.Begin(_currentRoomAlive.Token);
        }

        public void Dispose()
        {
            _currentRoomAlive?.Dispose();
            PhotonNetwork.RemoveCallbackTarget(this);
        }
    }
}