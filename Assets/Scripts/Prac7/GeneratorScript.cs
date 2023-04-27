using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    public GameObject prefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
