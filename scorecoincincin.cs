using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecoincincin : MonoBehaviour
{
    public static int hitungcoin;
    Text hitungcointext;
    // Start is called before the first frame update
    void Start()
    {
        hitungcoin = 0;
        hitungcointext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hitungcointext.text = hitungcoin.ToString();
    }
}
