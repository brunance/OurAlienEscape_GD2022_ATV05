using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject gameOver;
    public GameObject winnerScreen;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void ShowWinnerScreen()
    {
        winnerScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("DefinitiveLevel");
        Physics2D.gravity = new Vector2(0, -9.81f);
    }
}
