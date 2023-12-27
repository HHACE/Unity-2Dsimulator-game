using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDespawn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("Despawn", 1.5f);
    }

    public void Despawn() {
        Destroy(gameObject);
    } 

}
