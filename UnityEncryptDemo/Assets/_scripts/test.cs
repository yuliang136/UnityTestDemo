using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

public class test : MonoBehaviour
{

    public static int A = 10;

    public Text m_Show;

    byte[] m_EncryptA = null;

    private static string key = "abcde2341231";
    private static string iv = "s9af";

    byte[] Key = Encoding.Unicode.GetBytes(key);
    byte[] IV = Encoding.Unicode.GetBytes(iv);

	// Use this for initialization
	void Start () 
    {
	    // 对A进行加密.
        m_EncryptA = EncryptTextToMemory(A.ToString(), Key, IV);

        //Debug.Log("here");

        //string strTestDecrypt = DecryptTextFromMemory(m_EncryptA, Key, IV);

        //Debug.Log("here");
	}

    public void ShowValue()
    {
        //string strCheck =  ToUTF8(DecryptTextFromMemory(m_EncryptA, Key, IV));
        //string strA = ToUTF8(A.ToString());

        //string strCheck = DecryptTextFromMemory(m_EncryptA, Key, IV);

        //string strA = Convert.ToString(A);

        //byte[] bytesA = Encoding.Default.GetBytes(strCheck);
        //byte[] bytesB = Encoding.Default.GetBytes(strA);


        //bool bEqual = String.Equals(strCheck, strA);

        if (DecryptTextFromMemory(m_EncryptA, Key, IV) == A.ToString())
        {
            A++;
            m_Show.text = A.ToString();

            m_EncryptA = EncryptTextToMemory(A.ToString(), Key, IV);
        }
        else
        {
            m_Show.text = "大哥! 不要作弊了!!!";
        }


    }

    public static string ToUTF8(string myString)
    {
        byte[] bytes = Encoding.Default.GetBytes(myString);
        return Encoding.UTF8.GetString(bytes);
    }

    public static byte[] EncryptTextToMemory(string Data, byte[] Key, byte[] IV)
    {
        try
        {
            // Create a MemoryStream.
            MemoryStream mStream = new MemoryStream();

            // Create a CryptoStream using the MemoryStream 
            // and the passed key and initialization vector (IV).
            CryptoStream cStream = new CryptoStream(mStream,
                new TripleDESCryptoServiceProvider().CreateEncryptor(Key, IV),
                CryptoStreamMode.Write);

            // Convert the passed string to a byte array.
            byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);

            // Write the byte array to the crypto stream and flush it.
            cStream.Write(toEncrypt, 0, toEncrypt.Length);
            cStream.FlushFinalBlock();

            // Get an array of bytes from the 
            // MemoryStream that holds the 
            // encrypted data.
            byte[] ret = mStream.ToArray();

            // Close the streams.
            cStream.Close();
            mStream.Close();

            // Return the encrypted buffer.
            return ret;
        }
        catch (CryptographicException e)
        {
            Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            return null;
        }

    }


    public static string DecryptTextFromMemory(byte[] Data, byte[] Key, byte[] IV)
    {
        try
        {
            // Create a new MemoryStream using the passed 
            // array of encrypted data.
            MemoryStream msDecrypt = new MemoryStream(Data);

            // Create a CryptoStream using the MemoryStream 
            // and the passed key and initialization vector (IV).
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                new TripleDESCryptoServiceProvider().CreateDecryptor(Key, IV),
                CryptoStreamMode.Read);

            // Create buffer to hold the decrypted data.
            byte[] fromEncrypt = new byte[Data.Length];

            // Read the decrypted data out of the crypto stream
            // and place it into the temporary buffer.
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

            
            //Convert the buffer into a string and return it.
            return new UTF8Encoding().GetString(fromEncrypt).Replace("\0","");
        }
        catch (CryptographicException e)
        {
            Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            return null;
        }
    }

}
