using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    int spacePressed = 0;

    public GameObject ScoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ++spacePressed;

            ScoreText.GetComponent<Text>().text = "SpaceBar: " + spacePressed;
            Debug.Log(spacePressed);
        }
    }
}
