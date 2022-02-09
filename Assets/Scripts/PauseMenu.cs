 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    public static bool isGameOver;
    public GameObject GameOverScreen;
    public AudioSource AudioSource;

    public Animator transition;
    public float transitionTime = 2f;

    private void Awake()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (isGameOver)
        {
            GameOverScreen.SetActive(true);
            AudioSource.Stop();
            Time.timeScale = 0f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        
        SceneManager.LoadScene("Game_Scene");
       
        
    }

  
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        //AmmoText.ammoAmount = 0;
        //DiamondText.diamondAmount = 0;
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu2");
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}