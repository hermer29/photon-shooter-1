using System.Threading;
using Entitas;
using SomeMultiplayerProject.Input;
using Zenject;

namespace GameplayLayer
{
    public class EcsBootstrapper : ITickable
    {
        private Systems systems;

        private bool _isBegun;
        
        public void Begin(CancellationToken token)
        {
            systems = new Systems();
            systems.Add(new InputSystem());
            
            
            
            systems.Initialize();
            _isBegun = true;
        }
        
        public void Tick()
        {
            if (!_isBegun)
                return;
            
            systems.Execute();
        }
    }
}