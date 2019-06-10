using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	[SerializeField] private SettingsPopup settingsPopup;
    // Start is called before the first frame update
    void Start()
    {
		settingsPopup.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnOpenSettings() {
		Debug.Log("open settings");
		settingsPopup.Open();
	}
}
