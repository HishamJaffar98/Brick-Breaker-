using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Event", menuName ="Custom Events")]
public class GameEvent : ScriptableObject
{
	private List<GameEventListener> listeners = new List<GameEventListener>();
	public void AddListener(GameEventListener listener)
	{
		listeners.Add(listener);
	}

	public void RemoveListener(GameEventListener listener)
	{
		listeners.Remove(listener);
	}

	public void EventTriggered()
	{
		for(int i=0;i<listeners.Count;i++)
		{
			listeners[i].OnEventTriggered(this);
		}
	}

	public void EventTriggered(int value)
	{
		for (int i = 0; i < listeners.Count; i++)
		{
			listeners[i].OnEventTriggered(this,value);
		}
	}


}
