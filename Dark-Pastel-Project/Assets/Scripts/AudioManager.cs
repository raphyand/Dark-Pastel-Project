using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

     AudioSource myAudioSource;
     [SerializeField] private AudioClip pastelAudio, darkAudio;

     // Start is called before the first frame update
     void Start()
    {
          myAudioSource = GetComponent<AudioSource>();
          myAudioSource.clip = pastelAudio;
          myAudioSource.Play();
          //FindObjectOfType<GameManager>();
     }

    // Update is called once per frame
    void Update()
    {
         // SwitchMusic();
    }

     public void SwitchMusic()
     {
          if (FindObjectOfType<GameManager>().pastelWorldHolder.activeSelf == true)
          {
               myAudioSource.clip = darkAudio;
               myAudioSource.Play();
               
          }
          else if (FindObjectOfType<GameManager>().darkWorldHolder.activeSelf == true)
          {
               myAudioSource.clip = pastelAudio;
               myAudioSource.Play();
          }
          //else
          //{
          //     myAudioSource.clip = pastelAudio;
          //     myAudioSource.Play();
          //}
     }

}
