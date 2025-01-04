using UnityEngine;

public class Soundsmanager : MonoBehaviour
{
    public AudioSource soundPlay;
    public void PlayThisSound(){

        soundPlay.Play();
    }
}
