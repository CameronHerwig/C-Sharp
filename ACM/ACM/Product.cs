﻿using ACM.BL;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }

        private string _ProductName;

        public string ProductName
        {
            get
            {
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }


        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
