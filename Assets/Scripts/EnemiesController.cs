// good practices done
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
public class EnemiesController : MonoBehaviour
{
    [SerializeField]
    internal GameObject[] meteors;
    Count count;
    MeteorBehaviour meteorBehaviour;
    int meteorCount;
    private void Start()
    {
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