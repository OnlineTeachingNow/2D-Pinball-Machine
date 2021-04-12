// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] Text _livesText;
    [SerializeField] Button _gameOverButton;
    [SerializeField] Button _replayButton;
    float _score = 0;
    int _lives = 3;
        
    void Start() 
    {
        _gameOverButton.gameObject.SetActive(false);
        _replayButton.gameObject.SetActive(false);
        _scoreText.text = _score.ToString();
        _livesText.text = _lives.ToString();
    }

    public void IncreaseScore(float value)
    {
        _score += value;
        _scoreText.text = _score.ToString();
    }

    public void DecreaseLives()
    {
        _lives--;
        _livesText.text = _lives.ToString();
        if (_lives <= 0)
        {
            _gameOverButton.gameObject.SetActive(true);
            _replayButton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void NewGame()
    {
        _gameOverButton.gameObject.SetActive(false);
        _replayButton.gameObject.SetActive(false);
        _lives = 3;
        _livesText.text = _lives.ToString();
        _score = 0;
        _scoreText.text = _score.ToString();
        Time.timeScale = 1;
    }
}
