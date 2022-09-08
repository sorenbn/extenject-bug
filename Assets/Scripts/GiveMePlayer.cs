using UnityEngine;
using Zenject;

public class GiveMePlayer : MonoBehaviour
{
    private Player player;

    [Inject]
    public void Construct(Player player)
    {
        this.player = player;
        Debug.Log($"{this.player} | {this.player.GetInstanceID()}", this.player);

        player.SayHello();
    }
}
