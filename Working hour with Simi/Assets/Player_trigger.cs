using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Player_trigger : MonoBehaviour
{
    public GameObject Player;
    public player Simi;



    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        // priority
        if (Simi.PBaby)
        {

            Physics2D.IgnoreLayerCollision(8, 9, true);
            Physics2D.IgnoreLayerCollision(8, 11, true);
            Physics2D.IgnoreLayerCollision(8, 13, true);

        }
        else
        {

            if (Simi.PTablet && Simi.Tablet_flag == false) {
                Physics2D.IgnoreLayerCollision(8, 11, true);
                Physics2D.IgnoreLayerCollision(8, 10, false);
                return;
            } else if (Simi.PCom && Simi.Com_flag ==false) {
                Physics2D.IgnoreLayerCollision(8, 10, false);
                return;
            }





            // function
            if (Simi.Tablet_flag)
            {
                Physics2D.IgnoreLayerCollision(8, 10, true);
                Physics2D.IgnoreLayerCollision(8, 11, true);
                return;
            }


            if (Simi.Com_flag)
            {
                Physics2D.IgnoreLayerCollision(8, 10, true);
                Physics2D.IgnoreLayerCollision(8, 9, true);
                return;
            }

            
            Physics2D.IgnoreLayerCollision(8, 9, false);
            Physics2D.IgnoreLayerCollision(8, 11, false);
            Physics2D.IgnoreLayerCollision(8, 12, false);
            Physics2D.IgnoreLayerCollision(8, 13, false);

        }










    }

/*    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player_trigger");
    }*/


}
