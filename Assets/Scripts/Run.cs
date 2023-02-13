using System.Collections;
using UnityEngine;

public class Run : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Move());
    }

    public IEnumerator Move()
    {
        while (true)
        {
            Vector2 targetVector = transform.position + transform.right;

            transform.position = Vector2.MoveTowards(transform.position, targetVector, 0.05f);

            yield return null;
        }
    }
}