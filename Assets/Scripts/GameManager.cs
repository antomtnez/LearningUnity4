using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targetPrefabs;

    private float _spawnRate = 1f;

    void Start(){
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget(){
        while(true){
            yield return new WaitForSeconds(_spawnRate);
            int index = Random.Range(0, targetPrefabs.Count);
            Instantiate(targetPrefabs[index]);
        }
    }
}
