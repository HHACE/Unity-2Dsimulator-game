using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WifeJumpScare : MonoBehaviour
{
    public new Transform transform;

    public float ScaleNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScaleNumber < 5)
        {
            ScaleNumber += Time.deltaTime * 6;
        }
        else {
            ScaleNumber = 5;
        }

        transform.localScale = new Vector3(ScaleNumber, ScaleNumber, ScaleNumber);

    }
}
