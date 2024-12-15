using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
public class VolumeManager : MonoBehaviour
{
    [SerializeField] GameObject _volumeSliderPrefab;
    [SerializeField] Transform _volumeScrolViewContent;
    [SerializeField] AudioMixer _audioMixer;


    void Start()
    {
        var groups = _audioMixer.FindMatchingGroups("Master");

        foreach(var group in groups) 
        {
           var gameObject =  Instantiate(_volumeSliderPrefab, _volumeScrolViewContent);
           gameObject.GetComponentInChildren<TMP_Text>().text = group.ToString();
           gameObject.GetComponentInChildren<Slider>().onValueChanged.AddListener(value =>{

            _audioMixer.SetFloat(group.name + "Volume", value);
           });
        }
    }

}
