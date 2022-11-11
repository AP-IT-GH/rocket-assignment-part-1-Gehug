using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManagement gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            gameManager.EnablePlayAgainCanvas();

        }
    }
}
