using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{     
    [SerializeField] Vector3 spawnPosition;
    [SerializeField] GameObject[] enemies;
    
    private static List<GameObject> enemyList = new List<GameObject>();
    private static List<int> scenesToLoad = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        AddItemsToSceneList();
        AddEnemiesToEnemyList();
        StartCoroutine(LoadMainMenu());
        DontDestroyOnLoad(this.gameObject);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddItemsToSceneList() {
        for (int i = 2; i < 7; i++) {
            scenesToLoad.Add(i);            
        }                
    }

    void AddEnemiesToEnemyList() {
        for (int i = 0; i < 5; i++) {
            enemyList.Add(enemies[i]);
        }
    }

    IEnumerator LoadMainMenu() {        
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);                  
    }

    public void StartGame() {
        LoadRandomScene();
        LoadRandomEnemy();
    }

    public void LoadRandomScene() {        
        int randomIndex = Random.Range(2, scenesToLoad.Count);        
        int randomScene = scenesToLoad[randomIndex];        
        scenesToLoad.RemoveAt(randomIndex);
        SceneManager.LoadScene(randomScene);
    }

    public void LoadRandomEnemy() {                   
        int randomIndex = Random.Range(0, enemyList.Count);
        GameObject randomEnemy = enemyList[randomIndex];
        enemyList.RemoveAt(randomIndex);
        Instantiate(randomEnemy, spawnPosition, Quaternion.identity);
        transform.Rotate(0, -90, 0);
    }
}
