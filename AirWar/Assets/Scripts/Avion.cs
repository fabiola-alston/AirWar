using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{
    public GameObject prefab;
    private GameObject instance;
    public int combustible;

    public void CrearAvion(Vector3 position)
    {
        instance = Instantiate(prefab, position, Quaternion.identity);
        instance.name = "Airplane";
    }

    public void Despegar()
    {

    }

    public void StandBy()
    {

    }

    public void Aterrizar()
    {

    }

}
