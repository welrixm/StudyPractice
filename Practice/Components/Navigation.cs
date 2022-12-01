﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Practice.Pages;

namespace Practice.Components
{
    internal class Navigation
    {
        public static Frame frameMain;
        public static User AuthUser = null;
        public static bool isAuth = false;
        public static List<Navig> navigs = new List<Navig>();
        private static MainWindow main;

        public static void BackPage()
        {
            if(navigs.Count > 1)
            {
                navigs.RemoveAt(navigs.Count - 1);
            }
        }
        private static void Update(Navig navig)
        {
            
        }
       
    }
    class Navig
    {
        public string Title { get; set; }
        public Page Page { get; set; }
        public Navig(string title, Page page)
        {
            Title = title;
            Page = page;
        }
    }
}
