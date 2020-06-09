using System.Collections;
using System.Collections.Generic;
using Invector.vCharacterController;
using UnityEngine;

public class PlayerCanStart : MonoBehaviour
{
    private vMeleeCombatInput combatInput;
    
    // Start is called before the first frame update
    void Start()
    {
        combatInput = GetComponent<vMeleeCombatInput>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("StageManager").GetComponent<StageManager>().GetHasStarted()) {
            combatInput.enabled = false;
        } else {
            combatInput.enabled = true;
        }
    }
}
