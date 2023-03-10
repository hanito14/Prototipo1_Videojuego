using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> listaResiduos = new List<GameObject>();
    [SerializeField]

    int direction => Random.Range(0, 2) ;

    float difficultTime = 5;


    void Start()
    {
        StartCoroutine(SpawnWaste());
    }
    IEnumerator SpawnWaste()
    {
        while (true)
        {
            yield return new WaitForSeconds(difficultTime);

            difficultTime -= 0.1f;

            if (difficultTime <= 0.5)
            {
                difficultTime = 0.5f;
            }

            Debug.Log(difficultTime);

            Debug.Log(direction);
            
            if (direction == 0)
            {
                float upForce = Random.Range(9f, 12f);
                int prefabIndex = Random.Range(0, listaResiduos.Count);


                GameObject instance = Instantiate(listaResiduos[prefabIndex], transform.position, Quaternion.identity);

                Rigidbody prefabRigidbody = instance.GetComponent<Rigidbody>();

                prefabRigidbody.AddForce(new Vector2(3f, upForce), ForceMode.Impulse);
            }
            else
            {

                float upForce = Random.Range(9f, 12f);
                int prefabIndex = Random.Range(0, listaResiduos.Count);


                GameObject instance = Instantiate(listaResiduos[prefabIndex], new Vector3(-transform.position.x, transform.position.y) , Quaternion.identity);

                Rigidbody prefabRigidbody = instance.GetComponent<Rigidbody>();

                prefabRigidbody.AddForce(new Vector2(-3f, upForce), ForceMode.Impulse);
            }


        }
    }
}
