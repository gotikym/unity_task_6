using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {       
            Destroy(collision.gameObject);        
    }
}