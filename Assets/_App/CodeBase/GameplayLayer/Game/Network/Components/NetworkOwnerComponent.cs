using Entitas;

namespace GameplayLayer.Game.Network.Components
{
    [Game]
    public class NetworkOwnerComponent : IComponent
    {
        public int ActorNumber;
        public bool IsLocal;
    }
}