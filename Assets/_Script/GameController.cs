using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
<<<<<<< HEAD
    private int _scoreValues;
    private int _livesValues; 
    
    //PUBLIC INSTANCE VARIABLES
    public EnemyController helicopter;

    public int ScoreValues
    {
        get
        {
            return this._scoreValues;
        }

        set
        {
            Debug.Log(ScoreValues);
            this._scoreValues = value;
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
            Debug.Log(LivesValues);
            this._livesValues = value;
        }
    }

    // Use this for initialization
    void Start () {
=======
    
    public EnemyController helicopter;
	// Use this for initialization
	void Start () {
>>>>>>> 7b65b498807430c6c1adabafa7daf7d77ecc8804
        this._init();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //PRIVATE METHODS
    private void _init()
    {
<<<<<<< HEAD
        this.ScoreValues = 0;
        this.LivesValues = 5;
=======
       
>>>>>>> 7b65b498807430c6c1adabafa7daf7d77ecc8804
    }
}
