﻿using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
    //PRIVATE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _enemySound;
    private AudioSource _coinSound;

    //PUBLIC VARIABLES
    public GameController gameController; 

    // Use this for initialization
    void Start () {
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._enemySound = this._audioSources[1];
        this._coinSound = this._audioSources[2];
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin5"))
        {
            this._coinSound.Play();
            this.gameController.ScoreValues += 5;
            
        }
        if (other.gameObject.CompareTag("Coin500"))
        {
            this._coinSound.Play();
            this.gameController.ScoreValues += 500;
        }
        if (other.gameObject.CompareTag("Coin25"))
        {
            this._coinSound.Play();
            this.gameController.ScoreValues += 25;
        }
        if (other.gameObject.CompareTag("Coin100"))
        {
            this._coinSound.Play();
            this.gameController.ScoreValues += 100;
        }
        if (other.gameObject.CompareTag("EnemySmall"))
        {
            this._enemySound.Play();
            this.gameController.LivesValues -= 1;
        }
        if (other.gameObject.CompareTag("EnemyLarge"))
        {
            this._enemySound.Play();
            this.gameController.LivesValues -= 1;
        }
    }
}
