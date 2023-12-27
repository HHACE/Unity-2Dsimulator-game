using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicChange : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GameObject[] StackMusicCheck = GameObject.FindGameObjectsWithTag("Music");
        if (StackMusicCheck.Length > 1) {
            Destroy(this.gameObject);
        }


        DontDestroyOnLoad(this.gameObject);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
