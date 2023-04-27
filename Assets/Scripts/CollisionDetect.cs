using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    /*private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        var obj = collision.gameObject;
        if (obj.CompareTag("Floor")) Destroy(collision.gameObject);
    }
}
