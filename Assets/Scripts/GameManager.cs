using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targetPrefabs;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    private float _spawnRate = 1f;
    private int _score;
    public bool isGameActive;

    void Start(){
        isGameActive = true;
        _score = 0;
        UpdateScoreText(_score);
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget(){
        while(isGameActive){
            yield return new WaitForSeconds(_spawnRate);
            int index = Random.Range(0, targetPrefabs.Count);
            Instantiate(targetPrefabs[index]);
        }
    }

    public void UpdateScoreText(int scoreToAdd){
        _score += scoreToAdd;
        scoreText.text = "Score: " + _score;
    }

    public void GameOver(){
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
