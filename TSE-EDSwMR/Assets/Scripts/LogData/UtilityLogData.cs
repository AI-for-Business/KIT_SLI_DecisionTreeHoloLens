using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using System.Windows;
using System.Diagnostics.Tracing;

#if WINDOWS_UWP
using Windows.Storage;
using Windows.System;
using System.Threading.Tasks;
using Windows.Storage.Streams;
#endif

public static class UtilityLogData
{
    public const string ONBOARDING_SCENE_NAME = "Onboarding";
    public const string M1_SCENE_NAME = "M1";
    public const string M2_SCENE_NAME = "M2";
    public const string M3_SCENE_NAME = "M3";
    public const string M4_SCENE_NAME = "M4";

    public const string MESSAGE_LOG_START_APP = "Start App at: ";
    public const string MESSAGE_LOG_FINISH_M4 = "Fisnish M4 at: ";


    public const string MESSAGE_LOG_START_SCENE = "Start Scene/at: ";
    public const string MESSAGE_LOG_END_SCENE = "End Scene/at: ";


    public const string MESSAGE_LOG_ASSESSMENT = "Assessment answers: ";
    public const string MESSAGE_LOG_EYETRACKING = "Focus enter: ";
    public const string MESSAGE_LOG_EYETRACKING_END = "Focus exit: ";

    public const string MESSAGE_LOG_REBUILT_LAYER = "Rebuilt Layer clicked ";


    public const string MESSAGE_LOG_NOT_PERFECT_TREE = "Rebuilt Layer clicked ";




    //private const string CSVHeader = "Timestamp,SessionID";
    private const string FolderName = "logData";
    private const string Filename = "CSV_log_data.csv";







    private const string Message_Log_ = ":";






    private static int sessionId = 0;
    //private StringBuilder builder;
 

    private static void newSession()
    {
        sessionId += 1;


    }
    private async static void wrFileLog(string message)
    {
        //string path1 = Path.Combine(Application.persistentDataPath);
        //string filename = "CSV_logger_" + System.DateTime.Now.ToString("d");
        //string path_always_new = string.Format("{0}/" + FolderName + "/{1}.csv", Application.persistentDataPath, filename);
        string path = string.Format("{0}/{1}", Application.persistentDataPath, Filename);
//        byte[] data = Encoding.ASCII.GetBytes(message);
//        if (UnityEngine.Windows.File.Exists(path))
//        {
//            Debug.Log("Utility file exists");
//            // delete if the WINDOWS_UWP works
//            UnityEngine.Windows.File.WriteAllBytes(path_always_new, data);

//            //access file and append at end
//            //StorageFolder sf = System.Windows.Storage.StorageFolder;
//#if WINDOWS_UWP //UNITY_WSA && ENABLE_WINMD_SUPPORT
//            try
//            {
//                if (file != null)
//                {
//                    await PathIO.WriteTextAsync(path, message);
//                }
//            }
//            // Handle errors with catch blocks
//            catch (FileNotFoundException)
//            {
//                // For example, handle file not found
//            }
//#endif
//        }

//        else
//        {
//            Debug.Log("Utility file does not exist");
//            // writes in new file everytime
//            UnityEngine.Windows.File.WriteAllBytes(path_always_new, data);
//            // overwrites if file already exists
//        }

        // overwrites, only writes once 
        try
        {
            if (!File.Exists(path))
            {
                Debug.Log("wr create file");
                File.Create(path);
            }
            using (TextWriter writer = File.AppendText(path))
            {
                await writer.WriteLineAsync(message);



            }
        }
        catch (IOException ex)
        {
            Debug.Log("wr log catch ex");
            Debug.LogException(ex);
        }
        // can I see somewhere if it worked?



        //StreamWriter

    }

 
    public static void WriteLog(string message, bool addTime)
    {
        if (addTime)
        {
            string timeStamp = System.DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:ff");
            Debug.Log("Utility log message: " + message + " / " + timeStamp);
            wrFileLog(message + " / " + timeStamp);
        }
        else
        {
            Debug.Log("Utility log message: " + message);
            wrFileLog(message);
        }


        //wrLog(message);
    }

    //private static bool FileExists()
    //{
    //    string pathExists = string.Format("{0}/" + FolderName + "/{1}.csv", Application.persistentDataPath, Filename);
    //    if (UnityEngine.Windows.File.Exists(pathExists))
    //    {
    //        return true;
    //    }

    //    return false;
    //}
}
