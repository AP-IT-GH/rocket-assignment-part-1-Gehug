using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string nextLevel;
    private GameManagement gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameManager = FindObjectOfType<GameManagement>();

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "player")
        {
            gameManager.LoadNewNextLevel(nextLevel);
        }

        
    }

}
