using App;
using ConnectionLayer;
using GameplayLayer;
using GameplayLayer.Game._Features;
using GameplayLayer.Services;
using LobbyLayer;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public StaticData staticData;
    
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<Connection>()
            .AsSingle();
        
        Container.BindInterfacesAndSelfTo<Matchmaking>()
            .AsSingle();
        
        Container.Bind<PlayerSpawnService>()
            .ToSelf()
            .AsSingle();
        
        Container.BindInstance(staticData);
        
        BindEcs();
    }

    private void BindEcs()
    {
        Container.BindInterfacesAndSelfTo<EcsBootstrapper>()
            .AsSingle();

        Container.Bind<GameFeature>()
            .ToSelf()
            .AsSingle();
        
        Container.Bind<Contexts>()
            .FromInstance(Contexts.sharedInstance)
            .AsSingle();
        
        Container.Bind<InputContext>()
            .FromInstance(Contexts.sharedInstance.input)
            .AsSingle();

        Container.Bind<GameContext>()
            .FromInstance(Contexts.sharedInstance.game)
            .AsSingle();
    }
}
