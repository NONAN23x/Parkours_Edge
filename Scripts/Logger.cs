using UnityEngine;
using UnityEngine.SceneManagement;

public class Logger : MonoBehaviour
{ 
    private InterfaceManager InterfaceManagerScript;

    bool playerHasDied = false;

    void Start()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        InterfaceManagerScript = FindObjectOfType<InterfaceManager>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R)) {
            reloadScene();
        }

        if (Input.GetKey(KeyCode.M)) {
            MainMenu();
        }

        if(Input.GetKey(KeyCode.Q)) {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.L)) {
            PlayerPrefs.DeleteAll();
        }

        if (gameObject.transform.position.y < -5f) {
            startDefeatScene();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag) {
            case "Trap":
                startDefeatScene();
                break;
            case "CheckPoint":
                //do something
                break;
            default:
                Debug.Log(other.gameObject.tag);
                break;
        }
    }

    public void startDefeatScene()
    {
        if (!playerHasDied) {
                playerHasDied = true;
                InterfaceManagerScript.deathSequence();
                Invoke("reloadScene", 1f);;
            }
        else {return;}
        Debug.Log("You Died!");
        playerHasDied = false;
        
    }

    void MainMenu() {
        int menuIndex = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(menuIndex);
    }

    public void reloadScene() {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }

}
