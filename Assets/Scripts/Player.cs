using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public void SayHello()
    {
        Debug.Log($"Player says hello from scene: {SceneManager.GetActiveScene().name}!");
    }
}
