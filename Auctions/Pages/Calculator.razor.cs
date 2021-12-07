using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    partial class Calculator
    {
        [Parameter]
        public int Number { get; set; } = 0;
       // private int number1 = 0;
        private int number2 = 0;
        private int total = 0;

        void Add()
        {
            total = Number + number2;
        }

        void Clear()
        {
            Number = 0;
            number2 = 0;
            total = 0;
        }

    }
}
