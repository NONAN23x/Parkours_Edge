using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFix : MonoBehaviour
{
    private bool captureMouse = true;
    void Start()
    {
        UpdateMouseCapture();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            captureMouse = !captureMouse;
            UpdateMouseCapture();
        }
    }

    private void UpdateMouseCapture()
    {
        Cursor.lockState = captureMouse ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !captureMouse;
    }
}
