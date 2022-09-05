using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{

    public static InputHandler instance;
    [SerializeField] GameEvent A_KEY_PRESSED;
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
        if(Input.GetKeyDown(KeyCode.A))
		{
            A_KEY_PRESSED.EventTriggered();
        }
	}
}
