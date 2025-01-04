using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainClick : MonoBehaviour
{
    public int BreadCount = 0;
    private SaveManager saveManager;
    public TextMeshProUGUI Text_BreadCount;
    public ShopManager shopManager;

    
    private void Start()
    {
        saveManager = new SaveManager();
        BreadCount = saveManager.LoadBreadCount();
        Update_Text();
        Debug.Log("Bread: " + BreadCount);
    }

    public  void Add_bread()
    {
        BreadCount+=1+(1*shopManager.Amount_Rye_Bread)+(4*shopManager.Amount_Oatmeal_Bread);
        Update_Text();
        saveManager.SaveBreadCount(BreadCount);

    }
    

    public void Update_Text(){
        if (Text_BreadCount != null){
            Text_BreadCount.text = "Count: " + BreadCount;
        }
            else{
                Debug.LogError("Text_BreadCount не привязан!");
            }
    }

}
