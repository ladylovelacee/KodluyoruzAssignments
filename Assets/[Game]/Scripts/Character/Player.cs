using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0;
    CollectableBase obj;
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
            transform.Translate(-transform.forward * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.W))
            transform.Translate(transform.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E) && obj != null)
            obj.Use();
    }

    private void OnTriggerEnter(Collider other)
    {
        obj = other.GetComponent<CollectableBase>();
        if(obj != null)
        {
            obj.Collect();
        }
    }
}
