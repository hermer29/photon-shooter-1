using Entitas;

namespace GameplayLayer.Game.Systems
{
    public class MovementSystem : IExecuteSystem
    {
        private IGroup<GameEntity> _controllableLocalPlayer;
        
        public MovementSystem(GameContext game, InputContext inputContext)
        {
            var matcher = GameMatcher.AllOf(GameMatcher.LocalPlayer);
            _controllableLocalPlayer = game.GetGroup(matcher);
        }
        
        public void Execute()
        {
            var input = 
            
            foreach (var player in _controllableLocalPlayer)
            {
                
            }
        }
    }
}