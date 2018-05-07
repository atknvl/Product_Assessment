using NorthwindProducts;
using NorthwindProducts.Models;
using ProductsPL.Models;
using ProductsPL.Mapping;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProductsPL.Controllers
{
    public class ProductController : Controller
    {
        //---Declare & instantiate dependencies---//
        private ProductDAO dataAccess;


        public ProductController()
        {
            dataAccess = new ProductDAO();
        }

        /// <summary>
        /// Returns mapped Products (DO & PO) to Index via View()
        /// </summary>
        public ActionResult Index()
        {
            List<ProductPO> mappedData = new List<ProductPO>();
            try
            {
                List<ProductDO> dataObjects = dataAccess.ViewAllProducts();
                mappedData = ProductMapper.MapDOtoPO(dataObjects);
            }
            catch (Exception e)
            {
            }
            return View(mappedData);
        }
    }
}