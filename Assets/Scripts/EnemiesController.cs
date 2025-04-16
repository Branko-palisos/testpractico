using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemiesController : MonoBehaviour
{
    [SerializeField]
  internal  GameObject[] Meteor;
    MeteorBehaviour meteorBehaviour;
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i <= 3; i += 1) 
        {
            Meteor[i].SetActive(false);             
        }
    }    
    // Update is called once per frame
}