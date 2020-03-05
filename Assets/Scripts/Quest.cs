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
		DONE,
		DEFAULT
	}

	public enum Location
	{
		VOLCANO,
		FOREST,
		CITY,
		WATERFALL
	}

	public string questDescription;
	public int rewardPoints; // Not sure if int is the right thing to go for here, but it will do for now.
	public string rewardText;
	public Location location;

	private State currentState = State.DEFAULT;

	public void Reset()
	{
		currentState = State.DEFAULT;
	}

	public State GetCurrentState()
	{
		return currentState;
	}

	public void SetState(State state)
	{
		currentState = state;
	}
}
