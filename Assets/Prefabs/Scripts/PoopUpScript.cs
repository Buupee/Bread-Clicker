using UnityEngine;

public class PoopUpScript : MonoBehaviour
{
   
    public GameObject Panel;

    public void On_PoopUp(){
            
            Panel.SetActive(true);
    }

    public void Off_PoopUp(){
            
            Panel.SetActive(false);
    }


}
