using UnityEngine;

public class characterTalking : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;

    //numbers of time to play
    public int playCount = 3;
    //sec between each played
    public float timeBetweenPlays = 1f;
    private int timesPlayed = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerSoundEffect()
    {
        timesPlayed = 0;
        PlaySoundEffect();
    }

    private void PlaySoundEffect()
    {
        if (timesPlayed < playCount)
        {
            audioSource.PlayOneShot(soundEffect);
            timesPlayed++;
            if (timesPlayed < playCount)
            {
                Invoke("PlaySoundEffect", timeBetweenPlays); //delay next sound to be played
            }
        }
    }
}
