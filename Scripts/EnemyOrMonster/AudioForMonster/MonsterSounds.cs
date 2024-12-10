using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSounds : MonoBehaviour
{
    
    // is this a specific clip or the componenet of monster audio source 
    public AudioSource source;
    public AudioClip walkingClip;

    // Start is called before the first frame update
    void Start()
    {
        source.PlayOneShot(walkingClip);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
