using App;
using GameplayLayer.Game.Views;
using Photon.Pun;
using UnityEngine;

namespace GameplayLayer.Services
{
    public class PlayerSpawnService
    {
        private readonly StaticData _staticData;

        public PlayerSpawnService(StaticData staticData)
        {
            _staticData = staticData;
        }

        public PlayerView SpawnLocalPlayer(Vector3 position, Quaternion rotation)
        {
            var playerObject = PhotonNetwork.Instantiate(
                _staticData.PlayerPrefab.name,
                position,
                rotation
            );
            var view = playerObject.GetComponent<PlayerView>();
            view.SetLocal(true);
            return view;
        }
    }
}