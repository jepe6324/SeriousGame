using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
	public int highEnergy;
	public int mediumEnergy;
	public int lowEnergy;

	public BarHandler bar;

	public GameObject background;
	public GameObject dailyPopup;
	public GameObject energyDrainedPopup;

	int energyAmount;

	// Start is called before the first frame update
	void Start()
    {
		bar.maxValue = highEnergy;
		dailyPopup.SetActive(true);
		background.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
		if (bar != null)
		{
			bar.setCurrentValue(energyAmount);
		}
	}

	public void DrainEnergy(int amount)
	{
		energyAmount -= amount;
		if ( energyAmount <= 0 )
		{
			// Spawn popup that warns about your energy level, close old text boxes as well maybe?
			energyDrainedPopup.SetActive(true);
			background.SetActive(true);

			energyAmount = 0;
		}
	}

	public void SetDailyEnergy(int amount)
	{
		switch (amount)
		{
			case 1:
				energyAmount = highEnergy;
				break;
			case 2:
				energyAmount = mediumEnergy;
				break;
			case 3:
				energyAmount = lowEnergy;
				break;
			default:
				break;
		}
	}
}