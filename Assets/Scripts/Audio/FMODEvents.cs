using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODEvents : MonoBehaviour
{
    [field: Header("ambient_bg")]
    [field: SerializeField] public EventReference ambient_bg { get; private set; }

    // [field: Header("Music")]
    // [field: SerializeField] public EventReference music { get; private set; }

    [field: Header("sfx_bird_accelerate")]
    [field: SerializeField] public EventReference sfxBirdAccelerate { get; private set; }

	// [field: Header("sfx_flaying")]
	// [field: SerializeField] public EventReference sfxFlying { get; private set; }

    // [field: Header("Coin SFX")]
    // [field: SerializeField] public EventReference coinCollected { get; private set; }
    // [field: SerializeField] public EventReference coinIdle { get; private set; }

    public static FMODEvents instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one FMOD Events instance in the scene.");
        }
        instance = this;
    }
}