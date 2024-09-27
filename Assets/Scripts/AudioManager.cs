using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource introState;
    public AudioSource normalState;
    
    // Start is called before the first frame update
    void Start()
    {
        introState.Play();

        StartCoroutine(SwitchToNormalState(3f));
    }

    private IEnumerator SwitchToNormalState(float delay)
    {
        yield return new WaitForSeconds(delay);
        
        introState.Stop();
        normalState.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
