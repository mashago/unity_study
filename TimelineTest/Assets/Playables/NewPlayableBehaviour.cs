using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

// A behaviour that is attached to a playable
public class NewPlayableBehaviour : PlayableBehaviour
{
    public Text title_text;
    public string title_str;
    public Text name_text;
    public string name_str;

    // Called when the owning graph starts playing
    public override void OnGraphStart(Playable playable)
    {
        
    }

    // Called when the owning graph stops playing
    public override void OnGraphStop(Playable playable)
    {
        
    }

    // Called when the state of the playable is set to Play
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        if (title_text != null && name_text != null)
        {
            title_text.text = title_str;
            title_text.gameObject.SetActive(true);
            name_text.text = name_str;
            name_text.gameObject.SetActive(true);
        }
    }

    // Called when the state of the playable is set to Paused
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        if (title_text != null && name_text != null)
        {
            title_text.gameObject.SetActive(false);
            name_text.gameObject.SetActive(false);
        }
    }

    // Called each frame while the state is set to Play
    public override void PrepareFrame(Playable playable, FrameData info)
    {
        
    }
}
