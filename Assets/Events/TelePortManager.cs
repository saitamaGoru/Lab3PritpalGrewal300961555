
using System.Collections;
using UnityEngine;

public class TelePortManager : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] Transform _source;
     [SerializeField] ParticleSystem _ps;
   
   public void Teleport(Vector3 area)
   {
     StartCoroutine(SmoothTeleport(area));
   }

   public IEnumerator SmoothTeleport(Vector3 area)
{
    Vector3 startPosition = _source.position;
    Vector3 endPosition = area;
    float elapsed = 0;

    while (elapsed < 1f)
    {
        _source.position = Vector3.Lerp(startPosition, endPosition, elapsed / 1f);
         _ps.Play();
        elapsed += Time.deltaTime;
       
        yield return null;
    }

    _source.position = endPosition;
}
}
