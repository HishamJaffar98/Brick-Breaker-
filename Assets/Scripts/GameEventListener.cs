using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] List<GameEvent> gameEvents = new List<GameEvent>();
	[SerializeField] List<UnityEvent> unityMethods = new List<UnityEvent>();
	[SerializeField] List<IntEvent> customIntEvents = new List<IntEvent>();
	private Dictionary<GameEvent , UnityEvent> eventMap = new Dictionary<GameEvent,UnityEvent>();
	private Dictionary<GameEvent, IntEvent> intEventMap = new Dictionary<GameEvent, IntEvent>();
	private void OnEnable()
	{
		int counter = 0;
		for (int i = 0; i < gameEvents.Count; i++)
		{
			gameEvents[i].AddListener(this);
			if(i>=unityMethods.Count)
			{
				intEventMap.Add(gameEvents[i], customIntEvents[counter]);
				counter++;
			}
			else
			{
				eventMap.Add(gameEvents[i], unityMethods[i]);
			}
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < gameEvents.Count; i++)
		{
			gameEvents[i].RemoveListener(this);
		}
	}

    public void OnEventTriggered(GameEvent eventListenedTo)
	{
		eventMap[eventListenedTo].Invoke();
	}

	public void OnEventTriggered(GameEvent eventListenedTo, int value)
	{
		intEventMap[eventListenedTo].Invoke(value);
	}
}

