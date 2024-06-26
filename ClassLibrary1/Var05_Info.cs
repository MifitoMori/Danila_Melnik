﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Var05_Info
    {
        private string name = "";
        private string surname = "";
        private string patronymic = "";
        private string birthday = "";
        private Var04_Group group;

        public Var05_Info(string name, string surname, string patronymic, string birthday, string group)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
            Group = group;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Group
        {
            get { return group.ToString(); }
            set { group = Var04_Group.ToString(value); }
        }
    }
}
