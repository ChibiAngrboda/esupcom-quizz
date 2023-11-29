using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musiques;
    public int[] musicStarterTimers;
    public int currentTrack;
    private AudioSource source;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MusicStart()
    {
        GetComponent<AudioSource>().clip = musiques[currentTrack];
        print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        source.Play();
    }

    public void skipMusic()
    {
        source.Stop();
        currentTrack++;
        isPaused = false;
        GetComponent<AudioSource>().clip = musiques[currentTrack];
        GetComponent<AudioSource>().time = musicStarterTimers[currentTrack];
        print(musicStarterTimers[currentTrack]);
        source.Play();
    }


    public void PauseMusic()
    {
        if(!isPaused)
        {
            source.Pause();
            isPaused = true;
            print("ATTENTION JE PAUSE LA BOMBA");
        }
        else
        {
            source.UnPause();
            isPaused = false;
            print("ATTENTION JE DE-PAUSE LA BOMBA");
        }
        
    }
}
