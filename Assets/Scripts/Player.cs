using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _balls = 30, _loseBalls = 5;

    public bool HasBalls = true;

    private UIManager _uiManager;

    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        Time.timeScale = 1;

        if(_uiManager == null)
        {
            Debug.LogError("UIManager is empty in Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Glass")
        {
            _balls -= _loseBalls;
            Destroy(other.gameObject);
        }
    }

    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && HasBalls == true)
        {
            _balls--;
            _uiManager.BallValue--;

            if (_balls == 0)
            {
                HasBalls = false; 
                Time.timeScale = 0.5f;
            }
        }
    }

    

    public void AddBalls()
    {
        _balls += 3;
        _uiManager.BallValue += 3;
    }

  
}
