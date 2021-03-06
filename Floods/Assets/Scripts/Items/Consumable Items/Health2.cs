using UnityEngine;

public class Health2 : Consumable
{
    Sprite spriteToReturn;

    public void Awake()
    {
        Texture2D texure2D = Resources.Load<Texture2D>("Sprites/Items/Consumables/Health2");
        spriteToReturn = Sprite.Create(
            texure2D,
            new Rect(0, 0, texure2D.width, texure2D.height),
            new Vector2(0.5f, 0.5f));
    }

    public override int ID
    {
        get => 1;
    }

    public override string Description
    {
        get => "Health Lv.2";
    }

    public override Sprite Sprite
    {
        get => spriteToReturn;
    }

    public override bool Use()
    {
        Debug.Log(Description + "used");
        return true;
    }
}
