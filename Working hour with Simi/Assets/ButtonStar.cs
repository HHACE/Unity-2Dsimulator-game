using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStar : MonoBehaviour
{



    public GameObject stream;
    public StreamRunTime Stream;

    public GameObject SpriteStar;

    public GameObject parent;


    // Start is called before the first frame update
    void Start()
    {
        Stream = stream.GetComponent<StreamRunTime>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void AddBatteryStar() {
        if (Stream.BatteryStar > 0)
        {
            Stream.BatteryStar -= 1;
        }

        var newObj = GameObject.Instantiate(SpriteStar, new Vector3(-0.52f, 0.23f, 0), Quaternion.identity);
        newObj.transform.parent = GameObject.Find("whStreamBg").transform;
    } 

}
