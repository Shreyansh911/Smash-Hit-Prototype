using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _gamevoerText, _scoreText;
    [SerializeField] private Button _restartButton, _exitButton;
    
    private Player _player;

    public int BallValue = 30;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();

        if(_player == null)
        {
            Debug.LogError("Player is null in UIManager");
        }


        _scoreText.text = "Balls : " + 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(_player.HasBalls == false)
        {
            _gamevoerText.gameObject.SetActive(true);
            _restartButton.gameObject.SetActive(true);
        }

        _scoreText.text = "Balls : " + BallValue;

    }


    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void BackToMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
