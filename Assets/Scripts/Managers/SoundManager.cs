using UnityEngine;
using Singleton;
public class SoundManager : Singleton<SoundManager>
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void PlaySound(int idx)
    {
		audioSource.PlayOneShot(audioClips[idx]);
    }
}
