using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Score : MonoBehaviour
{
    static float scoreRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreMultiplier.hasHit && !Timer.running)
        {
            scoreRate = 1;
        }
    }
}
