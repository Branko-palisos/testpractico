// good practices done
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
public class EnemiesController : MonoBehaviour
{
    [SerializeField]
    internal GameObject[] meteors;
     MeteorBehaviour meteorBehaviour;
    GameManager gameManager;    
    int meteorCount;
    private void Start()
    {
        gameManager = GameManager.gameManager;  
        gameManager.SetCountInc(meteors.Length);    
        for (int i = 0; i <= meteors.Length-1; i += 1)
        {
            meteors[i].SetActive(false);   
            //  Debug.Log(this.meteors[i]);
        }
        meteors[0].SetActive(true);
    }
    internal void SpawnMeteor()
    {
        meteorCount += 1;
        
        if(meteorCount >= meteors.Length)
        {
            return;
        }
        meteors[meteorCount].SetActive(true);
    }
    void OnEnable()

    {

        MeteorBehaviour.onMeteorDestroyed += SpawnMeteor;

    }

    // para dejar de escuchar

    void OnDisable()

    {

        MeteorBehaviour.onMeteorDestroyed -= SpawnMeteor;

    }
}
