using UnityEngine;

public class FallSoundPlay : MonoBehaviour
{
    private AudioSource soundEff;

    private void Start()
    {
        soundEff = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        soundEff.Play();
    }
}
