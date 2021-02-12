using UnityEngine;

public class Door : CollectableBase
{
    #region Constructor
    public Door()
    {
        base.action = "Ac";
    }
    #endregion

    #region Override Methods
    public override void Use()
    {
        Debug.Log("Baska diyarlara gecis.");
        base.Dispose();
    }
    #endregion
}s
