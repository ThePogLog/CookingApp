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
        
        cost1.text = PlayerPrefs.GetFloat(amount1.text).ToString();
        price = cos * amu;
        total1.text = price.ToString();
        

    }
    public void totalCost()
    {
        total1.text = price.ToString();
    }
    private void amountOne(object sender, EventArgs e)
    {
        double amu = double.Parse(amount1.text);
        System.Diagnostics.Debug.WriteLine(amu);
        double cos = double.Parse(cost1.text);
        System.Diagnostics.Debug.WriteLine(cos);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}