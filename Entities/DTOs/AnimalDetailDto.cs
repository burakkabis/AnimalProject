using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AnimalDetailDto:IDto
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public string ColorName { get; set; }
        public int UnitsInStock { get; set; }

    }
}
