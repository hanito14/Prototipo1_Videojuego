using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChModel : MonoBehaviour
{

    [SerializeField] private GameObject[] chModels;

    private void Awake()
    {
        ChooseCarModel(PlayerPrefs.GetInt("Character", 0));
    }
    private void ChooseCarModel(int _index)
    {
        Instantiate(chModels[_index], transform.position, Quaternion.identity, transform);
    }
}
