using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;

    AudioSource _audioSource;

    private void Awake()
    {
        #region Singleton Pattern (Simple)
        if(Instance == null)
        {
            //doesnt exist yet, this is now our singleton
            Instance = this;
            DontDestroyOnLoad(gameObject);

            //setup if needed
            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion
    }

    public void PlayMusic(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }


}
