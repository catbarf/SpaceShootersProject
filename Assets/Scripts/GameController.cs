using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text score;
    

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ShipChange(int id)
    {
        Data.ship = id;
    }

    private void Start()
    {
        if (score != null)
        {
            score.text = "Score: " + Data.score;
        }
        
    }
}
