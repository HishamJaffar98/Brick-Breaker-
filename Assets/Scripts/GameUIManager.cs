using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreCounter;
    [SerializeField] GameObject lifeContainer;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TextMeshProUGUI finalScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int score)
	{
        scoreCounter.text = score.ToString();
	}
    
    public void UpdateLives()
	{
        if(lifeContainer.transform.GetChild(0).gameObject!=null)
		{
            Destroy(lifeContainer.transform.GetChild(0).gameObject);
        }
    }
    public void EnableGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        finalScore.text = "SCORE: " + scoreCounter.text;
    }
}
