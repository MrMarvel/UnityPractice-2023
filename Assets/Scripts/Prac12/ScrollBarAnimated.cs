using UnityEngine;
using UnityEngine.UI;

public class ScrollBarAnimated : MonoBehaviour
{
    private Color defaultColor;
    private void Start()
    {
        defaultColor = GetComponent<Image>().color;
        GetComponent<Scrollbar>().onValueChanged.AddListener(ChangeColorByValue);
    }
    public void ChangeColorByValue(float value)
    {
        if (value > 1) value = 1;
        if (value < 0) value = 0;
        var img = GetComponent<Image>();
        var color = img.color;
        color.a = defaultColor.a * value;
        img.color = color;

    }
}
