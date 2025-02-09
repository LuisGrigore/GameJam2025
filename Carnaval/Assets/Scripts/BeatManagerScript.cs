using System;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Events;

public class BeatManagerScript : MonoBehaviour
{
	[SerializeField] private float bpm;
	[SerializeField] private AudioSource audioSource;
	[SerializeField] private Intervals[] intervals;

	private void Update()
	{
		foreach(Intervals interval in intervals)
		{
			float sampledTime = (audioSource.timeSamples / (audioSource.clip.frequency * interval.getIntervalLenght(bpm)));
			interval.checkForNewInterval(sampledTime);
		}
	}
}

[System.Serializable]
public class Intervals
{
	[SerializeField] private float steps;
	[SerializeField] private UnityEvent onBeatEvent;
	private int lastInterval;

	public float getIntervalLenght(float bpm)
	{
		return 60f / (bpm * steps);
	}

	public void checkForNewInterval(float interval)
	{
		if(Mathf.FloorToInt(interval) != lastInterval)
		{
			lastInterval = Mathf.FloorToInt(interval);
			onBeatEvent.Invoke();
		}
	}
}