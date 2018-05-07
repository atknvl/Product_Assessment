using NorthwindProducts.Models;
using ProductsPL.Models;
using System;
using System.Collections.Generic;

namespace ProductsPL.Mapping
{
    public class ProductMapper
    {
        public static ProductPO MapDOtoPO(ProductDO fromDO)
        {
            ProductPO toPO = new ProductPO();
            try
            {
                toPO.ProductName = fromDO.ProductName;
                toPO.QuantityPerUnit = fromDO.QuantityPerUnit;
                toPO.UnitPrice = fromDO.UnitPrice;
                toPO.UnitsInStock = fromDO.UnitsInStock;
                toPO.UnitsOnOrder = fromDO.UnitsOnOrder;
            }
            catch (Exception)
            {
            }
            return toPO;
        }


        public static List<ProductPO> MapDOtoPO(List<ProductDO> fromDO)
        {
            List<ProductPO> toPO = new List<ProductPO>();
            try
            {
                foreach (ProductDO data in fromDO)
                {
                    ProductPO mappedData = MapDOtoPO(data);
                    toPO.Add(mappedData);
                }
            }
            catch (Exception)
            {
            }
            return toPO;
        }


        public static ProductDO MapPOtoDO(ProductPO fromPO)
        {
            ProductDO toDO = new ProductDO();
            try
            {
                toDO.ProductName = fromPO.ProductName;
                toDO.QuantityPerUnit = fromPO.QuantityPerUnit;
                toDO.UnitPrice = fromPO.UnitPrice;
                toDO.UnitsInStock = fromPO.UnitsInStock;
                toDO.UnitsOnOrder = fromPO.UnitsOnOrder;
                return toDO;
            }
            catch (Exception)
            {
            }
            return toDO;
        }


        public static List<ProductDO> MapPOtoDO(List<ProductPO> fromPO)
        {
            List<ProductDO> toDO = new List<ProductDO>();
            try
            {
                foreach (ProductPO data in fromPO)
                {
                    ProductDO mappedData = MapPOtoDO(data);
                    toDO.Add(mappedData);
                }
            }
            catch (Exception)
            {
            }
            return toDO;
        }
    }
}