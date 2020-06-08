using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI readyText;
    [SerializeField] TextMeshProUGUI goText;
    public static bool hasStarted = false;

    private void Awake() {
        goText.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetReadyBanner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetReadyBanner()
    {
        if (!hasStarted)
        {            
            yield return new WaitForSeconds(3f);
            readyText.enabled = false;
            goText.enabled = true;
            yield return new WaitForSeconds(1f);
            goText.enabled = false;
            hasStarted = true;
        }
    }
}
