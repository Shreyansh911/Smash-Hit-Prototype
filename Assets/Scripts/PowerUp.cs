using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Player _player;
    private UIManager _uiManager;


    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        if(_player == null)
        {
            Debug.LogError("Player is null in PowerUp");
        }

        if(_uiManager == null)
        {
            Debug.LogError("UIManager is null in PowerUp");
        }

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
            _player.AddBalls();
        }
    }
}
