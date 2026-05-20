using App;
using ConnectionLayer;
using GameplayLayer;
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
        
        Container.BindInterfacesAndSelfTo<EcsBootstrapper>()
            .AsSingle();
        
        Container.BindInstance(staticData);
    }
}
