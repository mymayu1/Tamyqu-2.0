using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
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
      

        if (isGameOver)
        {
            GameOverScreen.SetActive(true);
            AudioSource.Stop();
            Time.timeScale = 0f;
        }
    }

    // Start is called before the first frame update
   
    public void Play()
    {
        
        //SceneManager.LoadScene("Game_Scene");
       StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

    }
    
 
    
    
}
