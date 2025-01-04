using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    private GameObject[] backgrounds; 
    private int currentBackgroundIndex = 0;
    public GameObject Background_1;
    public GameObject Background_2;
    public GameObject Background_3;
    public GameObject Background_4;
    public GameObject Background_5;

    private SaveManager saveManager;

    private void Start(){

        saveManager = new SaveManager();
        currentBackgroundIndex = saveManager.LoadCurrentBackground();

        backgrounds = new GameObject[]{

            Background_1,Background_2,Background_3,Background_4,Background_5
        };

        for (int i = 0; i < backgrounds.Length; i++){

            if (backgrounds[i] != null){

                backgrounds[i].SetActive(i == currentBackgroundIndex);
            }
            else{

                Debug.LogError($"Background_{i + 1} не найден!");
            }
        }
    }

    public void Backgrounds_Swap_forward(){

        backgrounds[currentBackgroundIndex].SetActive(false);
        currentBackgroundIndex = (currentBackgroundIndex + 1) % backgrounds.Length;
        backgrounds[currentBackgroundIndex].SetActive(true);
        saveManager.SaveCurrentBackground(currentBackgroundIndex);
    }

    public void Backgrounds_Swap_back(){

        backgrounds[currentBackgroundIndex].SetActive(false);
        currentBackgroundIndex = (currentBackgroundIndex - 1 + backgrounds.Length) % backgrounds.Length;
        backgrounds[currentBackgroundIndex].SetActive(true);
        saveManager.SaveCurrentBackground(currentBackgroundIndex);
    }
}
