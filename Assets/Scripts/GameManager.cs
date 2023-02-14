using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;

    private int _computerScore;

    public Ball ball;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    public void PlayerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
    }

    public void ComputerScores() 
    { 
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
       this.ball.ResetPosition();
    }
}
