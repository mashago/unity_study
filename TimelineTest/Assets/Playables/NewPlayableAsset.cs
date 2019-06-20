using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

[System.Serializable]
public class NewPlayableAsset : PlayableAsset
{
    public ExposedReference<Text> title_text;
    // [Multiline(3)]
    public string title_str;

    public ExposedReference<Text> name_text;
    public string name_str;

    // Factory method that generates a playable based on this asset
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    {
        NewPlayableBehaviour pb = new NewPlayableBehaviour();
        pb.title_text = title_text.Resolve(graph.GetResolver());
        pb.title_str = title_str;

        pb.name_text = name_text.Resolve(graph.GetResolver());
        pb.name_str = name_str;

        // return Playable.Create(graph);
        return ScriptPlayable<NewPlayableBehaviour>.Create(graph, pb);
    }
}
