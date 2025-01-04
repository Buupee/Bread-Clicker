using UnityEngine;
using UnityEngine.EventSystems;

public class PromptUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject Prompt_Text;

    void Start()
    {
        Prompt_Text.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Prompt_Text.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Prompt_Text.SetActive(false);
    }
}
