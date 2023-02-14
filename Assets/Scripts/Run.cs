using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] private float _speed;
 
    public void Start()
    {
        StartCoroutine(Move());
    }

    public IEnumerator Move()
    {
        while (true)
        {
            Vector2 targetVector = transform.position + transform.right;

            transform.position = Vector2.MoveTowards(transform.position, targetVector, _speed);

            yield return null;
        }
    }
}