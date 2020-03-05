using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextboxCreator : MonoBehaviour
{
	public string titleString;
	public string mainString;
	public string buttonString;

	public TextboxHandler MotherBox;
	// Start is called before the first frame update
	void Start()
    {
        if (MotherBox == null)
		{
			Debug.Log("MotherBox is missing from button");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void DisplayTextBox()
	{
		titleString = titleString.Replace("<br>", "\n"); // Inserts new line
		mainString = mainString.Replace("<br>", "\n");
		buttonString = buttonString.Replace("<br>", "\n");
		if (MotherBox != null)
			MotherBox.DisplayTextBox(titleString, mainString);
		else
			Debug.Log("MotherBox was null, please set it to a instance of motherBox");
	}
}
