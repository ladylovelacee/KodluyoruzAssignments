using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables
    [SerializeField] float moveSpeed = 0;
    CollectableBase obj;
    #endregion

    #region Update
    void Update()
    {
        PlayerController();

        if (Input.GetKeyDown(KeyCode.E) && obj != null)
            obj.Use();
    }
    #endregion

    #region Private Methods
    void PlayerController()
    {
        if (Input.GetKey(KeyCode.S))
            transform.Translate(-transform.forward * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.W))
            transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
    }
    #endregion

    #region OnTrigger
    private void OnTriggerEnter(Collider other)
    {
        obj = other.GetComponent<CollectableBase>();
        if (obj != null)
        {
            obj.Collect();
        }
    }
    #endregion
}