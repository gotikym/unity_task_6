using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Ball ball;

    void Start()
    {
        StartCoroutine(CreateBall());
    }

    private IEnumerator CreateBall()
    {
        float delay = 2;
        var createDelay = new WaitForSeconds(delay);

        while (true)
        {
            Instantiate(ball, transform.position, Quaternion.identity);

            yield return createDelay;
        }
    }
}