using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxHandler : MonoBehaviour
{
	public Text titleText;
	public Text mainText;

    // Start is called before the first frame update
    void Start()
	{
		if (titleText == null ||
			mainText == null)
		{
			Debug.Log("A text object was missing in textbox mother");
			gameObject.SetActive(false);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void DisplayTextBox(string title, string main) // Displays the textbox with a designated text for every textbox.
	{
		titleText.text = title;
		mainText.text = main;
		gameObject.SetActive(true);
	}
}
