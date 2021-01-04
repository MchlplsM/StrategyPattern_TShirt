using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TShirt
{
    class CashPaymentStrategy : IPaymentStrategy
    {
        public void DoPayment(TShirt tshirt)
        {
            decimal basePrice = 0.0m;
            switch (tshirt.Fabric)
            {
                case Fabric.WOOL:
                case Fabric.COTTON:
                    basePrice = 20.0m;
                    break;
                case Fabric.POLYESTER:
                case Fabric.RAYON:
                    basePrice = 15.0m;
                    break;
                case Fabric.LINEN:
                case Fabric.CASHMERE:
                case Fabric.SILK:
                    basePrice = 30.0m;
                    break;
            }
        }
    }
}
