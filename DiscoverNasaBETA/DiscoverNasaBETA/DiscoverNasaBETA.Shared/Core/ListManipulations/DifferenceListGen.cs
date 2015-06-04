using DiscoverNasaBETA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverNasaBETA.Core.ListManipulations
{
    class DifferenceListGen<T> : IDifferenceList<T>
    {

        public List<T> minuend
        {
            get
            {
                return minuend;
            }

            set
            {
                if (value!=null)
                {
                    minuend=value;
                }
                else throw new ArgumentNullException();
            }
        }

        public List<T> subtrahend
        {
            get
            {
                return subtrahend;
            }

            set
            {
                if (value!=null)
                {
                    subtrahend=value;
                }
                else
                    throw new ArgumentNullException();
            }
        }

        public List<T> GetDifference()
        {
            //throw new NotImplementedException();
            List<T> newList = new List<T>();
            foreach (var item in subtrahend)
            {
                foreach (var minuend_item in minuend)
                {
                    if (!minuend_item.Equals(item))
                        newList.Add(minuend_item);

                }
                if (newList.Count==minuend.Count)
                {
                    return newList;
                }
            }

            return newList;
        }
    }
}
