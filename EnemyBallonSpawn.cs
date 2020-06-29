using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBallonSpawn : MonoBehaviour
{
    public GameObject Ballon;
    public int BallonFrameCount;
    private int TimeClone;

    void Update()
    {
        TimeClone = Time.frameCount;
        Debug.Log(TimeClone);

        if (TimeClone % BallonFrameCount == 0)
        {
            CloneBallon(Ballon);
        }
    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBallon"))
        {
            Destroy(collision.gameObject);
        }
    }*/

    void CloneBallon(GameObject gameObject)
    {
        bool JuiceCloned = false;

        while (!JuiceCloned)
        {
            Vector3 pos = new Vector3(-21.99f, 12.87f, -11.68f);
            if ((pos - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                PlayerMovment.speed = 10;
                Instantiate(gameObject, pos, gameObject.transform.rotation);
                JuiceCloned = true;
            }
        }
    }
}
