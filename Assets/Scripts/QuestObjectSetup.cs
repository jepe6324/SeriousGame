using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestObjectSetup : MonoBehaviour
{

	public TMPro.TextMeshProUGUI description;
	public Image[] rewards;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Setup(Quest quest)
	{
		description.text = quest.questDescription;
		for (int i = 0; i < quest.rewardPoints; i++)
		{
			if (rewards[i] != null)
			{
				rewards[i].gameObject.SetActive(true);
			}
		}
	}
}
