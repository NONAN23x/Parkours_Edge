using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject runningUI;
    private static bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            Debug.Log("Hit Pause!");
            pause();
        }
    }

    public void pause() {
        //if (!gameIsPaused) {
            Debug.Log("Paused!");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            gameIsPaused = true;
            pauseMenuUI.SetActive(true);
            runningUI.SetActive(false);
            Time.timeScale = 0.0f;
        //}
    }

    public void resume() {
        if (gameIsPaused){
            Debug.Log("Resumed!");
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            gameIsPaused = true;
            pauseMenuUI.SetActive(false);
            runningUI.SetActive(true);
            Time.timeScale = 1.0f;
        }
    }

    public void mainMenu() {
        Debug.Log("Main Menu");
        int mainMenuIndex = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(mainMenuIndex);
    }

    public void Quit() {
        Application.Quit();
    }
}
