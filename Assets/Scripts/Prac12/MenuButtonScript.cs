using UnityEngine;

public class MenuButtonScript : MonoBehaviour
{
    public void StartScene()
    {
        Application.LoadLevel("MenuScene2");
    }

    public void Options(GameObject window)
    {
        window.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
