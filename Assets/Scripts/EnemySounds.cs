using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class EnemySounds : MonoBehaviour
{
   [SerializeField] AudioSource _AudioSource;
   [SerializeField] AudioClip _AudioClip;


   public void PlayStep()
   {
        _AudioSource.PlayOneShot(_AudioClip);
   }
}
