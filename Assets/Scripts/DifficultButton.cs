using UnityEngine;
using UnityEngine.UI;

public class DifficultButton : MonoBehaviour
{
    private Button _button;
    private GameManager _gameManager;
    public int difficulty;

    void Start(){
        _button = GetComponent<Button>();
        _gameManager = FindObjectOfType<GameManager>();

        _button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty(){
        _gameManager.StartGame(difficulty);
    }
}
