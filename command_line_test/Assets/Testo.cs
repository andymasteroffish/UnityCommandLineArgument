using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//info from https://answers.unity.com/questions/366195/parameters-at-startup.html

//to launch with coin op mode
//open cmdtest.app/ --args coin_opp

public class Testo : MonoBehaviour
{

	static string cmdInfo = "";
 
 	public TextMesh text;
    private bool free_play = true;

     void Start () 
     {
     	cmdInfo += "arguments:\n";
         string[] arguments = Environment.GetCommandLineArgs();
         for (int i=0; i<arguments.Length; i++){
             cmdInfo += arguments[i].ToString() + "\n ";
             if (arguments[i] == "-freeplay" && i<arguments.Length-1 ){
             	free_play = arguments[i+1].ToLower() == "true";
             }
         }

         if (free_play){
         	text.text = "FREE PLAY";
         }else{
         	text.text = "GIMME COINS";
         }
     }
     
     void OnGUI()
     {
         Rect r = new Rect(5,5, 800, 500);
         GUI.Label(r, cmdInfo);
     }
}
