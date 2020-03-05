using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestHandInHandler : MonoBehaviour
{
	public TMPro.TextMeshProUGUI description;
	public Image[] rewards;

	private Quest quest;
	private QuestHandler questHandler;

	// Start is called before the first frame update
	void Start()
	{
		questHandler = FindObjectOfType<QuestHandler>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Setup(Quest quest)
	{
		this.quest = quest;
		description.text = quest.questDescription;
		for (int i = 0; i < quest.rewardPoints; i++)
		{
			if (rewards[i] != null)
			{
				rewards[i].gameObject.SetActive(true);
			}
		}
	}

	public void HandIn()
	{
		if (quest != null)
		{
			questHandler.HandInQuest(quest);
			Destroy(gameObject);
		}
	}
}
