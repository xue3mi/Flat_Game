using UnityEngine;

public class characterWalkingSound : MonoBehaviour
{
    public AudioSource walkingAudioSource;
    public AudioClip walkingSoundClip;

    // use sfx mixer
    public UnityEngine.Audio.AudioMixerGroup sfxMixerGroup;

    private bool isPlaying = false;
    public float walkingVolume = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        if (walkingAudioSource == null)
        {
            walkingAudioSource = gameObject.AddComponent<AudioSource>();
        }

        walkingAudioSource.clip = walkingSoundClip;
        walkingAudioSource.loop = true;
        // use sfx
        walkingAudioSource.outputAudioMixerGroup = sfxMixerGroup;
        walkingAudioSource.volume = walkingVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartWalkingSound()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            walkingAudioSource.Play();
        }
    }

    public void StopWalkingSound()
    {
        if (isPlaying)
        {
            isPlaying = false;
            walkingAudioSource.Stop();
        }
    }

}
