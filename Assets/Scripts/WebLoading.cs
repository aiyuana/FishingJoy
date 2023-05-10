using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

namespace DefaultNamespace
{
    public class WebLoading : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(LoadLua());
        }

        IEnumerator LoadLua()
        {
            //need a relative path for using todo 
            
            UnityWebRequest request = UnityWebRequest.Get("http://127.0.0.1:84/FishingJoy.lua");
            
            yield return request.SendWebRequest();
            
            
            
            if (request.downloadHandler.isDone)
            {
                File.WriteAllText("F:\\game\\FishingJoy\\FishingJoy\\Xlua\\FishingJoy.lua",request.downloadHandler.text);
            }
            
            UnityWebRequest request1 = UnityWebRequest.Get("http://127.0.0.1:84/Vr1.FishingDispoing.lua");
            
            yield return request1.SendWebRequest();

            if (request1.downloadHandler.isDone)
            {
                File.WriteAllText("F:\\game\\FishingJoy\\FishingJoy\\Xlua\\Vr1.FishingDispoing.lua",request.downloadHandler.text);
            }
            
        }
        
        IEnumerator LoadAB()
        {
            
            //need a relative path for using todo 
            UnityWebRequest request = UnityWebRequest.Get("http://127.0.0.1:84/level3fish3.ab");
            
            yield return request.SendWebRequest();

            if (request.downloadHandler.isDone)
            {
                
            }
            
            UnityWebRequest request1 = UnityWebRequest.Get("http://127.0.0.1:84/seawave.ab");
            
            yield return request1.SendWebRequest();

            if (request1.downloadHandler.isDone)
            {
               
            }
            
        }
        
        
        
    }
}