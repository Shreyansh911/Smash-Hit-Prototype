using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(this.gameObject, 5);
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Glass")
        {
            Destroy(other.gameObject);
        }
    }
}
