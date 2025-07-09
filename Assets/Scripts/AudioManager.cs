using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public enum SoundType
    {
        Point,
        Hit,
        StartMenu,
        PlayingLevel
    }

    [System.Serializable]
    public class Sound
    {
        public SoundType Type;
        public AudioClip Clip;

        [Range(0f, 1f)]
        public float Volume = 1f;

        [HideInInspector]
        public AudioSource Source;
    }

    public static AudioManager Instance;

    public Sound[] AllSounds;

    private Dictionary<SoundType, Sound> soundDictionary = new();
    private AudioSource musicSource;
    private SoundType currentSound;

	private void Awake()
	{
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

		Instance = this;
        DontDestroyOnLoad(gameObject);

        foreach (Sound sound in AllSounds)
        {
            soundDictionary[sound.Type] = sound;
        }

        Instance.ChangeTrack(SoundType.StartMenu);
	}



	public void Play(SoundType type)
    {
        if (!soundDictionary.TryGetValue(type, out Sound sound))
        {
            Debug.LogWarning($"Sound type {type} not found!");
            return;
        }

		//Create new sound object
		GameObject soundObj = new($"Sound_{type}");
		AudioSource audioSrc = soundObj.AddComponent<AudioSource>();

        audioSrc.clip = sound.Clip;
        audioSrc.volume = sound.Volume;

        audioSrc.Play();

        Destroy(soundObj, sound.Clip.length);
    }

    public void ChangeTrack(SoundType type)
    {
        if (!soundDictionary.TryGetValue(type, out Sound track))
        {
			Debug.LogWarning($"Sound type {type} not found!");
			return;
		}

        if (musicSource == null)
        {
            musicSource = gameObject.AddComponent<AudioSource>();
            musicSource.loop = true;
        }

        musicSource.clip = track.Clip;
        musicSource.volume = track.Volume;
        musicSource.Play();

        currentSound = type;
    }

    public SoundType GetCurrentSoundType()
    {
        return currentSound;
    }
}
