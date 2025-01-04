using UnityEngine;
using UnityEngine.UI;

public class ImageCustom : MonoBehaviour
{
   public float alpha =1;

   void Start(){
    GetComponent<Image>().alphaHitTestMinimumThreshold=alpha;
   }
}
