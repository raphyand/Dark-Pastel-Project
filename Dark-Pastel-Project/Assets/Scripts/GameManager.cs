using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     // Start is called before the first frame update

     [SerializeField] public GameObject pastelWorldHolder, darkWorldHolder;
     [SerializeField] private Player myPlayer;
     [SerializeField] private bool singleLevelOnly;
     [SerializeField] public bool bossLevel;




    void Start()
    {

          myPlayer = FindObjectOfType<Player>();

          if (singleLevelOnly == false)
          {


               if (pastelWorldHolder.activeSelf == true)
                    darkWorldHolder.SetActive(false);
               else
               {
                    pastelWorldHolder.SetActive(true);
                    darkWorldHolder.SetActive(false);

               }
          }
          else if (singleLevelOnly == true)
               myPlayer.SwitchBetweenDarkAndPastel();

     }

    // Update is called once per frame
    void Update()
    {
          if (singleLevelOnly == false)
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
