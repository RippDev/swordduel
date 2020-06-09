using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{        
    [SerializeField] int currentScene;
    
    //private static List<GameObject> enemyList = new List<GameObject>();
    //private static List<int> scenesToLoad = new List<int>();

    // Start is called before the first frame update
    void Start()
    {        
        StartCoroutine(LoadMainMenu());
        DontDestroyOnLoad(this.gameObject);
    }

    /*void AddItemsToSceneList() {
        for (int i = 2; i < 4; i++) {
            scenesToLoad.Add(i);            
        }                
    }

    void AddEnemiesToEnemyList() {
        for (int i = 0; i < 5; i++) {
            enemyList.Add(enemies[i]);
        }
    }*/

    IEnumerator LoadMainMenu() {        
        currentScene = 1;        
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(currentScene);
        currentScene += 1;        
    }

    public void StartGame() {
        SceneManager.LoadScene(2);        
    }

    public void LoadNextScene() {        
        if (currentScene == SceneManager.sceneCountInBuildSettings) {
            StartCoroutine(LoadMainMenu());
        } else {            
            SceneManager.LoadScene(currentScene);
        }
    }

    /*IEnumerator LoadRandomScene() {        
        int randomIndex = Random.Range(2, scenesToLoad.Count);        
        int randomScene = scenesToLoad[randomIndex];        
        scenesToLoad.RemoveAt(randomIndex);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(randomScene);
    } */   

    public int GetCurrentScene() {
        return currentScene;
    }

    public void AddToCurrentScene(int value) {
        currentScene += value;
    }

    /*public void LoadRandomEnemy() {                   
        int randomIndex = Random.Range(0, enemyList.Count);
        GameObject randomEnemy = enemyList[randomIndex];
        enemyList.RemoveAt(randomIndex);
        Instantiate(randomEnemy, spawnPosition, Quaternion.identity);
        transform.Rotate(0, -90, 0);
    }*/
}
