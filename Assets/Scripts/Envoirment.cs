using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Envoirment : MonoBehaviour
{
    [SerializeField] private float _speed = 7;


   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if(transform.position.z < -210)
        {
            transform.Translate(new Vector3(transform.position.x, transform.position.y, 600));
        }
    }
}
