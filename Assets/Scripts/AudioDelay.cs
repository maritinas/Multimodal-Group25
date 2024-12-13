using UnityEngine;
using System.Collections;

public class AudioDelay : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public float delay = 1f;        // Delay in seconds before audio starts playing

    private void Start()
    {
        // Start the coroutine to play the audio after a delay
        StartCoroutine(PlayAudioWithDelay());
    }

    private IEnumerator PlayAudioWithDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Play the audio
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned.");
        }
    }
}
