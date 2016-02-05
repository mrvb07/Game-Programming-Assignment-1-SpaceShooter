using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _scoreValues;
    private int _livesValues;
    [SerializeField]
    private AudioSource _gameOverSound;
    [SerializeField]
    private AudioSource _skySound; 
    
    //PUBLIC INSTANCE VARIABLES
    public EnemyController helicopter;
    public Text ScoreLabel;
    public Text LivesLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public PlayerController player;
    public CoinController Coin5;
    public CoinController Coin25;
    public CoinController Coin100;
    public CoinController Coin500;
    public EnemyController Enemy1;
    public EnemyController Enemy2;
    public EnemyController Enemy3;
    public EnemyPlaneController EnemyPlane;
    public Button RestartButton;

    public int ScoreValues
    {
        get
        {
            return this._scoreValues;
        }

        set
        {
            this._scoreValues = value;
            this.ScoreLabel.text = "Score: " + this._scoreValues;
        }
    }

    public int LivesValues
    {
        get
        {
            return this._livesValues;
        }

        set
        {
            this._livesValues = value;
            if (this._livesValues <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValues;
            }
            
        }
    }
	// Use this for initialization
	void Start () {
        this._init();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //PRIVATE METHODS
    private void _init()
    {
        this.ScoreValues = 0;
        this.LivesValues = 5;
        this.HighScoreLabel.enabled = false;
        this.GameOverLabel.enabled = false;
        this._gameOverSound.Stop();
        this.RestartButton.gameObject.SetActive(false);

    }

    private void _endGame()
    {
        this.HighScoreLabel.text = "HighScore: "+ this._scoreValues;
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.GameOverLabel.enabled = true;
        this.HighScoreLabel.enabled = true;
        this.player.gameObject.SetActive(false);
        this.Enemy1.gameObject.SetActive(false);
        this.Enemy2.gameObject.SetActive(false);
        this.Enemy3.gameObject.SetActive(false);
        this.EnemyPlane.gameObject.SetActive(false);
        this.Coin5.gameObject.SetActive(false);
        this.Coin500.gameObject.SetActive(false);
        this.Coin25.gameObject.SetActive(false);
        this.Coin100.gameObject.SetActive(false);
        this._gameOverSound.Play();
        this._skySound.Stop();
        this.RestartButton.gameObject.SetActive(true);
    }

    public void restartButton()
    {
        Application.LoadLevel("Main");
        this.RestartButton.gameObject.SetActive(false);
    }
}
