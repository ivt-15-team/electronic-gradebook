using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class ControlType
    {
        [Key]
        public int Id { get; set; }

        private string _name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
    }
}
