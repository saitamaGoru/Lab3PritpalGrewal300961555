using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    [SerializeField] private Vector3 _area = new Vector3(0f, -12.2f, 0f);
    [SerializeField] private TeleportChannel _teleChannel;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) {return;}
        other.transform.position = _area;
       _teleChannel.Invoke(other.transform.position);
        Destroy(gameObject);
    }

   
}
