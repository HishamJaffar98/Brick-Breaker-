using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameEvent[] mainGameEvents;
    void Start()
    {
        mainGameEvents[0].EventTriggered();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
