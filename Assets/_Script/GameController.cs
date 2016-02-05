using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _scoreValues;
    private int _livesValues; 
    
    //PUBLIC INSTANCE VARIABLES
    public EnemyController helicopter;
    public Text ScoreLabel;
    public Text LivesLabel;

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
            this.LivesLabel.text = "Lives: " + this._livesValues;
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

    }
}
