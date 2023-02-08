using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> listaResiduos = new List<GameObject>();
    [SerializeField]
    float baseTime = 2f;

    

    void Start()
    {
        StartCoroutine(SpawnWaste());
    }
    IEnumerator SpawnWaste()
    {
        while (true)
        {
            yield return new WaitForSeconds(baseTime);

            float upForce = Random.Range(10f, 13f);
            int prefabIndex = Random.Range(0, listaResiduos.Count);

            GameObject instance = Instantiate(listaResiduos[prefabIndex], new Vector2(-2.5f, -4.5f), Quaternion.identity);

            Rigidbody prefabRigidbody = instance.GetComponent<Rigidbody>();

            prefabRigidbody.AddForce(new Vector2(3f, upForce), ForceMode.Impulse);

            
        }
    }
}
