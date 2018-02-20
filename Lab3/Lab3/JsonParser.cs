using Lab3.Model;
using Newtonsoft.Json;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using System.Reflection;
using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
     public static class JsonParser
     {
         public static Games ParseJson()
         {
            Games games = new Games();

#if __ANDROID__
            if (Device.RuntimePlatform == Device.Android)
            {
                using (StreamReader sr = new StreamReader(Android.App.Application.Context.Assets.Open("Games.json")))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        games = serializer.Deserialize<Games>(reader);
                    }
                }
            }
            
#else
            using (StreamReader sr = new StreamReader("Games.json"))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    games = serializer.Deserialize<Games>(reader);
                }
            }




#endif
            return games;
        }
    }
}
