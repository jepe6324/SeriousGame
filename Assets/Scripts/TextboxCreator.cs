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
		MotherBox.DisplayTextBox(titleString, mainString, buttonString);
	}
}
