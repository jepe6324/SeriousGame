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
	float companionMunchTimer;

	int foodAmount;
	int feedingCounter;

	public BarHandler bar;

	public Text volcanoText;
	public Text forestText;
	public Text cityText;
	public Text waterfallText;

	public Image companionStandardSprite;
	public Image companionMunchSprite;

	public TextboxHandler textBoxMother;
	public string feedingLoreText;
	public string feedingLoreTitle;

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (bar != null)
		{
			bar.setCurrentValue(foodAmount);
		}
		volcanoText.text = completedQuestsVolcano.ToString();
		forestText.text = completedQuestsForest.ToString();
		cityText.text = completedQuestsCity.ToString();
		waterfallText.text = completedQuestsWaterfall.ToString();

		if (companionMunchTimer > 0)
		{
			companionMunchSprite.gameObject.SetActive(true);
			companionStandardSprite.gameObject.SetActive(false);
			companionMunchTimer -= Time.deltaTime;
		}
		else
		{

			companionMunchSprite.gameObject.SetActive(false);
			companionStandardSprite.gameObject.SetActive(true);
		}
	}

	public void IncrementQuest(string location)
	{
		foodAmount++;

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
		foodAmount = 0;
	}

	public void FeedCompanion()
	{
		if (foodAmount > 0)
		{
			foodAmount--;
			feedingCounter++;
			//Do the things to make the mascot happy here
			companionMunchTimer = 0.7f;
		}
	}
}
