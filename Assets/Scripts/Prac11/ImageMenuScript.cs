using UnityEngine;
using UnityEngine.UI;

public class ImageMenuScript : MonoBehaviour
{
    public GameObject gameObjPanel;
    public GameObject gameObjImage;
    public Sprite newSprite;
    private Sprite defaultSprite;

    private void Start()
    {
        defaultSprite = gameObjImage.GetComponent<Image>().sprite;
    }
    public void Close()
    {
        gameObjPanel.SetActive(false);
    }

    public void ChangeImage()
    {
        var img = gameObjImage.GetComponent<Image>();
        if (img.sprite == newSprite) img.sprite = defaultSprite;
        else img.sprite = newSprite;
    }
}
