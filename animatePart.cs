using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class animatePart : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource soundPlayer;
    public GameObject modelPart;

    void Start()
    {
        // gameObject.GetComponent<explodeSkeleton>().animate=true;
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            soundPlayer.Play();
            modelPart.GetComponent<explodePart>().animate = true;          //  AudioSource audio = gameObject.addComponent<AudioSource>();
                                                                           //  audio.PlayOneShot((AudioClip)Resources.Load("clank1"));

        }
        else
        {
            // Stop audio when target is lost
            soundPlayer.Stop();
            modelPart.GetComponent<explodePart>().animate = false;
        }
    }
}