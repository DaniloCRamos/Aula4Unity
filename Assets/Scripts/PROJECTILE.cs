using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROJECTILE : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        ApplyMoviment();
    }
    void ApplyMoviment()
    {
        transform.Translate(Time.deltaTime * speed * Vector3.up);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
