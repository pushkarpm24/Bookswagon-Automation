﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWagon.JsonFile
{
    class Credentials
    {
        public string email = "";
        public string password = "";
        public string json = "";

        public Credentials()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\HP\\source\\repos\\BooksWagon\\BooksWagon\\JsonFile\\Cred.json"))
            {
                json = r.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(json);
            Console.WriteLine("Array::::" + array["email"]);
            email = array["email"];
            password = array["password"];
        }
    }
}
