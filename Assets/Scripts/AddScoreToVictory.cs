using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreToVictory : MonoBehaviour
{
    public VictoryBool victory;
    // Start is called before the first frame update

    private void Start()
    {
        victory = FindObjectOfType<VictoryBool>();
    }

    private void OnDestroy()
    {
        victory.counter++;
    }
}
