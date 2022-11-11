using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{

    [SerializeField] string level;
    private GameManagement gameManager;





    public void resetLevel()
    {

        gameManager = FindObjectOfType<GameManagement>();
        gameManager.LoadNewNextLevel(level);
        gameManager.DisablePlayAgainCanvas();



    }
}
