using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();

        if(_player == null)
        {
            Debug.LogError("Player is Null in GameManager");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_player.HasBalls == false)
        {
            Time.timeScale = 0.5f;
        }    
    }
}
