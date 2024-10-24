using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField]
    float TOTALPRICE;
    // Start is called before the first frame update
    void Start()
    {
        TOTALPRICE = total1.ToString(); 
        FINALTOTAL.text = TOTALPRICE;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
