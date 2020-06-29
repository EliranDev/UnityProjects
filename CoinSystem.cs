using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public static int coins = 0;
    Text coin;

    // Start is called before the first frame update
    void Start()
    {
        coin = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coin.text = coins.ToString();
    }
}
