﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FetchData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Login();
        }
        
        public async void Login()
        {          

           var httpClient = new HttpClient();
         
           var reponse = await httpClient.GetStringAsync("https://localhost:44325/api/Logins1");
            Console.WriteLine(reponse);

             var login = JsonConvert.DeserializeObject<List<Login>>(reponse);
              ListLogin.ItemsSource = login;

           
        }


    }
}
