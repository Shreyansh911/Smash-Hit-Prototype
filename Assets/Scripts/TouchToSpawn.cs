using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToSpawn : MonoBehaviour
{
    public float spawnHelper = 4.5f;
    public GameObject ball;
    public float ballForce = 700;

    private Camera _cam;
    private Player _player;


    // Use this for initialization
    void Start()
    {
        _cam = GetComponent<Camera>();
        _player = GameObject.Find("Player").GetComponent<Player>();

        if(_player == null)
        {
            Debug.LogError("Player is null in Touch to spawn");
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Local floats
        float mousePosx = Input.mousePosition.x;
        float mousePosy = Input.mousePosition.y;

        //Confusing part :-)
        Vector3 BallInstantiatePoint = _cam.ScreenToWorldPoint(new Vector3(mousePosx, mousePosy, _cam.nearClipPlane + spawnHelper));


        if (Input.GetMouseButtonDown(0) && _player.HasBalls == true)
        {
            GameObject ballRigid;
            ballRigid = Instantiate(ball, BallInstantiatePoint, transform.rotation);
            ballRigid.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballForce);
        }
    }
}
