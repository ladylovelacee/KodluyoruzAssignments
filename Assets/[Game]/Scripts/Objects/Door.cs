using UnityEngine;

public class Door : CollectableBase
{
    public Door()
    {
        base.action = "Ac";
    }

    public override void Use()
    {
        Debug.Log("Baska diyarlara gecis.");
        base.Dispose();
    }
}
