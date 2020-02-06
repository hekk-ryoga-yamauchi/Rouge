using Zenject;
using App.Contract;
using App.Controller;
using App.Models;
using App.Services;


public class TestInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("Zenject is running!!");

        // Controllers
        Container.Bind<IPlayerController>().To<PlayerController>().AsSingle().NonLazy();
        Container.Bind<IEnemiesController>().To<EnemiesController>().AsSingle().NonLazy();
        Container.Bind<IGameController>().To<GameController>().AsSingle().NonLazy();
        Container.Bind<IInputController>().To<InputController>().AsSingle().NonLazy();

        // Models
        Container.Bind<ICellsModel>().To<CellsModel>().AsSingle().NonLazy();
        Container.Bind<IPlayerModel>().To<PlayerModel>().AsSingle().NonLazy();
        Container.Bind<IGameModel>().To<GameModel>().AsSingle().NonLazy();
        Container.Bind<IInputModel>().To<InputModel>().AsSingle().NonLazy();

        // Services
        Container.Bind<IPlayerService>().To<PlayerService>().AsSingle().NonLazy();

        // Factory
        Container.BindFactory<int, CellModel, CellModel.Factory>();
    }
}