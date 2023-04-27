using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Vector3 speed;

    private void Update()
    {
        GetComponent<Rigidbody>().velocity = speed;
    }
}
