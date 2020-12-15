using UnityEngine;

public abstract class CollectableBase : MonoBehaviour, ICollectable
{
    public string action;

    public virtual void Collect()
    {
        Debug.Log(action);
    }

    public virtual void Dispose()
    {
        Destroy(gameObject);
    }

    public abstract void Use();

}
