using UnityEngine;

public class RandomPrint : MonoBehaviour
{
    public float RandomNumber = 7;
    public GameObject SomeObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Randomizer();

    }

    void Randomizer()
    {
        Debug.Log(RandomNumber);
    }
}
