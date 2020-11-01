
using UnityEngine;
using UnityEngine.UI;
public class Difficulty : MonoBehaviour
{
    private Button _button;
    private GameManager _gameManager;
    public int difficulty;
    private void Start()
    {
        _button = GetComponent<Button>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _button.onClick.AddListener(SetDifficulty);
        
    }

    void SetDifficulty()
    {
        Debug.Log(_button.gameObject.name + "was clicked");
        _gameManager.StartGame(difficulty);
    }
    
}
