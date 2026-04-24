using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addpoints : MonoBehaviour
{
    public LixoSpawnerControllera lixoSpawnerControllera;
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Lixo")){
            Destroy(collision.gameObject);
            lixoSpawnerControllera.AddToPoints(1);
        }
    }
}
