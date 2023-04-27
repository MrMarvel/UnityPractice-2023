using UnityEngine;

public class PushScript : MonoBehaviour
{
    public GameObject pushableObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (pushableObject)
            {
                pushableObject.GetComponent<Rigidbody>().AddForce(0, 200, 0);
            }
        }
    }
}
