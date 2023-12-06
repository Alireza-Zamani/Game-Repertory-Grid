using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class InterviewDataHolder
{
    public static string IntervieweeName;
    public static string IntervieweeAge;
    public static string IntervieweeEducation;
    public static string IntervieweeAverageGameplayTime;
    
    
    public static string WorstGame;
    public static string BadGame;
    public static string MediocreGame;
    public static string GoodGame;
    public static string BestGame;
    public static string IdealGame;

    public static List<ConstructData> PoleDataList = new List<ConstructData>();

    public static void WriteToFile()
    {
        string fileName = IntervieweeName + ".csv";
        string filePath = Path.Combine(Application.persistentDataPath, fileName);

        using StreamWriter writer = new StreamWriter(filePath, true);
        
        writer.WriteLine($"{IntervieweeName},{IntervieweeAge},{IntervieweeEducation},{IntervieweeAverageGameplayTime}");
        writer.WriteLine($",{WorstGame},{BadGame},{MediocreGame},{GoodGame},{BestGame},{IdealGame},");

        foreach (ConstructData data in PoleDataList)
        {
            writer.WriteLine(
                $"{data.ContrastPole}," +
                $" {data.WorstScore}," +
                $" {data.BadScore}," +
                $" {data.MediocreScore}," +
                $" {data.GoodScore}," +
                $" {data.BestScore}," +
                $" {data.IdealScore}," +
                $" {data.EmergentPole}");
        }
    }
}
