using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompanionLogHandler : MonoBehaviour
{
	int completedQuestsVolcano;
	int completedQuestsForest;
	int completedQuestsCity;
	int completedQuestsWaterfall;

	int completedQuestsTotal;

	public BarHandler bar;
	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (bar != null)
		{
			bar.setCurrentValue(completedQuestsTotal);
		}
	}

	public void IncrementQuest(string location)
	{
		completedQuestsTotal++;

		switch (location)
		{
			case "Volcano":
				completedQuestsVolcano++;
				break;
			case "Forest":
				completedQuestsForest++;
				break;
			case "City":
				completedQuestsCity++;
				break;
			case "Waterfall":
				completedQuestsWaterfall++;
				break;
			default:
				break;
		}
	}

	public void Reset()
	{
		completedQuestsTotal = 0;
	}
}
