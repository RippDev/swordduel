using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermediateScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextScene());
    }

    IEnumerator NextScene() {
        GameObject.Find("GameManager").GetComponent<GameManager>().AddToCurrentScene(1);
        yield return new WaitForSeconds(6f);
        GameObject.Find("GameManager").GetComponent<GameManager>().LoadNextScene();
    }
}
