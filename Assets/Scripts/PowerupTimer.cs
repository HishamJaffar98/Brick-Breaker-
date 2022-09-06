using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupTimer : MonoBehaviour
{
    [SerializeField] Image timerImage;
    [SerializeField] float maxTime;
    [SerializeField] Color[] timerColors;
    [SerializeField] GameEvent[] timerEvents;
    int timerEventIndex;
	float currentTime;

	bool timerStarted = false;
    bool timerRunning = false;
    void Start()
    {
        
    }

    void Update()
    {
        if(timerStarted)
		{
            timerRunning = true;
            currentTime += Time.deltaTime;
            timerImage.fillAmount = currentTime / maxTime;
            if (currentTime>=maxTime)
			{
                timerStarted = false;
                timerRunning = false;
                timerImage.fillAmount = 0;
                currentTime = 0;
                timerEvents[timerEventIndex].EventTriggered();
            }
		}            
    }

    public void ReverseControlTimerStart()
	{
        TimerStart(0);
    }

    public void EnlargeTimerStart()
	{
        TimerStart(1);
    }

    public void StrongBallTimerStart()
    {
        TimerStart(2);
    }

    private void TimerStart(int index)
	{
        if (!timerRunning)
        {
            timerEventIndex = index;
            timerImage.color = timerColors[index];
            timerStarted = true;
        }
    }
}
