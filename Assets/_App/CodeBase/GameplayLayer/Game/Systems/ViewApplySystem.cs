using Entitas;
using UnityEngine;

namespace GameplayLayer.Game.Systems
{
    public class ViewApplySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;
        
        public ViewApplySystem(GameContext game)
        {
            _players = game.GetGroup(GameMatcher.AllOf(
                GameMatcher.Position, 
                GameMatcher.Rotation, 
                GameMatcher.PlayerLink));
        }
        
        public void Execute()
        {
            foreach (var player in _players)
            {
                var position = player.position;
                var rotation = player.rotation;
                var transform = player.playerLink.View.Transform;
                transform.position = new Vector3(position.X, position.Y, position.Z);
                transform.rotation = Quaternion.Euler(rotation.X, rotation.Y, 0f);
            }
        }
    }
}