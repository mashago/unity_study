using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace CustomTrack
{
    public class TextPlayableAsset : PlayableAsset
    {
        public string str;

        // Factory method that generates a playable based on this asset
        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            var playable = ScriptPlayable<TextPlayableBehaviour>.Create(graph);
            var text_behaviour = playable.GetBehaviour();
            text_behaviour.str = str;
            return playable;
        }
    }
}
