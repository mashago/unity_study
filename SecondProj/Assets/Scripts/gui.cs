using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnGUI()
	{
		if (GUI.Button(new Rect(10, 10, 40, 20), "Test")) {
			Debug.Log("test button");
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
