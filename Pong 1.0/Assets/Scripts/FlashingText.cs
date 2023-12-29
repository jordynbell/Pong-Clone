using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FlashingText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text myText;

    void Start()
    {
        myText = GetComponentInChildren<Text>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        myText.color = Color.gray;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        myText.color = Color.white;
    }
}