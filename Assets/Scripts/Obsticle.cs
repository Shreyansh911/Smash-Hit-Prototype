using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    [SerializeField] private float _speed = 7;

    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();

        if(_player == null)
        {
            Debug.LogError("Player is null in Obsticle");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);

        if(transform.position.z < -10)
        {
            Destroy(this.gameObject);
        }

        if(_player.HasBalls == false)
        {
            Destroy(this.gameObject, 2);
        }
    }
}
