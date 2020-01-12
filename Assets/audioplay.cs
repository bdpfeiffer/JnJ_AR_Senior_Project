using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class audioplay : MonoBehaviour
{
    AudioSource audioSource;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        audioSource = GetComponent<AudioSource>();
        StartCoroutine("DoCheck");
        //audioSource.Play(0);
        //Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.W)) audioSource.Play(0);
        }
        if (audioSource.isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.S)) audioSource.Stop();
        }
    }

    IEnumerator DoCheck()
    {
        for (; ; )
        {
            if (count == 2)
            {
              PlaySoundInterval(0,1);
              GameObject obj = GameObject.Find("chinaAlert");
              obj.transform.position = new Vector3(.333f, .1319f, 1.087f); 

            }else if(count == 4)
            {
              PlaySoundInterval(0,1);
              GameObject obj = GameObject.Find("russiaAlert");
              obj.transform.position = new Vector3(.333f, .1319f, 1.087f); 
            }
            else if(count == 6)
            {
              PlaySoundInterval(0,1);
              GameObject obj = GameObject.Find("nKAlert");
              obj.transform.position = new Vector3(.333f, .1319f, 1.087f); 
            }else if(count == 8)
            {
              Debug.Log("Count is 8");
              PlaySoundInterval(0,1);
              GameObject obj = GameObject.Find("iranALERT");
              obj.transform.position = new Vector3(.333f, .1319f, 1.087f); 
            }else if(count == 10)
            {
              Debug.Log("Count is 10");
              PlaySoundInterval(0,1);

              GameObject obj = GameObject.Find("russiaAlert2");
              obj.transform.position = new Vector3(.333f, .1319f, 1.087f); 
            }
            count++;
            yield return new WaitForSeconds(10f);
        }
    }

    void PlaySoundInterval(float fromSeconds, float toSeconds)
    {
        audioSource.time = fromSeconds;
        audioSource.Play();
        audioSource.SetScheduledEndTime(AudioSettings.dspTime + (toSeconds - fromSeconds));
    }
}
