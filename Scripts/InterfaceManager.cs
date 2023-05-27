using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject runningUI;
    public GameObject deathScreenUI;

    private static bool gameIsPaused = false;

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
            Time.timeScale = 0.15f;
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

    public void deathSequence() {
        Debug.Log("You Died");
        pauseMenuUI.SetActive(false);
        runningUI.SetActive(false);
        deathScreenUI.SetActive(true);
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
