using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAnim : MonoBehaviour
{
    public GameObject Stream;

    public float TransitionValue;

    public bool Direction = false;

    // Start is called before the first frame update
    void Start()
    {
        TransitionValue = -1.0f;
        Direction = true;
    }



    // Update is called once per frame
    void Update()
    {
        if (Stream.GetComponent<StreamRunTime>().TransitionAnim == true)
        {
            
            if (Direction == true)
            {
               
                if (TransitionValue < 0.0f)
                {
                    
                    TransitionValue += Time.deltaTime *10;
                }
                else
                {
                 
                    Direction = false;
                    Stream.GetComponent<StreamRunTime>().TransitionAnim = false;
                    TransitionValue = 0;
                }
            }
            else if (Direction == false)
            {
              
                if (TransitionValue > -1.0f)
                {
                    
                    TransitionValue -= Time.deltaTime * 10;
                }
                else
                {
                    
                    Direction = true;
                    Stream.GetComponent<StreamRunTime>().TransitionAnim = false;
                    TransitionValue = -1.0f;
                }
            }
            
       

        }

        gameObject.transform.position = new Vector3((float) gameObject.transform.position.x, TransitionValue, (float) gameObject.transform.position.z);
    }

/*    private void FixedUpdate()
    {



        
    }*/

}
