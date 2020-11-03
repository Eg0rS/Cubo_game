using System.Collections;
using System.Collections.Generic;
using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class football : MonoBehaviour
{
    public int score = 0;
    public Text ScoreText;
    private AudioSource aud;
    public AudioSource tree_goals;
    void Start()
    {
        aud = GetComponent<AudioSource>();
        
    }
    void Update() {
        ScoreText.text ="Score " + score;
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("goal")) {
            score++;
            aud.Play();
            if (score == 3) {
                tree_goals.Play();
            }
        }
    }
}
