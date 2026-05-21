using GameplayLayer.Game.Systems;
using GameplayLayer.Services;

namespace GameplayLayer.Game._Features
{
    public class GameFeature : Feature
    {
        public GameFeature(GameContext game, PlayerSpawnService playerSpawnService)
        {
            Add(new LocalPlayerSpawnSystem(game, playerSpawnService));
            Add(new MovementSystem(game));
            Add(new ViewApplySystem(game));
        }
    }
}