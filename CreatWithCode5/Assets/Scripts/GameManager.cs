using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;
    private int _score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private float _spawnRate = 1f;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    public int difficulty;
    // Start is called before the first frame update
    
    
    
    private IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(_spawnRate);
            var index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        } 
    }
    
    public void UpdateScore(int scoreToAdd)
    {
        _score += scoreToAdd;
        scoreText.text = "Score:" + _score;
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty)
    {
        _spawnRate /= difficulty;
        titleScreen.gameObject.SetActive(false);
        isGameActive = true;
        _score = 0;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        
    }

}
