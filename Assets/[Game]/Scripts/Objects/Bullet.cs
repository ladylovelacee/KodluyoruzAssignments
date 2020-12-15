using UnityEngine;

public class Bullet : CollectableBase
{
    public Bullet()
    {
        base.action = "Vur onu!";
    }

    public override void Use()
    {
        Debug.Log("Ates edildi.");
        base.Dispose();
    }
}
