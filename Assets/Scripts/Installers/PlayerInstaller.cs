using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "PlayerInstaller", menuName = "Installers/PlayerInstaller")]
public class PlayerInstaller : ScriptableObjectInstaller<PlayerInstaller>
{
    [SerializeField] private Player playerPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Player>()
            .FromComponentInNewPrefab(playerPrefab)
            .AsSingle()
            .NonLazy();
    }
}