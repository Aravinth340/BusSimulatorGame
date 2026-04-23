using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    private int score;
    private bool isGamePaused;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        score = 0;
        isGamePaused = false;
    }  

    public void UpdateScore(int points)
    {
        score += points;
        // Optionally, update UI or notify players here.
    }

    public int GetScore()
    {
        return score;
    }

    public void PauseGame()
    {
        isGamePaused = true;
        Time.timeScale = 0;  // Freeze the game time
    }

    public void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1;  // Resume the game time
    }

    public bool IsGamePaused()
    {
        return isGamePaused;
    }
}