using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
            transform.Translate(-transform.forward * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.W))
            transform.Translate(transform.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            EventManager.OnCollecting.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        var obj = other.GetComponent<CollectableBase>();
        if(obj != null)
        {
            obj.Collect();
            EventManager.OnCollecting.AddListener(obj.Use);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var obj = other.GetComponent<CollectableBase>();
        if (obj != null)
        {
            EventManager.OnCollecting.RemoveListener(obj.Use);
        }
    }
}
