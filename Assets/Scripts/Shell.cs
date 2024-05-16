using UnityEngine;

public class Shell : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(gameObject, 1.5f);
    }
}