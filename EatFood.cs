using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    public GameObject Food;

    void Start()
    {
        CloneFood(Food);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);

            ScoreSystem.scoreValue++;

            CoinSystem.coins += 5;

            CloneFood(Food);
        }
    }

    void CloneFood(GameObject FoodGameObject)
    {
        bool FoodCloned = false;

        while (!FoodCloned)
        {
            Vector3 FoodPos = new Vector3(Random.Range(-19.41f, 19.41f), Random.Range(-12.17f, 12.17f), -8.84f);
            if ((FoodPos - transform.position).magnitude < 3) 
            { 
                continue;
            }
            else
            {
                Instantiate(FoodGameObject, FoodPos, FoodGameObject.transform.rotation);
                FoodCloned = true;
            }
        }
    }
}
