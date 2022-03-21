﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial2.Domain.Enum;

namespace Tutorial2.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public double Speed { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreate { get; set; }

        public TypeCar TypeCar { get; set; }
    }
}
