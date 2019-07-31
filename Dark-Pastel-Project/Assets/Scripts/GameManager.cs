using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     // Start is called before the first frame update

     [SerializeField] public GameObject pastelWorldHolder, darkWorldHolder;
     [SerializeField] private Player myPlayer;





    void Start()
    {

          


          if (pastelWorldHolder.activeSelf == true)
               darkWorldHolder.SetActive(false);
          else
          {
               pastelWorldHolder.SetActive(true);
               darkWorldHolder.SetActive(false);
                   
          }

    }

    // Update is called once per frame
    void Update()
    {
          WorldSwitch();
    }

     private void WorldSwitch()
     {



          if (Input.GetKeyDown(KeyCode.Tab) == true)
          {


               myPlayer.SwitchBetweenDarkAndPastel();
               FindObjectOfType<AudioManager>().SwitchMusic();

               //Debug.Log("Tab is detected and function is called.");

               if (pastelWorldHolder.activeSelf == true)
               {
                    darkWorldHolder.SetActive(true);
                    pastelWorldHolder.SetActive(false);
               }

               else if (darkWorldHolder.activeSelf == true)
               {
                    darkWorldHolder.SetActive(false);
                    pastelWorldHolder.SetActive(true);
               }
               else
               {
                    darkWorldHolder.SetActive(true);

               }


               //pastelWorldHolder.activeSelf == true ? darkWorldHolder.SetActive(true) : pastelWorldHolder.SetActive(true);//(darkWorldHolder.SetActive(true) && pastelWorldHolder.SetActive(false)) : 


          }
     }

}
