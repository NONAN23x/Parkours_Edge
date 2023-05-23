using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logger : MonoBehaviour
{ 
    public int speed = 10;
    public float salary = 10.3f;

    public string myName = "nomaan";

    public Rigidbody rb;

    void Update()
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
    }

    void MainMenu() {
        int menuIndex = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(menuIndex);
    }

    void reloadScene() {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
