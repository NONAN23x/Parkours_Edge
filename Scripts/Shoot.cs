using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Vector3 startPos;
    public Vector3 endPos;
    public float speed;
    Logger log;
    MeshRenderer mr;
    Collider collide;
    Rigidbody rb;

    bool objectHasCollided = false;

    void Start()
    {  
        rb = GetComponent<Rigidbody>();
        collide = GetComponent<SphereCollider>();
        mr = GetComponent<MeshRenderer>();
        log = FindObjectOfType<Logger>();
        startPos = transform.position;
    }

    void FixedUpdate()
    {
        //transform.Translate(endPos*speed*Time.deltaTime);
        if (transform.position.y < -8)
            repeatSelf();
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag) {
            case "Player":
                log.startDefeatScene();
                break;
            case "Friend":
                repeatSelf();
                break;
            default:
                Debug.Log(other.gameObject.tag);
                break;    
        }
    }

    private void repeatSelf()
    {
        if (!objectHasCollided) {
            // do something
            objectHasCollided = true;
            mr.enabled = false;
            collide.enabled = false;
            Invoke("repeatWithRealism", 1f);
            
        }
        else {return;}

    }

    void repeatWithRealism() {
        transform.position = startPos;
        rb.velocity = new Vector3(0,0,0);
        objectHasCollided = false;
        mr.enabled = true;
        collide.enabled = true;
    }
}
