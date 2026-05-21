using System;
using System.Threading;
using Entitas;
using GameplayLayer.Game._Features;
using GameplayLayer.Services;
using SomeMultiplayerProject.Input;
using Zenject;

namespace GameplayLayer
{
    public class EcsBootstrapper : ITickable, IDisposable
    {
        private readonly Contexts _contexts;
        private readonly PlayerSpawnService _playerSpawnService;
        private readonly GameFeature _gameFeature;

        private bool _isBegun;
        
        private Systems _systems;

        public EcsBootstrapper(Contexts contexts, PlayerSpawnService playerSpawnService, GameFeature gameFeature)
        {
            _contexts = contexts;
            _playerSpawnService = playerSpawnService;
            _gameFeature = gameFeature;
        }
        
        public void Begin(CancellationToken token)
        {
            _systems = new Systems();
            _systems.Add(new InputSystem());
            
            _systems.Initialize();
            _gameFeature.Initialize();
            _isBegun = true;
        }
        
        public void Tick()
        {
            if (!_isBegun)
                return;
            
            _systems.Execute();
            _gameFeature.Execute();
        }

        public void Dispose()
        {
            _systems.Cleanup();
            _gameFeature.Cleanup();
        }
    }
}