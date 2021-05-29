using System;
using System.Collections.Generic;
using System.Linq;

namespace AzureDevTesting
{
    public class TrainType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Train
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Owner { get; set; }
        public bool IsCloudConnected { get; set; }
        public string Position { get; set; }
        public int Velocity { get; set; }
        public int Accelaration { get; set; }
        public string Direction { get; set; }
        public bool CabineLightsOn { get; set; }
        public bool ACOn { get; set; }
        public double ACTemp { get; set; }
    }

    public enum SystemState
    {
        Fatal , Error, Warning, Working
    }

    public class TrainSystemStatus
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public SystemState ErrorState { get; set; }
        public double OnBoardComputerTemp { get; set; }
        public bool PassengerDisplayOn { get; set; }
        public bool CCTVOn { get; set; }
    }

    public class TrainMission
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public string NextStation { get; set; }
        public TimeSpan EstimatedArrival { get; set; }
    }

    public class TrainAPC
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public int Count { get; set; }
    }

    public static class Database
    {
        private static List<TrainType> trainTypes = new List<TrainType>(){
            new TrainType { Id = 1, Name ="Intercity"},
            new TrainType { Id = 2, Name ="Train"},
            new TrainType { Id = 3, Name ="Tram"},
            new TrainType { Id = 4, Name ="Metro"},
        };

        private static List<Train> trains = new List<Train>(){
            new Train(){ Id = 1, TypeId = 2, Owner = "SJ", IsCloudConnected = true , Position = "55.552699, 13.151172", Direction = "North" , Accelaration = 5 , Velocity = 85 , ACOn = true , ACTemp = 18, CabineLightsOn = true},
            new Train(){ Id = 2, TypeId = 2, Owner = "SJ", IsCloudConnected = true , Position = "55.705165, 13.187519", Direction = "North" , Accelaration = 0 , Velocity = 0 , ACOn = true , ACTemp = 16, CabineLightsOn = true},
            new Train(){ Id = 3, TypeId = 4, Owner = "ST", IsCloudConnected = true , Position = "59.339297, 18.029982", Direction = "South" , Accelaration = 10 , Velocity = 60, ACOn = true , ACTemp = 20, CabineLightsOn = true}
        };

        private static List<TrainSystemStatus> systemStatus = new List<TrainSystemStatus>()
        {
            new TrainSystemStatus { Id = 1, TrainId = 1,  ErrorState = SystemState.Working , CCTVOn = true, OnBoardComputerTemp = 42 , PassengerDisplayOn = true  },
            new TrainSystemStatus { Id = 2, TrainId = 2,  ErrorState = SystemState.Fatal , CCTVOn = false, OnBoardComputerTemp = 89 , PassengerDisplayOn = false  },
            new TrainSystemStatus { Id = 3, TrainId = 3 ,  ErrorState = SystemState.Warning , CCTVOn = true, OnBoardComputerTemp = 69 , PassengerDisplayOn = true  },
        };

        private static List<TrainMission> mission = new List<TrainMission>()
        {
            new TrainMission { Id = 1, TrainId = 1 , NextStation = "Malmö centralen" , EstimatedArrival = new TimeSpan(12, 05 ,00 )},
            new TrainMission { Id = 2, TrainId = 2 , NextStation = "Götenburgh" , EstimatedArrival = new TimeSpan(12, 30 ,00 )},
            new TrainMission { Id = 3, TrainId = 3 , NextStation = "T-Centralen" , EstimatedArrival = new TimeSpan(12, 02 ,00 )},
        };

        private static List<TrainAPC> apcData = new List<TrainAPC>()
        {
            new TrainAPC { Id = 1 , TrainId = 1 , Count = 15},
            new TrainAPC { Id = 2 , TrainId = 2 , Count = 20},
            new TrainAPC { Id = 3 , TrainId = 3 , Count = 10}
        };

        public static IEnumerable<TrainType> GetTrainTypes()
        {
            return trainTypes.AsEnumerable();
        }

        public static IEnumerable<Train> GetTrains()
        {
            return trains.AsEnumerable();
        }

        public static IEnumerable<TrainSystemStatus> GetSystemStatus()
        {
            return systemStatus.AsEnumerable();
        }

        public static IEnumerable<TrainMission> GetMission()
        {
            return mission.AsEnumerable();
        }

        public static IEnumerable<TrainAPC> GetTrainAPC()
        {
            return apcData.AsEnumerable();
        }
    }
}
