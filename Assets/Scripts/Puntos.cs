using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public static int numPoints;
    void Start()
    {
        score.text = "Puntos: ";
        numPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Puntos: "+numPoints;
    }
    //Puntos
}
