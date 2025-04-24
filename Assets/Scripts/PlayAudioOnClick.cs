using UnityEngine;
using System.Collections.Generic;

public class audioController : MonoBehaviour
{
    public AudioSource audiofile;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        audiofile.Play();
    }
}
