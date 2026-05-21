// using App;
// using GameplayLayer.Game.Views;
// using Photon.Realtime;
// using Zenject;
//
// namespace GameplayLayer.ZenjectFactories
// {
//     public class PlayerFactory : IFactory<GameEntity>
//     {
//         private readonly IInstantiator _instantiator;
//         private readonly StaticData _data;
//
//         public PlayerFactory(IInstantiator instantiator, StaticData data)
//         {
//             _instantiator = instantiator;
//             this._data = data;
//         }
//         
//         public GameEntity Create()
//         {
//             var playerObject = _instantiator.InstantiatePrefab(_data.PlayerPrefab);
//             var view = playerObject.GetComponent<PlayerView>();
//             var entity = Contexts.sharedInstance.game.CreateEntity();
//             entity.AddTransform(view.Transform);
//             entity.AddLook(view.Camera);
//             return entity;
//         }
//     }
// }