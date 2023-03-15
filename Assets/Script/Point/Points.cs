using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Points : MonoBehaviour
{
    public int point = 0;
    public TextMeshProUGUI Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + point;  
    }

    private void OnTriggerEnter (Collider collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            point=point+1;
        }

    }

}
