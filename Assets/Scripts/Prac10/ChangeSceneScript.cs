using UnityEngine;

public class ChangeSceneScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("SimpleScene1");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("SimpleScene2");
        }
    }
}
