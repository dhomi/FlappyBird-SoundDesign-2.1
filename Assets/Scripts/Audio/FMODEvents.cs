using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODEvents : MonoBehaviour
{
	[field: Header("sfx_bird_accelerate")]
	[field: SerializeField] public EventReference sfxBirdAccelerate { get; private set; }
	public static FMODEvents instance { get; private set; }

	public void Awake()
	{
		if (instance != null)
		{
			Debug.LogError("more than one FMOD Events instances detected in one scene! that cant be good.");
		}
		instance = this;
	}
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
