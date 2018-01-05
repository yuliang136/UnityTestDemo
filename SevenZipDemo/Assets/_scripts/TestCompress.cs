using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System;

public class TestCompress : Editor
{
    [MenuItem("MyMenu/CompressFile")]
    static void CompressFile()
    {
        CompressFileLZMA(Application.dataPath + "/UI_Login.assetbundle", Application.dataPath + "/UI_Login.data");

        //CompressFileLZMA(Application.dataPath + "/1.jpg", Application.dataPath + "/2.zip");

        AssetDatabase.Refresh();
    }

    [MenuItem("MyMenu/DecompressFile")]
    static void DecompresssFile()
    {
        //DecompressFileLZMA(Application.dataPath + "/2.zip", Application.dataPath + "/3.jpg");
        DecompressFileLZMA(Application.dataPath + "/UI_Login.data", Application.dataPath + "/UI_Login1.assetbundle");


        AssetDatabase.Refresh();
    }

    private static void CompressFileLZMA(string inFile, string outFile)
    {
        SevenZip.Compression.LZMA.Encoder coder = new SevenZip.Compression.LZMA.Encoder();

        // 打开输入文件.
        FileStream input = new FileStream(inFile, FileMode.Open);

        // 创建输出文件.
        FileStream output = new FileStream(outFile, FileMode.Create);

        // Write the encoder properties.

        // outputStream 写完之后是否会自动移位?
        coder.WriteCoderProperties(output);

        // Write the decompressed file size.

        // 把long类型的值转化为bytes数组.
        byte[] bytes = BitConverter.GetBytes(input.Length);

        output.Write(bytes, 0, 8);

        // Encode the file.
        coder.Code(input, output, input.Length, -1, null);

        output.Flush();
        output.Close();
        input.Close();
    }

    private static void DecompressFileLZMA(string inFile, string outFile)
    {
        SevenZip.Compression.LZMA.Decoder coder = new SevenZip.Compression.LZMA.Decoder();

        FileStream input = new FileStream(inFile, FileMode.Open);
        FileStream output = new FileStream(outFile, FileMode.Create);

        // Read the decoder properties
        byte[] properties = new byte[5];
        input.Read(properties, 0, 5);

        // Read in the decompress file size.
        byte[] fileLengthBytes = new byte[8];
        input.Read(fileLengthBytes, 0, 8);


        long fileLength = BitConverter.ToInt64(fileLengthBytes, 0);

        // Decompress the file.
        coder.SetDecoderProperties(properties);
        coder.Code(input, output, input.Length, fileLength, null);
        
        
        output.Flush();
        output.Close();
        input.Close();
    }
}
