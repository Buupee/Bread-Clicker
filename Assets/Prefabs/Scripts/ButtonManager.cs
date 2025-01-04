using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject panel1; 
    public GameObject panel2; 

    private bool isPanel1Active = false; 

    public void SwitchPanels(){

        if (panel1 != null && panel2 != null){

            isPanel1Active = !isPanel1Active;

            panel1.SetActive(isPanel1Active);
            panel2.SetActive(!isPanel1Active);
        }
        else{

            Debug.LogError("Нема назначеной панели в Inspector");
        }
    }
}
