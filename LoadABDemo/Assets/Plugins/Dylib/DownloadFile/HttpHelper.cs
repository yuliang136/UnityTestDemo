using UnityEngine;
using System.Collections;
using System;
using System.Text;
using System.Net;
using System.IO;
using MyThread;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

internal class WebReqData
{
	public static  int requestTimeout = 10000;
	public static  int readTimeout = 5000;
	public static  int responseTimeout = 5000;
	public static  int BufferSize = 1024;
	public static  int sleepTime = 100;
}

public class HttpHelper{
	private string downLoadUrl = string.Empty;
	private long totleSize = 0;
	private int currentSize = 0;
	byte[] bytes = null;
	const int MAX_SIZE = 1024 * 1024 * 6;
	public bool isDone = false;
	public string url = string.Empty;
	private string filePath = string.Empty;

	public void destory()
	{
        Array.Clear(bytes, 0, bytes.Length);
        bufferList.Add(bytes);
		bytes = null;
	}

	public byte[] Bytes
	{
		get{return bytes;}
	}

	public int CurrentSize
	{
		get{return currentSize;}
		set{currentSize = value;}
	}
	
	public long ToTleSize
	{
		get{return totleSize;}
		set{totleSize = value;}
	}
	
	public string UrlPath
	{
		get{return downLoadUrl;}
		set{downLoadUrl = value;}
	}
	
	public string FilePath
	{
		get{return filePath;}
		set{filePath = value;}
	}
	public HttpHelper()
	{
		totleSize = 0;
	}

    private static HttpBufferList bufferList = new HttpBufferList(Dylib.File.FileLoader.COROUTINE_LOAD_LIMIT);

	public void init()
	{
        if (bytes == null)
        {
            bytes = bufferList.GetBuffer();
        }

		if(bytes == null)
		{
            bytes = new byte[MAX_SIZE];
		}
		
		totleSize = 0;
		currentSize = 0;
		isDone = false;
	}
	

	public void AsyDownLoad()
	{
        DoDownLoad();
	}

    void DoDownLoad()
    {
        HttpWebRequest request = null;
        HttpWebResponse response = null;
        Stream responseStream = null;

        try
        {
            ServicePointManager.ServerCertificateValidationCallback += ServerCertificateValidation;

            request = WebRequest.Create(filePath) as HttpWebRequest;
            request.Timeout = WebReqData.requestTimeout;
            request.ReadWriteTimeout = WebReqData.responseTimeout;

            if (currentSize > 0)
            {
                request.AddRange((int)currentSize);
                Logger.Log("Time out , currentSize :" + currentSize + " file path is" + filePath);
            }

            using (response = (HttpWebResponse)request.GetResponse())
            {
                using (responseStream = response.GetResponseStream())
                {
                    if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.PartialContent)
                    {
                        int len = 0;
                        long transferLen = response.ContentLength;

                        if (currentSize > 0)
                        {
                            Logger.Log("Time out , currentSize :" + currentSize + " transferLen " + transferLen + " totleSize : " + totleSize);
                        }

                        totleSize = response.StatusCode == HttpStatusCode.OK ? transferLen : totleSize + transferLen;
                        responseStream.ReadTimeout = WebReqData.readTimeout;

     
                        do
                        {
                            len = responseStream.Read(bytes, currentSize, (int)transferLen - currentSize);
                            currentSize += len;
                        } while (len > 0);
                        
                    }
                }
            }
            Logger.Log(" response.StatusCode :" + response.StatusCode + " file path : " + filePath);

            isDone = true;
        }
        catch (Exception e)
        {
            if (responseStream != null)
            {
                responseStream.Close();
                responseStream.Dispose();
                responseStream = null;
            }

            if (response != null)
            {
                response.Close();
                response = null;
            }

            if (request != null)
            {
                request.GetRequestStream().Close();
                //request.Abort();
                request = null;
            }

            System.Threading.Thread.Sleep(WebReqData.sleepTime);
            Logger.LogError("url: " + filePath + " exception is " + e.ToString());
            DoDownLoad();
        }
    }

    public static void Clear()
    {
        if (bufferList != null)
        {
            bufferList.Clear();
        }
    }

    private static bool ServerCertificateValidation(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        // If the certificate is a valid, signed certificate, return true.
        if (sslPolicyErrors == System.Net.Security.SslPolicyErrors.None)
        {
            return true;
        }

        bool isOk = true;
        // If there are errors in the certificate chain, look at each error to determine the cause.
        if (sslPolicyErrors != SslPolicyErrors.None)
        {
            for (int i = 0; i < chain.ChainStatus.Length; i++)
            {
                if (chain.ChainStatus[i].Status != X509ChainStatusFlags.RevocationStatusUnknown)
                {
                    chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
                    chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
                    chain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(0, 1, 0);
                    chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
                    bool chainIsValid = chain.Build((X509Certificate2)cert);

                    if (!chainIsValid)
                    {
                        isOk = false;
                    }
                }
            }
        }

        return isOk;
    }

}
