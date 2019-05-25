﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model_1
{

    //Класс Альбом
    [Serializable]
    public class Album
    {
        //Название Альбома
        public string Name { get; set; }
        //Дата создания 
        [DataType(DataType.Date)]
        public DateTime YearOfBirth { get; set; }
        // Открытый конструктор класса Альбом
        public Album()
        {
            this.Name = "";
            this.YearOfBirth = DateTime.Today;
       
        }



    }
}