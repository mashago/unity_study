using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace CustomTrack
{
    [TrackClipType(typeof(TextPlayableAsset))]
    [TrackBindingType(typeof(Text))]
    public class TextControlTrack : TrackAsset {}
}
