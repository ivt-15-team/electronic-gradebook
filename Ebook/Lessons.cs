﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class Lessons
    {
        [Key]
        public int Id { get; set; }

        private Employee lect;
        private string _name;
        private DateTime _date;
        private Group group;

        //Setters and Getters

        public string name
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

        public DateTime date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }

        /*public Object lecturer
        {
            get
            {
                return this.lect;
            }
            set
            {
                this.lect = value;
            }
        }
        */
    }
}