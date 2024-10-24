using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AHHHH : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField item1;
    [SerializeField]
    public TMP_InputField amount1;
    [SerializeField]
    public TMP_InputField cost1;
    [SerializeField]
    float price;
    [SerializeField]
    float amu;
    [SerializeField]
    float cos;
    [SerializeField]
    public Text total1;
    // Start is called before the first frame update
    void Start()
    {
        amount1.text = PlayerPrefs.GetFloat(amount1.text).ToString();
        cost1.text = PlayerPrefs.GetFloat(cost1.text).ToString();
        price = cos * amu;
        total1.text = price.ToString();
        
        

    }
    public void totalCost()
    {
        amountOne();
        price = cos * amu;
        Debug.Log(price);
        total1.text = price.ToString();
    }
    private void amountOne()
    {
        amu = 0;
        float.TryParse(amount1.text, out amu);
        //Debug.Log(amu);
        cos = 0;
        float.TryParse(cost1.text, out cos);
        //Debug.Log(cos);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
