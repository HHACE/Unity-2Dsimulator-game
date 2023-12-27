using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babytrigger : MonoBehaviour
{
    public GameObject Player;
    public player Simi;


   // public GameObject baby;

    public bool trigger = false;


    //public npc npcbaby;

    //public Material bbmaterial;
   // private static bool HL = false;

    public bool getGOCheck =false;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Simi walking sprite");
        



        Simi = Player.GetComponent<player>();

    }
    
    // Update is called once per frame
    void Update()
    {


        if (trigger)
        {
            Simi.PBaby = true;
            /*bbmaterial.SetFloat("_CHECK", 1f);*/

            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (Simi.Babypickup_flag == false)
                {
        


                    Simi.Babypickup_flag = true;
                    

                }
                else if (Simi.PDoor)
                {
                    Simi.Babypickup_flag = true;
                    
                }
                else
                {

                    Simi.Babypickup_flag = false;
                    
                }
            }
        }
        else {
            Simi.PBaby = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;
        


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;
       
    }


   
}
