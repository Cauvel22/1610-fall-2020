using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
