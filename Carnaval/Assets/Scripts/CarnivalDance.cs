using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivalDance : MonoBehaviour
{
	public float carnivalTempo;

	public bool isDancing;

	void Start()
	{
		carnivalTempo = carnivalTempo / 60f;
	}

	void Update()
	{
		if (!isDancing)
		{
			/* if(Input.anyKeyDown)
			{
				isDancing = true;
			} */
		}
		else
		{
			transform.position -= new Vector3(carnivalTempo * Time.deltaTime, 0f, 0f);
		}
	}
}
