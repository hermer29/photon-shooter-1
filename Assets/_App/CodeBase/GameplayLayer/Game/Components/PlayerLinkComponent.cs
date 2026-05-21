using Entitas;
using GameplayLayer.Game.Views;

namespace GameplayLayer.Game
{
    [Game]
    public class PlayerLinkComponent : IComponent
    {
        public PlayerView View;
    }
}