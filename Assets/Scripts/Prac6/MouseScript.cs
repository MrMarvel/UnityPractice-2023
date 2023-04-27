using UnityEngine;

public class MouseScript : MonoBehaviour
{
    private Renderer renderProp;
    private void Start()
    {
        renderProp = GetComponent<Renderer>();
    }
    private void OnMouseEnter()
    {
        renderProp.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        renderProp.material.color = Color.blue;
    }
}
