using UnityEngine;

public class GrabScript : MonoBehaviour
{
    private Vector3 mouseOffset;
    private float mouseZCoord;

    private void OnMouseDown()
    {
        mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mouseOffset = gameObject.transform.position - GetMousePosition();
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePosition() + mouseOffset;
    }
}
