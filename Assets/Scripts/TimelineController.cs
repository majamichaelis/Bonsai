using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector timelineStart;
    public PlayableDirector timeline2;

    public Animator animator;

    public void TimelinePlayStart()
    {
        timelineStart.Play();

    }

    public void PlayTimeline2()
    {
        timelineStart.Stop();
        timeline2.Play();

    }

    public void ReplayTimeline2()
    {
        timeline2.Stop();
        timeline2.Play();

    }
}
