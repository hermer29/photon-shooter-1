using Entitas;

namespace GameplayLayer.Game.Systems
{
    public class LookSystem : IExecuteSystem
    {
        private IGroup<GameEntity> controllableWithRotation;
        
        public LookSystem(Contexts contexts)
        {
            var matcher = Matcher<GameEntity>.AllOf(GameMatcher.Controllable, GameMatcher.Rotation);
            controllableWithRotation = contexts.game.GetGroup(matcher);
        }

        public void Execute()
        {
            var delta = UnityEngine.Input.mousePositionDelta;
            foreach (var e in controllableWithRotation)
            {
                e.ReplaceRotation(e.rotation.X + delta.x, e.rotation.Y + delta.y);
            }
        }
    }
}