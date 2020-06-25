using UnityEngine;

public class HitPlaySound : MonoBehaviour
{

    public AudioClip sound;

    void OnCollisionEnter2D(Collision2D Collison)
    {
        if (Collison.gameObject.tag != "UnityChanTag")
        {
            GetComponent<AudioSource>().Play();
            //AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}