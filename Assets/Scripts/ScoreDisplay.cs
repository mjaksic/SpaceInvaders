using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    public Text txt;

    // Use this for initialization
    void Start()
    {
        txt.text = "Score: " + ScoreCounter.counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + ScoreCounter.counter.ToString();
    }
}