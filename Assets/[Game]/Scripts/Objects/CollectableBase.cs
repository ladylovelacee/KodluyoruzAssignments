using UnityEngine;

public abstract class CollectableBase : MonoBehaviour, ICollectable
{
    #region Variables
    public string action;
    #endregion

    #region Virtual Methods
    public virtual void Collect()
    {
        Debug.Log(action);
    }

    public virtual void Dispose()
    {
        Destroy(gameObject);
    }
    #endregion

    #region Abstract Methods
    public abstract void Use();
    #endregion
}