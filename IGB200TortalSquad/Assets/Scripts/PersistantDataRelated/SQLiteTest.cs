using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SQLite;

public class SQLiteTest: MonoBehaviour
{
     private static string dbName = $"Data.db"; //{Application.persistentDataPath}/
     
     private static SQLiteConnection _db;
     
     
     
     static SQLiteTest()
     {
         _db = new SQLiteConnection(dbName);
         _db.CreateTable<Stock>();
         //_db.Insert(new Stock("Yes"));
     }
     
     // Start is called before the first frame updat
     
     public static void GenerateDB(string query)
     {
         _db = new SQLiteConnection(dbName);
         _db.CreateTable<Stock>();
         _db.Insert(new Stock{Symbol = "Yes"});
     }

     public static void pullFromDataBase(string query)
     {
             var options = new SQLiteConnectionString(dbName, false);
             var conn= new SQLiteConnection(options);
    
             //string query = $"SELECT * FROM Stocks";
    
             var results = conn.Query<Stock>(query);

             foreach (var result in results)
             {
                 Debug.LogWarning(result);    
             }
             
             
             conn.Close();
     }

     public static void CreateNewDifficultyLevel()
     {
         var options = new SQLiteConnectionString(dbName, false);
         var conn= new SQLiteConnection(options);

         conn.CreateTable<Difficulty>();
         conn.Insert(new Difficulty { DifficultyLevel = 100f }); 
     }
     
     public static float PullDifficultyLevel(int id)
     {
         var options = new SQLiteConnectionString(dbName, false);
         var conn= new SQLiteConnection(options);
    
         var results = conn.Query<Difficulty>("SELECT symbol FROM DifficultyLevels WHERE Id = id");
         
         conn.Close();
         foreach (var result in results)
         {
             return result.DifficultyLevel;
         }

         return 0f;
     }

     public static void UpdateDifficultyLevel(int id, float updatedValue)
     {
         var options = new SQLiteConnectionString(dbName, false);
         var conn= new SQLiteConnection(options);
    
         var results = conn.Update(new Difficulty {Id = id, DifficultyLevel = updatedValue});
         
         conn.Close();
     }

     private void Start()
     {
         //pullFromDataBase();
         // _db = new SQLiteConnection(dbName);
         //CreateNewDifficultyLevel();
     }
}

[Table("Stocks")]	 
public class Stock		
{		
    [PrimaryKey, AutoIncrement]
    [Column("id")]		
    public int Id { get; set; }	

    [Column("symbol")]			
    public string Symbol { get; set; }
    
}

[Table("DifficultyLevels")]	 
public class Difficulty		
{		
    [PrimaryKey, AutoIncrement]
    [Column("id")]		
    public int Id { get; set; }	

    [Column("symbol")]			
    public float DifficultyLevel { get; set; }
    
}
