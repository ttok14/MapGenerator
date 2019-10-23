using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BaseMapObject : IBaseMapObjectIdentifierGetSeter
{
    public string objectUniqueIdentifier;
    public int instanceID;

    public BaseMapObject() { }
    public BaseMapObject(string objectUniqueIdentifier, int instanceID)
    {
        SetIdentifier(objectUniqueIdentifier, instanceID);
    }

    public void SetIdentifier(string objectUniqueIdentifier, int instanceID)
    {
        this.objectUniqueIdentifier = objectUniqueIdentifier;
        this.instanceID = instanceID;
    }
}

public interface IBaseMapObjectIdentifierGetSeter
{
    void SetIdentifier(string objectUniqueIdentifier, int instanceID);
}