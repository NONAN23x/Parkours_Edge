using UnityEngine;

public class RevolutionaryMotion : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.Rotate(speed*Time.deltaTime, 0f, 0f);
    }
}
