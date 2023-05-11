using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.Text;
using System.IO;
using UnityEngine.Networking;
public class M_HotFix : MonoBehaviour
{
    
    
    LuaEnv luaEnv = new LuaEnv();
    
    public  Dictionary<string, GameObject> goDIc = new Dictionary<string, GameObject>();
 
    private void Awake()
    {
        luaEnv.AddLoader(M_Loader);
        luaEnv.DoString("require'FishingJoy'");
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    byte[] M_Loader(ref string filePath)
    {
        string path = @"F:\game\FishingJoy\FishingJoy\Xlua\" + filePath + ".lua";
         return Encoding.UTF8.GetBytes(File.ReadAllText(path));
    }

    public void LoadResources(string resName,string filePath,int resType)
    {
        //LoadAB(resName, filePath,resType);
        StartCoroutine(LoadAB1(resName, filePath, resType));
    }
    IEnumerator LoadAB1(string reNAmae,string filePath,int resType)
    {
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle("http://localhost:84/" + filePath);
        yield return request.SendWebRequest();
        AssetBundle ab = (request.downloadHandler as DownloadHandlerAssetBundle).assetBundle;
       GameObject go = ab.LoadAsset<GameObject>(reNAmae);
       goDIc.Add(reNAmae,go);

        ab.Unload(false);
    }
    
        
    
    public GameObject GetPre(string resName)
    {
        return goDIc[resName];
    }
    
    private void OnDisable()
    {
        luaEnv.DoString("require'Vr1.FishingDispoing'");
    }

    private void OnDestroy()
    {
        luaEnv.Dispose();
    }
    
    
}
