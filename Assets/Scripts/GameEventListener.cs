using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] List<GameEvent> gameEvents = new List<GameEvent>();
	[SerializeField] List<UnityEvent> unityMethods = new List<UnityEvent>();
	private Dictionary<GameEvent , UnityEvent> eventMap = new Dictionary<GameEvent,UnityEvent>();
	private void OnEnable()
	{
		for(int i=0;i<gameEvents.Count;i++)
		{
			gameEvents[i].AddListener(this);
		}
		
		for(int i=0;i<gameEvents.Count;i++)
		{
			eventMap.Add(gameEvents[i],unityMethods[i]);
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
}

