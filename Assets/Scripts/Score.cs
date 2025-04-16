using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance;
    [SerializeField]
    private TextMeshProUGUI _actualScoreText;
    [SerializeField]
    private TextMeshProUGUI _highScoreText;
    private int _score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _actualScoreText.text = $"{_score}";
        _highScoreText.text = $"{PlayerPrefs.GetInt("HighScore",0)}";
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = $"{_score}";
        }
    }

    public void UpdateScore()
    {
        _score++;
        _actualScoreText.text = $"{_score}";
        UpdateHighScore();
    }
}
