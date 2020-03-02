using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Quest : ScriptableObject
{
	public enum State
	{
		PENDING,
		IN_PROGRESS,
		DONE
	}

	public enum Area
	{
		VOLCANOE,
		FOREST,
		CITY,
		WATERFALL
	}

	public string questDescription;
	public int rewardPoints; // Not sure if int is the right thing to go for here, but it will do for now.
	public string rewardText;
	public Area region;

	[HideInInspector] public State currentState = State.PENDING;

	void Reset()
	{
		currentState = State.PENDING;
	}
}
