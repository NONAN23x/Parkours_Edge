using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void level1() {
        LoadLevel(2);
    }
    public void level2() {
        LoadLevel(3);
    }
    public void level3() {
        LoadLevel(4);
    }
    public void level4() {
        LoadLevel(5);
    }
    public void level5() {
        LoadLevel(6);
    }
    public void level6() {
        LoadLevel(7);
    }
    public void level7() {
        LoadLevel(8);
    }   
    public void level8() {
        LoadLevel(9);
    }
    public void level9() {
        LoadLevel(10);
    }
    public void level10() {
        LoadLevel(11);
    }

    public void levelSelect() {
        int sceneIndex = 1;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(sceneIndex);
    }

    public void quit() {
        Debug.Log("Hit Quit!");
        Application.Quit();
    }
    
    public void tutorial() {
        Debug.Log("Hit Tutorial!");
        SceneManager.LoadScene(13);
    }
    public void LoadLevel(int sceneIndex)
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(sceneIndex);
    }

}
