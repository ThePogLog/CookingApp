using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompleteTotal : MonoBehaviour
{
    [SerializeField]
    public Text total1;
    [SerializeField]
    public Text total2;
    [SerializeField]
    public Text total3;
    [SerializeField]
    public Text total4;
    [SerializeField]
    public Text total5;
    [SerializeField]
    public Text total6;
    [SerializeField]
    public Text FINALTOTAL;
    
    float TOTALPRICE;

    float tot1; 

    float tot2;
    float tot3;
    float tot4;
    float tot5;
    float tot6;

    // Start is called before the first frame update
    void Start()
    {
    }
    public void theCost()
    {
        float.TryParse(FINALTOTAL.text, out TOTALPRICE);
        float.TryParse(total1.text, out tot1);
        float.TryParse(total2.text, out tot2);
        float.TryParse(total3.text, out tot3);
        float.TryParse(total4.text, out tot4);
        float.TryParse(total5.text, out tot5);
        float.TryParse(total6.text, out tot6);


        TOTALPRICE = tot1 + tot2 + tot3 + tot4 + tot5 + tot6;
        FINALTOTAL.text = TOTALPRICE.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
