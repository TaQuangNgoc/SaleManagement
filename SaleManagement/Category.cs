using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement
{
    class Category
    {
        private string categoryName, description;

        public string CategoryName
        {
            get
            {
                return categoryName;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public Category(string categoryName, string description)
        {
            this.categoryName = categoryName;
            this.description = description;
        }
    }
}
