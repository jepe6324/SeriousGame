using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureLogHandler : MonoBehaviour
{
	QuestHandler questHandler;
	List<Transform> questBoxes;
	float questBoxDistance = -75.0f;

	public Transform questBoxAnchor;
	public TextboxHandler textBoxMother;

    // Start is called before the first frame update
    void Start()
    {
		questHandler = FindObjectOfType<QuestHandler>();
    }

	// Update is called once per frame
	void Update()
	{
		for (int i = 0; i < questBoxAnchor.childCount; i++)
		{
			Transform child = questBoxAnchor.GetChild(i);
			if (child.CompareTag("Quest"))
			{
				child.localPosition = new Vector3(0, questBoxDistance * i, 0);
			}
		}
	}

	public void DisplayRewardText(Quest quest)
	{
		textBoxMother.DisplayTextBox(quest.questDescription, quest.rewardText);
	}
}


/*
 * Wants to get told by QuestHandler to put a quest here marked for completion.
 * I think the quest handin in objects will tell this object that a quest is completed
 * Wants to to display the text popup for handing in a quest.
 */