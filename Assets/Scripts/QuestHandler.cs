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

	public Quest[] quests;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Reset()
	{
		// Reset all quests.
	}
}