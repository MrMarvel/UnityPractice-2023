using UnityEngine;

public class InfoButtonClick : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log(name);
            Debug.Log(transform.position);
            Debug.Log(GetComponent<Renderer>().material.color);
            Debug.Log(GetComponent<Rigidbody>().mass);
        }
    }
}
