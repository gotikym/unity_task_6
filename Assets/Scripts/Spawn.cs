using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Ball;

    void Start()
    {
        StartCoroutine(CreateBall());
    }

    private IEnumerator CreateBall()
    {
        var CreateDelay = new WaitForSeconds(2);

        while (true)
        {
            Instantiate(Ball, transform.position, Quaternion.identity);

            yield return CreateDelay;
        }
    }
}