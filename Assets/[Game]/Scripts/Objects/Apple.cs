using UnityEngine;

public class Apple : CollectableBase
{
    #region Constructor
    public Apple()
    {
        action = "Ye";
    }
    #endregion

    #region Override Methods
    public override void Use()
    {
        Debug.Log("Can artti.");
        base.Dispose();
    }
    #endregion
}
