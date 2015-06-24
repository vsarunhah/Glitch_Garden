using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;

void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Start(){
		audioSource = GetComponent<AudioSource>();
	}

 void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		if (thisLevelMusic) {

		}
			;
	}