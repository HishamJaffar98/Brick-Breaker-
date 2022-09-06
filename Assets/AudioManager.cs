using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioManager instance;
	AudioSource audioSource;
	[SerializeField] AudioClip[] audioClips;
	private void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
        else
		{
			instance = this;
		}
	}
	void Start()
    {
		audioSource = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void PlayBallHitPaddleSound()
	{
		audioSource.PlayOneShot(audioClips[0]);
	}

	public void PlayBallHitBrickSound()
	{
		audioSource.PlayOneShot(audioClips[1]);
	}
}
