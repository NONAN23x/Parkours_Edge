using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] buttons;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < buttons.Length; i++) {
            if (i+2 > levelAt) {
                buttons[i].interactable = false;
            }
        }
    }

}
