using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;


public class Coin : MonoBehaviour
{
    [SerializeField] float speed = 180f;
    private GameManagement gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManagement>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            gameManager.updateScoreBoard(1);
            Destroy(gameObject);
        }
    }
}
