using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

     AudioSource myAudioSource;
     [SerializeField] private AudioClip pastelAudio, darkAudio, bossAudio;

     // Start is called before the first frame update
     void Start()
    {
          myAudioSource = GetComponent<AudioSource>();

          if (FindObjectOfType<GameManager>().bossLevel == true)
               myAudioSource.clip = bossAudio;
          else if (FindObjectOfType<GameManager>().pastelWorldHolder.activeSelf == true)
               myAudioSource.clip = pastelAudio;
          else if (FindObjectOfType<GameManager>().darkWorldHolder.activeSelf == true)
               myAudioSource.clip = darkAudio;

               myAudioSource.Play();
          //FindObjectOfType<GameManager>();
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

     }

}
