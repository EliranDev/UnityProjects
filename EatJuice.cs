using UnityEngine;

public class EatJuice : MonoBehaviour
{
    public GameObject Juice;
    public int JuiceFrameCount;
    private int TimeClone;

    void Update()
    {
        TimeClone = Time.frameCount;

        if (TimeClone % JuiceFrameCount == 0)
        {
            CloneJuice(Juice);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Juice"))
        {
            Destroy(collision.gameObject);
            PlayerMovment.speed = 17;
        }
    }

    void CloneJuice(GameObject gameObject)
    {
        bool JuiceCloned = false;

        while (!JuiceCloned)
        {
            Vector3 pos = new Vector3(Random.Range(-19.41f, 19.41f), Random.Range(-12.17f, 12.17f));
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
