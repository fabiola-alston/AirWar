using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject airplanePrefab;
    private Avion avion;


    void Start()
    {
        avion.prefab = airplanePrefab;

    }

    void Update()
    {
        
    }
}
