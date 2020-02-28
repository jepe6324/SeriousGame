using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarHandler : MonoBehaviour
{
	float fillAmount = 0;

	public float maxValue;
	float currentValue = 0;

	Image bar;

    // Start is called before the first frame update
    void Start()
    {
		bar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
		fillAmount = currentValue / maxValue;
		bar.fillAmount = fillAmount;
	}

	public void SetCurrentValue(float value)
	{
		currentValue = value;
	}

	public void SetMaxValue(float value)
	{
		maxValue = value;
	}

	public bool IsFull() // Just ask the bar if it is filled or not, I hope floating point doesn't fuck this up.
	{
		if (fillAmount >= 1)
		{
			return true;
		}
		return false;
	}
}
