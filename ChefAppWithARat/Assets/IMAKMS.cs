using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IMAKMS : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI item1;
    [SerializeField]
    public TextMeshProUGUI amount1;
    [SerializeField]
    public TextMeshProUGUI cost1;
    [SerializeField]
    float price;
    [SerializeField]
    float amu;
    [SerializeField]
    float cos;
    [SerializeField]
    public TextMeshProUGUI total1;
    // Start is called before the first frame update
    void Start()
    {
        
        cost1 = PlayerPrefs.GetFloat(amount1.);
        price = cos * amu;

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
