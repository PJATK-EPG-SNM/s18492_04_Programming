using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //typ_zmiennej nazwa;
    //deklaracja
    int a;
    //inicjalizacja
    a=10;
    //2 w 1
    int b = 20;


{//skakanie
Debug.Log(b);
}

{
    //chodzenie
    int c = 20;
}
   //Debug.Log(c);
   
   float fa = 1.5f;
   fa = 20.0f;
   bool logiczna = true;//false
   string str = "jakis napis";
   Debug.Log("fa: "+ fa + " logiczna: "+ logiczna + " str: "+ str);
   //operacja na zmiennych + - * /
   Debug.Log(a/b);
   Debug.Log(a/fa);
   Debug.Log(Mathf.Sqrt(2));
   //operacje logicze
   Debug.Log(a == b); //rowna
   Debug.Log(a != b); //rozne
   Debug.Log(a > b);
   Debug.Log(a >= b);
   Debug.Log(a < b);
   Debug.Log(a <= b);

   //if (warunek_logiczny){
   //}
   if(a == b);{
       Debug.Log("Tak, jest taka sama!");
   Koniunkcja(a , b);
   } else if(a < b){
       Debug.Log("a < b");
        Alternatywa();
   
   } 
   else {
   Debug.Log("zadne z powyzszych");
   }
   Koniunkcja(a , b);
   Alternatywa();

     
    }

    public void Koniunkcja(int a, int b) {
    //Koniunkcja
    Debug.Log((a != b) && (a > 0));

     if (a != b) {
      if (a > 0){
     //kod      }
	 }
     if((a != b) && (a > 0)) {
      //kod
	 }
    
	}
    public void Alternatywa() {
     //brydka wersja
     int hp = 2; time = 1;
     bool amulet = true;
     if (hp <= 0) {
       if (!amulet) { //sprawdzamy czy amulet == false
       //
       } else {
       //
         
	   }
	 }
     //ladna wersja
     if (hp<=0 || time <=0) {
     if (!amulet) { //sprawdzamy czy amulet == false
     //
       } else {
       //
         
	   }
       
	 }
	}

   
   
   
   
   
   
   
   
   
   
   
   
   // Update is called once per frame
    void Update()
    {
        
    }
}
