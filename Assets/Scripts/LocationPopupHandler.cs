﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationPopupHandler : MonoBehaviour
{
	List<Transform> questBoxes;
	float questBoxDistance = -75.0f;

	public Transform questBoxAnchor;
	
    // Start is called before the first frame update
    void Start()
    {
		
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
}