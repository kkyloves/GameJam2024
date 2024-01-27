using UnityEngine;

public class BedController : MonoBehaviour
{
    [SerializeField] private Sprite defaultSprite;
    
    public void TurnOffLamp()
    {
        GetComponent<SpriteRenderer>().sprite = defaultSprite;
    }

}
