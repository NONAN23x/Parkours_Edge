using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector timelineDirector;

    void Update()
    {
        if(Input.GetKey(KeyCode.B)) {
            timelineDirector.Play();
        }
    }
}
