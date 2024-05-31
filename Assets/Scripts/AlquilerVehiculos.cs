using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

        }   
    }

    void ResetearVehiculos()
    {
        //desactivar todos los elementos del array
        DesactivarTodosLosElementos();
        //activar solo el primer elemento
        vehiculos[0].SetActive(true);
    }

    void DesactivarTodosLosElementos()
    {
        for (int i = 0; i<vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}
