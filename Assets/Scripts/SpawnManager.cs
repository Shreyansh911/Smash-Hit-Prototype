using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _obsticles;

    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();

        if(_player == null)
        {
            Debug.LogError("Player is null in SpawnManager");
        }

        StartCoroutine(ObsticlesSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ObsticlesSpawning()
    {
       while(_player.HasBalls == true)
        {
            Instantiate(_obsticles[Random.Range(0, _obsticles.Length)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
