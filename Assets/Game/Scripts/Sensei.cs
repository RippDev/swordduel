using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensei : MonoBehaviour
{
    Animator animator;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        StartCoroutine(WaitingForGo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitingForGo() {
        yield return new WaitForSeconds(2.8f);
        animator.SetTrigger("goTrigger");
        yield return new WaitForSeconds(0.3f);
        audio.Play();
    }
}
