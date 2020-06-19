using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   [SerializeField]
    private float lifeTime = 1f;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
