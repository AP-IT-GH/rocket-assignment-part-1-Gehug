using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{

    private int playerScore = 0;
    [SerializeField] GameObject playAgainCanvas;
    [SerializeField] Text scoreBoardText;
    // Start is called before the first frame update
    void Start()
    {
        if (scoreBoardText != null) { 
            scoreBoardText.text = playerScore.ToString() + " POINTS";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScoreBoard(int score)
    {

        playerScore += score;
        if (scoreBoardText !=  null)
        {
            scoreBoardText.text = playerScore.ToString() + " POINTS";
        }
        


    }

    public void LoadNewNextLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void EnablePlayAgainCanvas()
    {

        playAgainCanvas.SetActive(true);

    }

    public void DisablePlayAgainCanvas()
    {

        playAgainCanvas.SetActive(false);

    }


}
