using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            LoadNextScene();
            Debug.Log("Loaded Next Level!");
        }
        
    }

    void LoadNextScene() {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex + 1);
        if (currentScene.buildIndex+1>PlayerPrefs.GetInt("levelAt")){
            PlayerPrefs.SetInt("levelAt", currentScene.buildIndex+1);
        }
    }
}
