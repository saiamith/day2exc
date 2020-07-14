﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiondemo
{
    class mobilecatalog
    {
        List<Mobile> mobileList;

        internal mobilecatalog()
        {
            mobileList = new List<Mobile>();
        }

        internal void Add(Mobile mobile)
        {
            mobileList.Add(mobile);
            //mobileList.Add("My Mobile");
        }

        internal Mobile GetMobile(int mobileId)
        {
            foreach (Mobile mobile in mobileList)
            {
                if (mobile.GetProductId() == mobileId)
                {
                    return mobile;
                }
            }
            return null;
        }

        internal List<Mobile> GetMobiles()
        {
            return mobileList;
        }
    }
}
