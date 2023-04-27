using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
    }
}
