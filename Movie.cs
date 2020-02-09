using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    public class Movie
    {
        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        private string _title;
        private string _category;

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = Category;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }






    }
}
