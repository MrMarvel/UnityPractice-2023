using UnityEngine;

public class ColorChange : MonoBehaviour
{

    // Update is called once per frame

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (Input.GetKeyDown(KeyCode.T))
        {
            var material = GetComponent<Renderer>().material;
            if (material.color == Color.red)
            {
                material.color = Color.white;
            }
            else
            {
                material.color = Color.red;
            }
        }

    }
}
