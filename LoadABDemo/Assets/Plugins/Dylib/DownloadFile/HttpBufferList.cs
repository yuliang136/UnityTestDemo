using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HttpBufferList {

    private object mMutex;

    private List<byte[]> bufferList = null;

    public HttpBufferList(int capacity)
    {
        mMutex = new object();
        bufferList = new List<byte[]>(capacity);
    }

    public byte[] GetBuffer()
    {
        lock (mMutex)
        {
            byte[] buff = null;

            if (bufferList.Count > 0)
            {
                buff = bufferList[0];
                bufferList.RemoveAt(0);
            }

            return buff;
        }
    }

    public void Add(byte[] buff)
    {
        lock (mMutex)
        {
            if(buff != null)
            {
                bufferList.Add(buff);
            }
        }
    }

    public void Clear()
    {
        lock (mMutex)
        {
            if (bufferList.Count > 0)
            {
                bufferList.Clear();
            }
        }
    }


}
