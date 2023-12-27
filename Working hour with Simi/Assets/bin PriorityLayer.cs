using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriorityLayer : MonoBehaviour
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
        if (Simi.PTablet == false && Simi.PCom)
        {
            Physics2D.IgnoreLayerCollision(8, 11, false);
        }
        else if (Simi.PTablet && Simi.PCom == false)
        {
            Physics2D.IgnoreLayerCollision(8, 9, false);
        }
        else if (Simi.PTablet == false && Simi.PCom == false)
        {
            Physics2D.IgnoreLayerCollision(8, 9, false);
            Physics2D.IgnoreLayerCollision(8, 11, false);
        }

        if (Simi.PCom && Simi.PTablet)
        {

            if (Simi.sprite.flipX)
            {

                Physics2D.IgnoreLayerCollision(8, 9, true);
                Physics2D.IgnoreLayerCollision(8, 11, false);

            }
            else
            {
                Physics2D.IgnoreLayerCollision(8, 11, true);
                Physics2D.IgnoreLayerCollision(8, 9, false);

            }

        }
    }
}
