using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TShirt
{
    class QuickSortStrategy : ISortStrategy
    {
        //---------------------SIZE-----------
        static void QuickSortBySizeAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizePartitionAscending(tShirts, low, high);
                QuickSortBySizeAscending(tShirts, low, pi - 1);
                QuickSortBySizeAscending(tShirts, pi + 1, high);
            }
        }
        static int QuickSortBySizePartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Size < pivot.Size)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }


        public void QuickSortBySizeDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizePartitionDescending(tShirts, low, high);
                QuickSortBySizeDescending(tShirts, low, pi - 1);
                QuickSortBySizeDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizePartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Size > pivot.Size)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }


        //-----------------COLOR--------------
        static void QuickSortByColorAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionAscending(tShirts, low, high);
                QuickSortByColorAscending(tShirts, low, pi - 1);
                QuickSortByColorAscending(tShirts, pi + 1, high);
            }
        }
        static int QuickSortByColorPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Color < pivot.Color)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }


        public void QuickSortByColorDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionDescending(tShirts, low, high);
                QuickSortByColorDescending(tShirts, low, pi - 1);
                QuickSortByColorDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Color > pivot.Color)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        //----------------------FABRIC-------------------

        static void QuickSortByFabricAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionAscending(tShirts, low, high);
                QuickSortByFabricAscending(tShirts, low, pi - 1);
                QuickSortByFabricAscending(tShirts, pi + 1, high);
            }
        }
        static int QuickSortByFabricPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Fabric < pivot.Fabric)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }


        public void QuickSortByFabricDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionDescending(tShirts, low, high);
                QuickSortByColorDescending(tShirts, low, pi - 1);
                QuickSortByColorDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Fabric > pivot.Fabric)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        //-----------------------------------------------

        static void QuickSortBySizeThenColorThenFabricAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizeThenColorThenFabricPartitionAscending(tShirts, low, high);
                QuickSortBySizeThenColorThenFabricAscending(tShirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricAscending(tShirts, pi + 1, high);
            }
        }
        static int QuickSortBySizeThenColorThenFabricPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Size < pivot.Size)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    if (tShirts[j].Color < pivot.Color)
                    {
                        i++;
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                }
                else if (tShirts[j].Color == pivot.Color)
                {
                    if (tShirts[j].Fabric < pivot.Fabric)
                    {
                        i++;
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }


        public void QuickSortBySizeThenColorThenFabricDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizeThenColorThenFabricPartitionDescending(tShirts, low, high);
                QuickSortBySizeThenColorThenFabricDescending(tShirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizeThenColorThenFabricPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tShirts[j].Size > pivot.Size)
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    if (tShirts[j].Color > pivot.Color)
                    {
                        i++;
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                }
                else if (tShirts[j].Color == pivot.Color)
                {
                    if (tShirts[j].Fabric > pivot.Fabric)
                    {
                        i++;
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }
    }
}
