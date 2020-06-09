using Invector.vCharacterController.v2_5D;
using Invector.vCharacterController.AI;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RemoveHealth : MonoBehaviour
{
    [SerializeField] private Image[] images;
    [SerializeField] v2_5DController controller;    
    [SerializeField] v_AIController aiController;   
    GameManager gameManager; 
    private bool loadVerifier = true;

    private void Start() {
        if(gameObject.tag == "Player") {
            controller = GetComponent<v2_5DController>();
        }
        else if (gameObject.tag == "Enemy") {
            aiController = GetComponent<v_AIController>();
        }        

        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update() {
        if (gameObject.tag == "Enemy" && aiController.currentHealth == 0 && loadVerifier) {
            loadVerifier = false;
            StartCoroutine(LoadNextLevel());
        }
    }

    IEnumerator LoadNextLevel() {
        yield return new WaitForSeconds(5f);        
        gameManager.AddToCurrentScene(1);        
        gameManager.LoadNextScene();
    }

    public void HealthRemover() {
        if (gameObject.tag == "Player") {        
            switch(controller.currentHealth) {
                case 0:
                    images[0].enabled = false;                
                    break;
                case 1:
                    images[1].enabled = false;                
                    break;
                case 2:
                    images[2].enabled = false;                
                    break;
            }
        }
        else if (gameObject.tag == "Enemy") {
            switch (aiController.currentHealth)
            {
                case 0:
                    images[0].enabled = false;
                    break;
                case 1:
                    images[1].enabled = false;
                    break;
                case 2:
                    images[2].enabled = false;
                    break;
            }
        }
    }
}
