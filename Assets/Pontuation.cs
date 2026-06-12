using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuation : MonoBehaviour
{
    float points = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }

    // Update is called once per frame
    public void AddPoints()
    {
        points++;
        scoreText.text = points.ToString();
    }
}
