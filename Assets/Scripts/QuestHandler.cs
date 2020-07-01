using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestHandler : MonoBehaviour
{

	/*
	 * Planning to make it so that this handles moving the quests around for us
	 * 
	 * A quest with state PENDING is in it's Region's quest list.
	 * A quest with state IN_PROGRESS is in the to do list.
	 * A quest with state DONE is hidden until something triggers Reset().
	 * And when a player completes a quest this box spawns the lore text box.
	 * 
	 * I guess this should also give the player the reward for completed quests.
	 */

	public Quest[] quests; // The scriptable objects of the quests, do not write to this one.
	public GameObject[] areas;
	public GameObject adventureLog;
	public GameObject questPrefab;
	public GameObject questHandInPrefab;

	private Quest[] questInstances; // Creates instances of the quests that we can use.
	private AdventureLogHandler adventureLogHandler;
	private CompanionLogHandler companionLogHandler;
	private PlayerHandler playerHandler;

	// Start is called before the first frame update
	void Start()
	{
		questInstances = new Quest[quests.Length];
		adventureLogHandler = FindObjectOfType<AdventureLogHandler>();
		companionLogHandler = FindObjectOfType<CompanionLogHandler>();
		playerHandler = FindObjectOfType<PlayerHandler>();

		for (int i = 0; i < quests.Length; i++)
		{
			if (quests[i] == null)
			{
				quests[i].Reset();
				continue;
			}
			
			questInstances[i] = ScriptableObject.Instantiate(quests[i]);
		}
	}

    // Update is called once per frame
    void Update()
    {
        foreach (Quest questInstance in questInstances)
		{
			if (questInstance == null)
			{
				continue;
			}

			switch (questInstance.GetCurrentState())
			{
				case Quest.State.DONE:
					break;
				case Quest.State.IN_PROGRESS:

					break;
				case Quest.State.PENDING:
					break;
				case Quest.State.DEFAULT:
					SetQuestPending(questInstance);
					break;
				default:
					break;
			}
		}
    }

	public void Reset()
	{
		foreach (Quest questInstance in questInstances)
		{
			questInstance.Reset();
		}
		companionLogHandler.Reset();
		// Reset all quests.
	}

	public void AcceptQuest(Quest quest)
	{
		GameObject clone = Instantiate(questHandInPrefab, adventureLog.transform.Find("QuestBoxAnchor"));
		clone.name = quest.questDescription;
		clone.GetComponent<QuestHandInHandler>().Setup(quest);
		quest.SetState(Quest.State.IN_PROGRESS);
	}

	public void HandInQuest(Quest quest)
	{
		switch(quest.location)
		{
			case Quest.Location.VOLCANO:
				companionLogHandler.IncrementQuest("Volcano");
				break;
			case Quest.Location.FOREST:
				companionLogHandler.IncrementQuest("Forest");
				break;
			case Quest.Location.CITY:
				companionLogHandler.IncrementQuest("City");
				break;
			case Quest.Location.WATERFALL:
				companionLogHandler.IncrementQuest("Waterfall");
				break;
			default:
				break;
		}
		playerHandler.DrainEnergy(quest.rewardPoints);
		adventureLogHandler.DisplayRewardText(quest);
		quest.SetState(Quest.State.DONE);
	}

	void SetQuestPending(Quest quest)
	{
		int questLocationIndex = (int)quest.location;   // Get the location where it is supposed to reside
		GameObject clone = Instantiate(questPrefab, areas[questLocationIndex].transform.Find("QuestBoxAnchor")); // Create an instance of the quest gameobject
		clone.name = quest.questDescription;
		clone.GetComponent<QuestObjectSetup>().Setup(quest); // Run the setup of the quest
		quest.SetState(Quest.State.PENDING);	// Set the internal state to pending
	}
}