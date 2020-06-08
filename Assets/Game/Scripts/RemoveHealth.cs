using Invector.vCharacterController.v2_5D;
using Invector.vCharacterController.AI;
using UnityEngine;
using UnityEngine.UI;

public class RemoveHealth : MonoBehaviour
{
    [SerializeField] private Image[] images;
    [SerializeField] v2_5DController controller;    
    [SerializeField] v_AIController aiController;    

    private void Start() {
        if(gameObject.tag == "Player") {
            controller = GetComponent<v2_5DController>();
        }
        else if (gameObject.tag == "Enemy") {
            aiController = GetComponent<v_AIController>();
        }        
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
