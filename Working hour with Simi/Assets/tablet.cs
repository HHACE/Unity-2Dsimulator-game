using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablet : MonoBehaviour
{
    public GameObject Player;
    public player Simi;

    public bool trigger = false;
    public Material Tabletmaterial;
    private static bool HL = false;

    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();

        Tabletmaterial = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            Simi.PTablet = true;
            if (Simi.Tablet_flag == false)
            {
                HL = true;
            }
            else
            {
                HL = false;
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (Simi.Tablet_flag == false)
                {

                    Simi.Tablet_flag = true;
                    
                }
                else
                {

                    Simi.Tablet_flag = false;
                   

                }
            }
        }
        else
        {
            HL = false;
            Simi.PTablet = false;
        }
        Tabletmaterial.SetInt("_Boolean", HL ? 0 : 1);


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
