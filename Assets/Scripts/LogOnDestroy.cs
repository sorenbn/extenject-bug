using UnityEngine;

public class LogOnDestroy : MonoBehaviour
{
    private void OnDestroy()
    {
        Debug.Log($"{gameObject.name} was destroyed");
    }
}
