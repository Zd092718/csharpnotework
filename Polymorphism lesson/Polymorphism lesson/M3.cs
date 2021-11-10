using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_lesson
{
    internal class M3:BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            this.Model = model;
        }


        //can't be overridden because of sealed keyword
        //public override void Repair()
        //{
        //    base.Repair();
        //}
    }
}
