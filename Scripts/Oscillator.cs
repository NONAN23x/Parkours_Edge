using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPositon;

    public Vector3 movementVector;

    [SerializeField] [Range(0, 1)] float movementFactor;

    public float period = 2f;

    // Start is called before the first frame update
    void Start()
    {
        startingPositon = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float cycles = Time.time / period;
        const float tau = Mathf.PI *2;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = (rawSinWave + 1f) / 2f;

        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPositon + offset;
    }
}
