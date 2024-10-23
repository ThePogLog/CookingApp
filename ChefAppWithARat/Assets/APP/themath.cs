using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class themath : MonoBehaviour
{
    
    [SerializeField]
    TMP_InputField item; 
    [SerializeField]
    TMP_InputField amount;
    [SerializeField]
    TMP_InputField cost;
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float itemcost = -1;
            Debug.Log(amount.text);
            Debug.Log(float.TryParse(cost.text, out itemcost));
            float itemamount = -1;
            Debug.Log(float.TryParse(amount.text, out itemamount));
            Debug.Log(itemamount * itemcost);

        }
    }
}






//https://www.youtube.com/watch?v=2liZtyMhIQQ