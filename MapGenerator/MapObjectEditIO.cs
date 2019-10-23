using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using LitJson;

public class MapObjectEditIO<T> : MonoBehaviour where T : class
{
    string lastestJsonReadCached;

    public void ClearJsonReadCache()
    {
        lastestJsonReadCached = string.Empty;
    }

    public T LoadJson(string path)
    {
        if (string.IsNullOrEmpty(lastestJsonReadCached) == false)
        {
            Debug.LogError("Please Empty lastestJsonReadCached before load to be safe");
            return null;
        }

        T result = null;

        using (var sr = new StreamReader(path))
        {
            var strRead = sr.ReadToEnd();

            if (string.IsNullOrEmpty(strRead) == false)
            {
                result = JsonMapper.ToObject<T>(strRead);
                lastestJsonReadCached = strRead;
            }
            else
            {
                Debug.Log("Load MapObject String Json data is Empty : " + path);
            }
        }

        return result;
    }

    public void SaveJson()
    {

    }
}
