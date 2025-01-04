using UnityEngine;

public class SaveManager : MonoBehaviour
{
   //BreadCount
    public void SaveBreadCount(int breadCount){

        PlayerPrefs.SetInt("BreadCount", breadCount); 
        PlayerPrefs.Save(); 
    }
    public int LoadBreadCount (){

        return PlayerPrefs.GetInt("BreadCount", 0);
    }   

    //Background

    private const string BackgroundIndexKey = "CurrentBackground";

    public void SaveCurrentBackground(int index){

        PlayerPrefs.SetInt(BackgroundIndexKey, index); 
        PlayerPrefs.Save();
    }

    public int LoadCurrentBackground(){

        return PlayerPrefs.GetInt(BackgroundIndexKey, 0);
    }

    /// //////////////////////////////////////////////////////
    //Autoclickers
    public void SaveAmount_Autoclickers(int Amount_Autoclickers){

        PlayerPrefs.SetInt("Amount_Autoclickers", Amount_Autoclickers); 
        PlayerPrefs.Save(); 
    }

    public int LoadAmount_Autoclickers (){

        return PlayerPrefs.GetInt("Amount_Autoclickers", 0);
    }
    
    public void SavePrice_Autoclicker(double Price_Autoclicker){

        PlayerPrefs.SetFloat("Price_Autoclicker", (float)Price_Autoclicker); 
        PlayerPrefs.Save(); 
    }

    public double LoadPrice_Autoclicker (){

        return (double)PlayerPrefs.GetFloat("Price_Autoclicker", 100f);
    }
    

    /// //////////////////////////////////////////////////////
    //Rye Bread
    public void SaveAmount_Rye_Bread(int Amount_Rye_Bread){

        PlayerPrefs.SetInt("Amount_Rye_Bread", Amount_Rye_Bread); 
        PlayerPrefs.Save(); 
    }

    public int LoadAmount_Rye_Bread (){

        return PlayerPrefs.GetInt("Amount_Rye_Bread", 0);
    }

    public void SavePrice_Rye_Bread(double Price_Rye_Bread){

        PlayerPrefs.SetFloat("Price_Rye_Bread", (float)Price_Rye_Bread); 
        PlayerPrefs.Save(); 
    }

    public double LoadPrice_Rye_Bread (){

        return (double)PlayerPrefs.GetFloat("Price_Rye_Bread", 50f);
    }


/// //////////////////////////////////////////////////////
    //Bakers_Assistant
    public void SaveAmount_Bakers_Assistant(int Amount_Bakers_Assistant){

        PlayerPrefs.SetInt("Amount_Bakers_Assistant", Amount_Bakers_Assistant); 
        PlayerPrefs.Save(); 
    }

    public int LoadAmount_Bakers_Assistant (){

        return PlayerPrefs.GetInt("Amount_Bakers_Assistant", 0);
    }
    
    public void SavePrice_Bakers_Assistant(double Price_Bakers_Assistant){

        PlayerPrefs.SetFloat("Price_Bakers_Assistant", (float)Price_Bakers_Assistant); 
        PlayerPrefs.Save(); 
    }

    public double LoadPrice_Bakers_Assistant (){

        return (double)PlayerPrefs.GetFloat("Price_Bakers_Assistant", 500f);
    }


/// //////////////////////////////////////////////////////
    //Bakery
    public void SaveAmount_Bakery(int Amount_Bakery){

        PlayerPrefs.SetInt("Amount_Bakery", Amount_Bakery); 
        PlayerPrefs.Save(); 
    }

     public int LoadAmount_Bakery (){

        return PlayerPrefs.GetInt("Amount_Bakery", 0);
    }

    public void SavePrice_Bakery(double Price_Bakery){

        PlayerPrefs.SetFloat("Price_Bakery", (float)Price_Bakery); 
        PlayerPrefs.Save(); 
    }

    public double LoadPrice_Bakery (){

        return (double)PlayerPrefs.GetFloat("Price_Bakery", 1500f);
    }
    

/// //////////////////////////////////////////////////////
    //Oatmeal_Bread
    public void SaveAmount_Oatmeal_Bread(int Amount_Oatmeal_Bread){

        PlayerPrefs.SetInt("Amount_Oatmeal_Bread", Amount_Oatmeal_Bread); 
        PlayerPrefs.Save(); 
    }

     public int LoadAmount_Oatmeal_Bread (){

        return PlayerPrefs.GetInt("Amount_Oatmeal_Bread", 0);
    }

    public void SavePrice_Oatmeal_Bread(double Price_Oatmeal_Bread){

        PlayerPrefs.SetFloat("Price_Oatmeal_Bread", (float)Price_Oatmeal_Bread); 
        PlayerPrefs.Save(); 
    }

    public double LoadPrice_Oatmeal_Bread (){

        return (double)PlayerPrefs.GetFloat("Price_Oatmeal_Bread", 1200f);
    }


/// //////////////////////////////////////////////////////
    //Factory
    public void SaveAmount_Factory(int Amount_Factory){

        PlayerPrefs.SetInt("Amount_Factory", Amount_Factory); 
        PlayerPrefs.Save(); 
    }

     public int LoadAmount_Factory (){

        return PlayerPrefs.GetInt("Amount_Factory", 0);
    }

    public void SavePrice_Factory(double Price_Factory){

        PlayerPrefs.SetFloat("Price_Factory", (float)Price_Factory); 
        PlayerPrefs.Save(); 
    }

    public double LoadPrice_Factory (){

        return (double)PlayerPrefs.GetFloat("Price_Factory", 5000f);
    }


}
