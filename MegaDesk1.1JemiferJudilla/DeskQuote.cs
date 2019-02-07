using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace MegaDesk_3_JemiferJudilla
{
    class DeskQuote
    {
        #region Object member variables
        private string date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        private Desk newDesk = new Desk();
       
        #endregion

        #region local variables
       
        private int RushCost;
        private int MaterialCost;
        private int SurfaceArea;
        private int SizeCost;
        private int DrawerCost;
     
        #endregion

        private const int BASE_PRICE = 200;
        private const int SIZE_TRESHHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;

       //I still have to work on my quote total because there's something wrong with the formula. 
       //When I use the method instead of the return variable, it asks me for parameters but I always get errors.
        public int QuoteTotal()
        {

            return BASE_PRICE + SizeCost + DrawerCost + MaterialCost + RushCost;
        }

        private int CalcSurfaceArea(int width, int depth)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
            SurfaceArea = newDesk.Width * newDesk.Depth;
            return SurfaceArea;
        }


        public int RushOrderCost(int rushDays, int width, int depth)
        {

            newDesk.RushDays = rushDays;
            newDesk.Width = width;
            newDesk.Depth = depth;
            SurfaceArea = newDesk.Width * newDesk.Depth;

            if (SurfaceArea < 1000)
            {
                switch (rushDays)
                {
                    case 3:
                        RushCost = 60;
                        break;
                    case 5:
                        RushCost = 40;
                        break;
                    case 7:
                        RushCost = 30;
                        break;
                }
            }
            else if (SurfaceArea < 2000)
            {
                switch (rushDays)
                {
                    case 3:
                        RushCost = 70;
                        break;
                    case 5:
                        RushCost = 50;
                        break;
                    case 7:
                        RushCost = 35;
                        break;
                }
            }
            else if (SurfaceArea > 2000)
            {
                switch (rushDays)
                {
                    case 3:
                        RushCost = 80;
                        break;
                    case 5:
                        RushCost = 60;
                        break;
                    case 7:
                        RushCost = 40;
                        break;
                }
            }
            else
            {
                RushCost = 0;
            }
            return RushCost;
        }

        private int calcSizeCost(int width, int depth)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
            SurfaceArea = newDesk.Width * newDesk.Depth;
            if (SurfaceArea <= 1000)
            {
                SizeCost = SIZE_TRESHHOLD;
            }
            else
            {
                SizeCost = SIZE_TRESHHOLD + (SurfaceArea - SIZE_TRESHHOLD);
            }

            return SizeCost;
        }

        private int CalcDrawerCost(int numDrawers)
        {
            newDesk.NumberOfDrawers = numDrawers;
            DrawerCost = newDesk.NumberOfDrawers * PRICE_PER_DRAWER;
            return DrawerCost;
        }

        public int calcMaterialCost(string material)
        {
            newDesk.Material = material;
            switch (newDesk.Material)
            {
                case "Pine":
                    MaterialCost = 50;
                    break;
                case "Laminate":
                    MaterialCost = 100;
                    break;
                case "Veneer":
                    MaterialCost = 125;
                    break;
                case "Oak":
                    MaterialCost = 200;
                    break;
                case "Rosewood":
                    MaterialCost = 300;
                    break;
            }
            return MaterialCost;
        }



    }



}




    

