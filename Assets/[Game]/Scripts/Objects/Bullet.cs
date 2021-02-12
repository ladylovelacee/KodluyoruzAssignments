using UnityEngine;

public class Bullet : CollectableBase
{
    #region Constructor
    public Bullet()
    {
        base.action = "Vur onu!";
    }
    #endregion

    #region Override Methods
    public override void Use()
    {
        Debug.Log("Ates edildi.");
        base.Dispose();
    }

    #endregion
}
