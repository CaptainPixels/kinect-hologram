using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using System;

public class transformCamera : MonoBehaviour
{

    private FileInfo theSourceFile = null;
    private StreamReader reader = null;
    private string text = " ";
    public TextAsset textFile;
    public string textLine;
    private int count = 0;
    public float scaleFactor = 1000;

    private void Start()
    {
        //textLine = textFile.text;
        //var inStream = new FileStream(@"Assets\\coords.txt", FileMode.Open, FileAccess.Read);
        //Debug.Log(inStream);
        string path = @"C:\Users\Mykayla\Desktop\transforms\coords_0.txt";
        Debug.Log(path);
        if (File.Exists(path))
        {
            Debug.Log("found file");
        }

        string[] stringArray = File.ReadAllLines(@"C:\Users\Mykayla\Desktop\transforms\coords_" + count + ".txt");
        //string[] stringArray = Regex.Split(textLine, "\r\n");
        foreach (string s in stringArray)
        {
            Debug.Log(s);
        }

    }


    // Update is called once per frame
    void Update()
    {
        //var inStream = new FileStream(@"Assets\\coords_" + count + ".txt", FileMode.Open, FileAccess.Read);
        if (File.Exists(@"C:\Users\Mykayla\Desktop\transforms\coords_" + count + ".txt"))
        {
            string[] stringArray = System.IO.File.ReadAllLines(@"C:\Users\Mykayla\Desktop\transforms\coords_" + count + ".txt");
            //string[] stringArray = Regex.Split(textLine, "\r\n");
            //foreach (string s in stringArray)
            //{
            //    Debug.Log(s);
            //}
            float x = float.Parse(stringArray[0]);
            float y = float.Parse(stringArray[1]);
            float z = float.Parse(stringArray[2]);

            Debug.Log("x: " + x + " y: " + y + " z: " + z);

            // Scale values up
            x = x * scaleFactor;
            y = y * scaleFactor;
            z = z * scaleFactor;

            this.transform.position = new Vector3(x, y, z);
            //this.transform.worldToLocalMatrix(x, y, z);

            File.Delete(@"C:\Users\Mykayla\Desktop\transforms\coords_" + count + ".txt");
            //File.Delete(@"Assets\coords_" + count + ".txt");
            count++;
        }
        else
        {
            Debug.Log(@"cant find C:\Users\Mykayla\Desktop\transforms\coords_" + count + ".txt");
        }
        
        
    }
    
}
