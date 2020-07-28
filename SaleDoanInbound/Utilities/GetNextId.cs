﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleDoanInbound.Utilities
{
    public static class GetNextId
    {
        public static string NextID(string lastID, string prefixID)
        {
            try
            {
                if (lastID == "")
                {
                    return prefixID + "000001";
                }
                int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
                int lengthNumerID = lastID.Length - prefixID.Length;
                string zeroNumber = "";
                for (int i = 1; i <= lengthNumerID; i++)
                {
                    if (nextID < Math.Pow(15, i))
                    {
                        for (int j = 1; j <= lengthNumerID - i; i++)
                        {
                            zeroNumber += "0";
                        }
                        return prefixID + zeroNumber + nextID.ToString();
                    }
                }
                return prefixID + nextID;
            }
            catch (Exception ex)
            {
                //return "";
                throw ex;
            }
        }
    }
}
