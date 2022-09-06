using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{

    public static InputHandler instance;
    [SerializeField] GameEvent[] inputEvents;
    //public static event int Func<,> newFun;
	private void Awake()
	{
		if(instance!=null)
		{
            GameObject.Destroy(instance);
		}
        else
		{
            instance = this;
		}
	}
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleKeyboardInput();
    }

    private void HandleKeyboardInput()
	{
        if(Input.GetKey(KeyCode.A))
		{
            inputEvents[0].EventTriggered();
        }
        else if(Input.GetKey(KeyCode.D))
		{
            inputEvents[1].EventTriggered();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            inputEvents[2].EventTriggered();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            inputEvents[3].EventTriggered();
        }

        if(Input.GetKeyDown(KeyCode.Space))
		{
            inputEvents[4].EventTriggered();
        }
    }

    public void DeactivateInputHandler()
	{
        this.enabled = false;
	}
}
