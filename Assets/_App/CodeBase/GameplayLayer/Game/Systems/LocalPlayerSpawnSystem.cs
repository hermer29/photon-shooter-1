using Entitas;
using GameplayLayer.Services;
using Photon.Pun;
using UnityEngine;

namespace GameplayLayer.Game.Systems
{
    public class LocalPlayerSpawnSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly PlayerSpawnService _spawnService;

        public LocalPlayerSpawnSystem(GameContext game, PlayerSpawnService spawnService)
        {
            _game = game;
            _spawnService = spawnService;
        }
        
        public void Initialize()
        {
            var spawnPosition = Vector3.zero;
            var spawnRotation = Quaternion.identity;
            var view = _spawnService.SpawnLocalPlayer(spawnPosition, spawnRotation);
            var photonView = view.PhotonView;
            var entity = _game.CreateEntity();
            entity.AddPlayerLink(view);
            entity.AddPosition(view.transform.position.x, view.transform.position.y, view.transform.position.z);
            entity.AddRotation(spawnRotation.eulerAngles.y, spawnRotation.eulerAngles.x);
            entity.isControllable = true;
            entity.isLocalPlayer = true;
            entity.AddNetworkId(photonView.ViewID);
            entity.AddNetworkOwner(PhotonNetwork.LocalPlayer.ActorNumber, true);
        }
    }
}