using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targetPrefabs;
    public TextMeshProUGUI scoreText;

    private float _spawnRate = 1f;
    private int _score;

    void Start(){
        _score = 0;
        UpdateScoreText(_score);
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget(){
        while(true){
            yield return new WaitForSeconds(_spawnRate);
            int index = Random.Range(0, targetPrefabs.Count);
            Instantiate(targetPrefabs[index]);
        }
    }

    public void UpdateScoreText(int scoreToAdd){
        _score += scoreToAdd;
        scoreText.text = "Score: " + _score;
    }
}
