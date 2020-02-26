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

	void setCurrentValue(float value)
	{
		currentValue = value;
	}

	void setMaxValue(float value)
	{
		maxValue = value;
	}
}
