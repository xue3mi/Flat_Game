using UnityEngine;
using UnityEngine.UI;

public class buttonSoundEffect : MonoBehaviour
{
    public Button myButton;
    public AudioSource audioSource;
    public AudioClip buttonClickSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //add button click event
        myButton.onClick.AddListener(PlayButtonClickSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayButtonClickSound()
    {
        audioSource.PlayOneShot(buttonClickSound); // play sound
    }

}
