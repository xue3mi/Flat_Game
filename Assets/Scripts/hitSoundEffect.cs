using UnityEngine;

public class hitSoundEffect : MonoBehaviour
{
    public AudioSource wallAudioSource;  // Reference to AudioSource
    public AudioClip collisionSound;     // Sound to play on collision

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (wallAudioSource == null)
        {
            wallAudioSource = GetComponent<AudioSource>();  // Get AudioSource if not assigned
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the "Character" tag
        if (collision.gameObject.CompareTag("Character"))
        {
            PlayCollisionSound();
        }
    }

    // Function to play the collision sound
    private void PlayCollisionSound()
    {
        if (wallAudioSource != null && collisionSound != null)
        {
            wallAudioSource.PlayOneShot(collisionSound);
        }
    }
}
