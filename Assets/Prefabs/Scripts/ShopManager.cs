using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public MainClick mainClick;
    public int Amount_Autoclickers = 0;
    public double Price_Autoclicker = 100;
    public int Amount_Rye_Bread = 0;
    public double Price_Rye_Bread = 50;
    public int Amount_Bakers_Assistant=0;
    public double Price_Bakers_Assistant=500;
    public int Amount_Bakery=0;
    public double Price_Bakery= 1500;
    public int Amount_Oatmeal_Bread = 0;
    public double Price_Oatmeal_Bread = 1200;
    public int Amount_Factory;
    public double Price_Factory=1500;
    public int Amount_Upgrade1;
    

    private int Speed = 0;
    private TextMeshProUGUI Text_Speed;

    private TextMeshProUGUI Text_Amount_Autoclicker;
    private TextMeshProUGUI Text_Price_Autoclicker;

    private TextMeshProUGUI Text_Price_Rye_Bread;
    private TextMeshProUGUI Text_Amount_Rye_Bread;

    private TextMeshProUGUI Text_Price_Bakers_Assistant;
    private TextMeshProUGUI Text_Amount_Bakers_Assistant;

    private TextMeshProUGUI Text_Price_Bakery;
    private TextMeshProUGUI Text_Amount_Bakery;

    private TextMeshProUGUI Text_Price_Oatmeal_Bread;
    private TextMeshProUGUI Text_Amount_Oatmeal_Bread;

    private TextMeshProUGUI Text_Price_Factory;
    private TextMeshProUGUI Text_Amount_Factory;

    
    



    private SaveManager saveManager;

    private void Start() {
        
        //ССылки на Текстовые поля
        Text_Amount_Autoclicker = GameObject.Find("Text_Amount_Autoclicker").GetComponent<TextMeshProUGUI>();
            Text_Price_Autoclicker = GameObject.Find("Text_Price_Autoclicker").GetComponent<TextMeshProUGUI>();
        Text_Amount_Rye_Bread = GameObject.Find("Text_Amount_Rye_Bread").GetComponent<TextMeshProUGUI>();
            Text_Price_Rye_Bread = GameObject.Find("Text_Price_Rye_Bread").GetComponent<TextMeshProUGUI>();
        Text_Amount_Bakers_Assistant = GameObject.Find("Text_Amount_Bakers_Assistant").GetComponent<TextMeshProUGUI>();
            Text_Price_Bakers_Assistant = GameObject.Find("Text_Price_Bakers_Assistant").GetComponent<TextMeshProUGUI>();
        Text_Amount_Bakery= GameObject.Find("Text_Amount_Bakery").GetComponent<TextMeshProUGUI>();
            Text_Price_Bakery= GameObject.Find("Text_Price_Bakery").GetComponent<TextMeshProUGUI>();
        Text_Amount_Oatmeal_Bread = GameObject.Find("Text_Amount_Oatmeal_Bread").GetComponent<TextMeshProUGUI>();
            Text_Price_Oatmeal_Bread = GameObject.Find("Text_Price_Oatmeal_Bread").GetComponent<TextMeshProUGUI>();
        Text_Amount_Factory=GameObject.Find("Text_Amount_Factory").GetComponent<TextMeshProUGUI>();
            Text_Price_Factory=GameObject.Find("Text_Price_Factory").GetComponent<TextMeshProUGUI>();
        
        Text_Speed = GameObject.Find("Speed").GetComponent<TextMeshProUGUI>();

        saveManager = new SaveManager();
        Loader();

        //Загрузка всего текста и сохранения
        mainClick.Update_Text();
            StartCoroutine(AutoGenerateBread());
    }


    //Покупка Автокликера
    public void Buying_Autoclicker(){

        if(mainClick.BreadCount >=Price_Autoclicker){
            Amount_Autoclickers++;
            mainClick.BreadCount-=(int)Price_Autoclicker;
            Price_Autoclicker= Math.Round(100 * (Math.Pow(1.2, Amount_Autoclickers)), 1);
            Text_Price_Autoclicker.text = Price_Autoclicker.ToString();
                Text_Amount_Autoclicker.text = Amount_Autoclickers.ToString();
            SaveGameState();
        }
        else{
            Debug.Log("NemaHleba");
        }
    }


    //Покупка Rye Bread
    public void Bying_Rye_Bread(){
        if(mainClick.BreadCount >= Price_Rye_Bread){
            Amount_Rye_Bread++;
            mainClick.BreadCount-= (int)Price_Rye_Bread;
            Price_Rye_Bread = Math.Round(50 * (Math.Pow(1.2, Amount_Rye_Bread)), 1);

            Text_Price_Rye_Bread.text = Price_Rye_Bread.ToString();
                Text_Amount_Rye_Bread.text = Amount_Rye_Bread.ToString();
            SaveGameState();
        }
    }

    //Покупка Помощника пекаря
    public void Bying_Bakers_Assistant(){
        if(mainClick.BreadCount>=Price_Bakers_Assistant){
            Amount_Bakers_Assistant++;
            mainClick.BreadCount-=(int)Price_Bakers_Assistant;
            Price_Bakers_Assistant= Math.Round(500*(Math.Pow(1.2,Amount_Bakers_Assistant)),1);

            Text_Price_Bakers_Assistant.text= Price_Bakers_Assistant.ToString();
                Text_Amount_Bakers_Assistant.text= Amount_Bakers_Assistant.ToString();
            SaveGameState();
        }


    }


    //Покупка пекарни
    public void Bying_Bakery(){
        if(mainClick.BreadCount>= Price_Bakery){
            Amount_Bakery++;
            mainClick.BreadCount-=(int)Price_Bakers_Assistant;
            Price_Bakery= Math.Round(1500*(Math.Pow(1.25,Amount_Bakery)),1);

            Text_Price_Bakery.text= Price_Bakery.ToString();
            Text_Amount_Bakery.text = Amount_Bakery.ToString();
            SaveGameState();
        }
    }


    //Покупка овсяного хлеба
    public void Bying_Oatmeal_Bread(){
        if(mainClick.BreadCount>= Price_Oatmeal_Bread){
            Amount_Oatmeal_Bread++;
            mainClick.BreadCount-=(int)Price_Oatmeal_Bread;
            Price_Oatmeal_Bread = Math.Round(1200*(Math.Pow(1.2,Amount_Oatmeal_Bread)),1);

            Text_Price_Oatmeal_Bread.text= Price_Oatmeal_Bread.ToString();
            Text_Amount_Oatmeal_Bread.text= Amount_Oatmeal_Bread.ToString();
            SaveGameState();
        }
    }


    //Покупка Фабрики
    public void Bying_Factory(){
        if(mainClick.BreadCount>= Price_Factory){
            Amount_Factory++;
            mainClick.BreadCount-=(int)Price_Factory;
            Price_Factory = Math.Round(5000*(Math.Pow(1.25,Amount_Factory)),1);

            Text_Price_Factory.text= Price_Factory.ToString();
            Text_Amount_Factory.text= Amount_Factory.ToString();
            SaveGameState();
        }
    }


    //Апгрейд Quick_leaven
    public void Quick_leaven(){
        if(mainClick.BreadCount>= Price_Factory){
            mainClick.BreadCount-=1500;
            Amount_Upgrade1++;
        }
    }

    //Корутина
    private System.Collections.IEnumerator AutoGenerateBread(){

        while (true){
            
            if (Amount_Autoclickers > 0){

                if(Amount_Upgrade1>0)mainClick.BreadCount += 2 * Amount_Autoclickers;
                else mainClick.BreadCount += Amount_Autoclickers;
            }
            if(Amount_Bakers_Assistant>0){

                mainClick.BreadCount+= Amount_Bakers_Assistant*5;
            }
            if(Amount_Bakery>0){
                mainClick.BreadCount+=Amount_Bakery*15;
            }
            if(Amount_Factory>0){
                mainClick.BreadCount+= Amount_Factory *50;
            }

            Speed = (Amount_Autoclickers+(5*Amount_Bakers_Assistant)+(Amount_Bakery*15)+(Amount_Factory *50));
            mainClick.Update_Text();
            Text_Speed.text = Speed.ToString();
            yield return new WaitForSeconds(1f);
        }
    }


    
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //Обновление текстов
    private void Update_Text(){

        Text_Price_Autoclicker.text = Price_Autoclicker.ToString();
            Text_Amount_Autoclicker.text = Amount_Autoclickers.ToString();
        Text_Price_Rye_Bread.text = Price_Rye_Bread.ToString();
            Text_Amount_Rye_Bread.text = Amount_Rye_Bread.ToString();
        Text_Price_Bakers_Assistant.text= Price_Bakers_Assistant.ToString();
            Text_Amount_Bakers_Assistant.text= Amount_Bakers_Assistant.ToString();
        Text_Price_Bakery.text= Price_Bakery.ToString();
            Text_Amount_Bakery.text = Amount_Bakery.ToString();
        Text_Price_Oatmeal_Bread.text= Price_Oatmeal_Bread.ToString();
            Text_Amount_Oatmeal_Bread.text= Amount_Oatmeal_Bread.ToString();
        Text_Price_Factory.text=Price_Factory.ToString();
            Text_Amount_Factory.text=Amount_Factory.ToString();

    }

    //Сохранение
    private void SaveGameState(){

        saveManager.SaveBreadCount(mainClick.BreadCount);
        saveManager.SaveAmount_Autoclickers(Amount_Autoclickers);
            saveManager.SavePrice_Autoclicker(Price_Autoclicker);
        saveManager.SaveAmount_Rye_Bread(Amount_Rye_Bread);
            saveManager.SavePrice_Rye_Bread(Price_Rye_Bread);
        saveManager.SaveAmount_Bakers_Assistant(Amount_Bakers_Assistant);
            saveManager.SavePrice_Bakers_Assistant(Price_Bakers_Assistant);
        saveManager.SaveAmount_Bakery(Amount_Bakery);
            saveManager.SavePrice_Bakery(Price_Bakery);
        saveManager.SaveAmount_Oatmeal_Bread(Amount_Oatmeal_Bread);
            saveManager.SavePrice_Oatmeal_Bread(Price_Oatmeal_Bread);
        saveManager.SaveAmount_Factory(Amount_Factory);
            saveManager.SavePrice_Factory(Price_Factory);
    }

    public void ResetGameAndRestart(){
        ResetGameData();
        Loader(); // Повторно загрузить начальные значения
        mainClick.Update_Text();
        Debug.Log("Игра началась заново!");
    }
    private void ResetGameData(){
        PlayerPrefs.DeleteAll(); // Удаляет все сохранённые данные
        PlayerPrefs.Save(); // Сохраняет изменения
        Debug.Log("Все данные сброшены!");
    }





    private void OnApplicationQuit(){

        SaveGameState();
    }

    private void OnApplicationPause(bool isPaused){

        if (isPaused){
            
            SaveGameState();
            Debug.Log("Игра приостановлена. Данные сохранены.");
        }
    }

    private void OnApplicationFocus(bool hasFocus){

        if (!hasFocus){ // Потеря фокуса (например, Alt+Tab)

            SaveGameState();
            Debug.Log("Игра потеряла фокус. Данные сохранены.");
        }
    }

    //Загрузка 
    public void Loader(){
        mainClick.BreadCount = saveManager.LoadBreadCount();
            Amount_Autoclickers = saveManager.LoadAmount_Autoclickers();
                Price_Autoclicker=  Math.Round(saveManager.LoadPrice_Autoclicker(),1);
            Amount_Rye_Bread= saveManager.LoadAmount_Rye_Bread();
                Price_Rye_Bread= Math.Round(saveManager.LoadPrice_Rye_Bread(),1);
            Amount_Bakers_Assistant=saveManager.LoadAmount_Bakers_Assistant();
                Price_Bakers_Assistant= Math.Round(saveManager.LoadPrice_Bakers_Assistant(),1);
            Amount_Bakery= saveManager.LoadAmount_Bakery();
                Price_Bakery= Math.Round(saveManager.LoadPrice_Bakery(),1);
            Amount_Oatmeal_Bread = saveManager.LoadAmount_Oatmeal_Bread();
                Price_Oatmeal_Bread= Math.Round(saveManager.LoadPrice_Oatmeal_Bread(),1);
            Amount_Factory = saveManager.LoadAmount_Factory();
                Price_Factory= Math.Round(saveManager.LoadPrice_Factory(),1);
                
            Update_Text();

    }
}
