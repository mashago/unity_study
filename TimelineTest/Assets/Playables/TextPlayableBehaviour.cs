using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace CustomTrack
{
    // A behaviour that is attached to a playable
    public class TextPlayableBehaviour : PlayableBehaviour
    {
        public Text _text;
        public string str;

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
            
        }

        // Called when the state of the playable is set to Paused
        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            if (_text != null)
            {
                _text.gameObject.SetActive(false);
            }
        }

        // Called each frame while the state is set to Play
        public override void PrepareFrame(Playable playable, FrameData info)
        {
            
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            Text text = playerData as Text;
            text.text = str;
            text.gameObject.SetActive(true);
            _text = text;
        }
    }
}
